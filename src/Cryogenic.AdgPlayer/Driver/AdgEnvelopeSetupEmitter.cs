namespace Cryogenic.AdgPlayer.Driver;

using Cryogenic.AdgPlayer.Opl;

/// <summary>
/// Faithful port of <c>AdgEnvelopeSetup_0C47</c> (oracle:
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs:1592</c>). Applies
/// the velocity-scaled TL shaping to the primary and secondary
/// operators of the routed channel, optionally extends the same
/// pass to the patch-4 operator pair, and finally publishes the
/// connection-shape result to the OPL <c>0xC0</c> register family.
/// </summary>
/// <remarks>
/// Mirrors the exact branching shape and quirks of the C# override:
/// <list type="bullet">
///   <item>Primary/secondary TL pass uses
///         <see cref="AdgEnvelopeTlShapingComputer"/> (defaults
///         scale to <c>inverseVelocity</c>; switches to
///         <c>directVelocity</c> when the shaping byte's sign bit
///         is set).</item>
///   <item>The patch-4 TL pass replicates the oracle quirk that
///         tests <c>(sbyte)scale &lt; 0</c> rather than the shaping
///         byte's sign bit. With the default
///         <c>inverseVelocity = 0x80 - velocity</c> this branch fires
///         only when <c>velocity == 0</c>.</item>
///   <item>The connection-shape tail writes to the high byte of
///         the connection-modulation slot pair (= the
///         <c>AdgChannelConnectionCurrentOffset</c> byte at
///         <c>DI+0x1B1</c>) and emits the new value via the
///         channel-routed <c>0xC0</c> register.</item>
/// </list>
/// </remarks>
public static class AdgEnvelopeSetupEmitter {
    private const byte ConnectionShapingBias = 0x06;
    private const byte FeedbackConnectionRegisterBase = 0xC0;
    private const byte ConnectionLowMask = 0x0F;
    private const byte ConnectionPanMask = 0x30;
    private const byte ConnectionOverflowFlag = 0x0E;
    private const byte Patch4OperatorRouteBias = 0x08;
    private const byte Patch4Marker = 0x04;
    private const byte SignBit = 0x80;

    /// <summary>
    /// Emits the full <c>AdgEnvelopeSetup_0C47</c> sequence for
    /// <paramref name="channelIndex"/>. Reads shaping inputs from
    /// the driver state slots; writes back updated current operator
    /// levels and connection bytes.
    /// </summary>
    public static void Emit(IOplBus bus, AdgChannelRoutingTable routingTable,
        AdgChannelCurrentOperatorLevels currentOperatorLevels,
        AdgChannelTlShapingSlots tlShapingSlots,
        AdgChannelPatchTypeSlots patchTypeSlots,
        AdgChannelPatch4CurrentOperatorLevels patch4CurrentOperatorLevels,
        AdgChannelPatch4TlShapingSlots patch4TlShapingSlots,
        AdgChannelConnectionShapingSlots connectionShapingSlots,
        AdgChannelConnectionModulationSlots connectionModulationSlots,
        int channelIndex, byte velocity) {
        ArgumentNullException.ThrowIfNull(bus);
        ArgumentNullException.ThrowIfNull(routingTable);
        ArgumentNullException.ThrowIfNull(currentOperatorLevels);
        ArgumentNullException.ThrowIfNull(tlShapingSlots);
        ArgumentNullException.ThrowIfNull(patchTypeSlots);
        ArgumentNullException.ThrowIfNull(patch4CurrentOperatorLevels);
        ArgumentNullException.ThrowIfNull(patch4TlShapingSlots);
        ArgumentNullException.ThrowIfNull(connectionShapingSlots);
        ArgumentNullException.ThrowIfNull(connectionModulationSlots);

        byte directVelocity = velocity;
        byte inverseVelocity = (byte)(0x80 - velocity);

        AdgChannelRoutingEntry entry = routingTable.GetEntry(channelIndex);
        byte primaryRoute = entry.PrimaryRoute;
        byte secondaryRoute = entry.SecondaryRoute;
        byte channelRoute = entry.ChannelRoute;

        ushort operatorLevel = currentOperatorLevels.Get(channelIndex);
        ushort tlShape = tlShapingSlots.Get(channelIndex);

        AdgEnvelopeTlShapingComputer.OperatorResult primary =
            AdgEnvelopeTlShapingComputer.ComputePrimary(
                operatorLevel, tlShape, directVelocity, inverseVelocity);
        if (primary.Active) {
            AdgOperatorLevelEmitter.Emit(bus, primaryRoute, primary.NewLevel);
            operatorLevel = (ushort)((operatorLevel & 0xFF00) | primary.NewLevel);
        }

        AdgEnvelopeTlShapingComputer.OperatorResult secondary =
            AdgEnvelopeTlShapingComputer.ComputeSecondary(
                operatorLevel, tlShape, directVelocity, inverseVelocity);
        if (secondary.Active) {
            AdgOperatorLevelEmitter.Emit(bus, secondaryRoute, secondary.NewLevel);
            operatorLevel = (ushort)((operatorLevel & 0x00FF) | (secondary.NewLevel << 8));
        }

        currentOperatorLevels.Set(channelIndex, operatorLevel);

        if (patchTypeSlots.Get(channelIndex) == Patch4Marker) {
            ushort patch4Level = patch4CurrentOperatorLevels.Get(channelIndex);
            ushort patch4Shape = patch4TlShapingSlots.Get(channelIndex);

            byte loShape = (byte)(patch4Shape & 0xFF);
            if (loShape != 0) {
                // Oracle quirk: tests sbyte sign of *scale* (default
                // inverseVelocity) rather than the shaping byte.
                byte scale = inverseVelocity;
                byte shaping = loShape;
                if ((sbyte)scale < 0) {
                    shaping = (byte)(0 - shaping);
                    scale = directVelocity;
                }
                shaping = (byte)(0 - (byte)(shaping - 0x04));
                scale = (byte)(scale >> shaping);
                byte level = (byte)(patch4Level & 0xFF);
                int sum = (level & 0x3F) + scale;
                byte tl = sum > 0x3F ? (byte)0x3F : (byte)sum;
                byte newLevel = (byte)((level & 0xC0) | tl);
                patch4Level = (ushort)((patch4Level & 0xFF00) | newLevel);
                AdgOperatorLevelEmitter.Emit(bus,
                    (byte)(primaryRoute + Patch4OperatorRouteBias), newLevel);
            }

            byte hiShape = (byte)((patch4Shape >> 8) & 0xFF);
            if (hiShape != 0) {
                byte scale = inverseVelocity;
                byte shaping = hiShape;
                if ((sbyte)scale < 0) {
                    shaping = (byte)(0 - shaping);
                    scale = directVelocity;
                }
                byte shift = (byte)(0x04 - shaping);
                scale = (byte)(scale >> shift);
                byte level = (byte)((patch4Level >> 8) & 0xFF);
                int sum = (level & 0x3F) + scale;
                byte tl = sum > 0x3F ? (byte)0x3F : (byte)sum;
                byte newLevel = (byte)((level & 0xC0) | tl);
                patch4Level = (ushort)((patch4Level & 0x00FF) | (newLevel << 8));
                AdgOperatorLevelEmitter.Emit(bus,
                    (byte)(secondaryRoute + Patch4OperatorRouteBias), newLevel);
            }

            patch4CurrentOperatorLevels.Set(channelIndex, patch4Level);
        }

        ushort connectionShape = connectionShapingSlots.Get(channelIndex);
        byte connectionShapeLo = (byte)(connectionShape & 0xFF);
        byte connectionShapeHi = (byte)((connectionShape >> 8) & 0xFF);
        ushort modulationSlot = connectionModulationSlots.Get(channelIndex);

        if (connectionShapeLo == 0) {
            modulationSlot = (ushort)((modulationSlot & 0x00FF) | (connectionShapeHi << 8));
            connectionModulationSlots.Set(channelIndex, modulationSlot);
            return;
        }

        byte connectionScaleMode = connectionShapeLo;
        byte connectionScale = inverseVelocity;
        if ((connectionScaleMode & SignBit) != 0) {
            connectionScaleMode = (byte)(0 - connectionScaleMode);
            connectionScale = directVelocity;
        }
        connectionScaleMode = (byte)(0 - (byte)(connectionScaleMode - ConnectionShapingBias));
        connectionScale = (byte)(connectionScale >> connectionScaleMode);
        connectionScale = (byte)(connectionScale & 0xFE);
        connectionScale = (byte)(connectionScale + connectionShapeHi);
        if (connectionScale > 0x0F) {
            connectionScale = (byte)((connectionScale & ConnectionLowMask) | ConnectionOverflowFlag);
        }
        connectionScale = (byte)((connectionScale & ConnectionLowMask)
            | (connectionShapeHi & ConnectionPanMask));

        modulationSlot = (ushort)((modulationSlot & 0x00FF) | (connectionScale << 8));
        connectionModulationSlots.Set(channelIndex, modulationSlot);

        AdgRoutedRegister routed = AdgChannelRouter.Route(
            FeedbackConnectionRegisterBase, channelRoute);
        bus.WriteRegister(routed.Chip, routed.Register, connectionScale);
    }
}
