namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Faithful port of <c>AdgConfigureInstrumentRouting_090D</c> from
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c> (oracle line 1335).
/// Dynamic operator-slot allocator invoked once per
/// <c>ProgramChange</c>: computes the four routing bytes for the
/// channel (<c>ChannelRoute</c>, <c>PrimaryRoute</c>,
/// <c>SecondaryRoute</c>, <c>RouteShadow</c>) plus the post-state of
/// the global fade-scratch cells and the per-channel state-scratch
/// word.
/// <para>
/// Verified against live Spice86 MCP CFG-CPU evidence (function entry
/// 5BAE:090D, 240 hits during ADG388 playback). Bytes of the
/// 32-byte operator-allocation lookup table embedded at offsets
/// 0x08ED..0x090C of the driver image were captured via
/// <c>read_memory</c> on the same session.
/// </para>
/// </summary>
public static class AdgInstrumentRoutingConfigurator {
    /// <summary>
    /// Operator-pair allocation table embedded at driver offset 0x08ED.
    /// Indexed by <c>(~BP &amp; 0x01C0) &gt;&gt; 4</c>; each entry is a
    /// pair of little-endian ushorts (AX, BX) at +0 / +2. Captured from
    /// the live ADG driver image (5BAE:08ED). Entries for BX in
    /// {0, 1, 2, 3} are never consumed by the routine but are kept
    /// here so the table layout matches the runtime image bit-for-bit.
    /// </summary>
    internal static readonly byte[] OperatorAllocationTable = new byte[] {
        0xE9, 0xA5, 0x06, 0xC3, 0x10, 0x06, 0x40, 0x00,
        0x11, 0x07, 0x80, 0x00, 0x11, 0x07, 0x80, 0x00,
        0x12, 0x08, 0x00, 0x01, 0x12, 0x08, 0x00, 0x01,
        0x12, 0x08, 0x00, 0x01, 0x12, 0x08, 0x00, 0x01,
    };

    /// <summary>
    /// Patch-type constant indicating a 4-operator OPL3 patch. The
    /// driver checks <c>ES:[SI] == 4</c> to take the 4-op routing
    /// branch.
    /// </summary>
    public const byte FourOperatorPatchType = 0x04;

    /// <summary>
    /// Applies the routing decision for one channel. Mutates
    /// <paramref name="routingTable"/> at slot
    /// <paramref name="channelIndex"/> and the supplied scratch state
    /// in place.
    /// </summary>
    /// <param name="channelIndex">Channel slot to configure (0..17).</param>
    /// <param name="patchType">Byte at <c>ES:[SI]</c>: <see cref="FourOperatorPatchType"/> takes the 4-op branch.</param>
    /// <param name="fadeScratch">Global fade-scratch cells (driver 0x013E / 0x0140), mutated in place.</param>
    /// <param name="channelStateScratch">18-slot state-scratch table (driver DI+0x021C), mutated in place at <paramref name="channelIndex"/>.</param>
    /// <param name="routingTable">Per-channel routing destination, mutated in place at <paramref name="channelIndex"/>.</param>
    public static void Configure(
        int channelIndex,
        byte patchType,
        AdgFadeScratchState fadeScratch,
        AdgChannelStateScratch channelStateScratch,
        AdgChannelRoutingTable routingTable) {
        ArgumentNullException.ThrowIfNull(fadeScratch);
        ArgumentNullException.ThrowIfNull(channelStateScratch);
        ArgumentNullException.ThrowIfNull(routingTable);
        if (channelIndex < 0 || channelIndex >= AdgChannelRoutingTable.ChannelCount) {
            throw new ArgumentOutOfRangeException(nameof(channelIndex));
        }

        ushort bp = fadeScratch.Primary;
        ushort cx = fadeScratch.Secondary;
        ushort ax = (ushort)~channelStateScratch.Get(channelIndex);
        if ((ax & 0x8000) == 0) {
            cx = (ushort)(cx & ax);
        } else {
            bp = (ushort)(bp & ax);
        }

        ushort bx;
        ax = 0;

        if (patchType == FourOperatorPatchType) {
            if (Try4OpPrimary(0x0009, 0x0000, ref bp, out bx, out ax) ||
                Try4OpPrimary(0x0012, 0x0101, ref bp, out bx, out ax) ||
                Try4OpPrimary(0x0024, 0x0202, ref bp, out bx, out ax) ||
                Try4OpSecondary(0x0009, 0x8080, ref cx, out bx, out ax) ||
                Try4OpSecondary(0x0012, 0x8181, ref cx, out bx, out ax) ||
                Try4OpSecondary(0x0024, 0x8282, ref cx, out bx, out ax)) {
                WriteBack(channelIndex, ax, bx, bp, cx, fadeScratch, channelStateScratch, routingTable);
                return;
            }
        }

        bx = (ushort)(~bp & 0x01C0);
        if (bx != 0) {
            bx = (ushort)(bx >> 4);
            ax = ReadAllocationWord((ushort)(0x08ED + bx));
            bx = ReadAllocationWord((ushort)(0x08EF + bx));
            bp = (ushort)(bp | bx);
            WriteBack(channelIndex, ax, bx, bp, cx, fadeScratch, channelStateScratch, routingTable);
            return;
        }

        bx = (ushort)~cx;
        if ((bx & 0x01C0) != 0) {
            bx = (ushort)((bx & 0x01C0) >> 4);
            ax = ReadAllocationWord((ushort)(0x08ED + bx));
            bx = ReadAllocationWord((ushort)(0x08EF + bx));
            ax = (ushort)(ax | 0x8080);
            cx = (ushort)(cx | bx);
            bx = Make16(Lo8(bx), (byte)(Hi8(bx) | 0x80));
            WriteBack(channelIndex, ax, bx, bp, cx, fadeScratch, channelStateScratch, routingTable);
            return;
        }

        // Neither high-block path took: pick a free 2-op slot via
        // the XOR-folded nibble selector (oracle lines 1410..1470).
        byte foldedBh = (byte)(((Lo8(bx) >> 3) ^ Lo8(bx)) & 0x07);
        if (foldedBh != 0) {
            bool carry = (foldedBh & 0x01) != 0;
            foldedBh = (byte)(foldedBh >> 1);
            if (carry) {
                ChooseSecondary0(channelIndex, ref bx, ref bp, ref cx, ref ax, fadeScratch, channelStateScratch, routingTable);
                return;
            }
            carry = (foldedBh & 0x01) != 0;
            if (carry) {
                ChooseSecondary1(channelIndex, ref bx, ref bp, ref cx, ref ax, fadeScratch, channelStateScratch, routingTable);
                return;
            }
            ChooseSecondary2(channelIndex, ref bx, ref bp, ref cx, ref ax, fadeScratch, channelStateScratch, routingTable);
            return;
        }

        ax = bp;
        byte folded = (byte)((Lo8(ax) ^ (Lo8(ax) >> 3)) & 0x07);
        if (folded != 0) {
            bx = (ushort)~bp;
            bool carry = (folded & 0x01) != 0;
            folded = (byte)(folded >> 1);
            if (carry) {
                ChoosePrimary0(channelIndex, ref bx, ref bp, ref cx, ref ax, fadeScratch, channelStateScratch, routingTable);
                return;
            }
            carry = (folded & 0x01) != 0;
            if (carry) {
                ChoosePrimary1(channelIndex, ref bx, ref bp, ref cx, ref ax, fadeScratch, channelStateScratch, routingTable);
                return;
            }
            ChoosePrimary2(channelIndex, ref bx, ref bp, ref cx, ref ax, fadeScratch, channelStateScratch, routingTable);
            return;
        }

        bx = (ushort)(bx & 0x003F);
        if (bx == 0) {
            bx = (ushort)~bp;
            if ((bx & 0x0024) != 0) {
                ChoosePrimary2(channelIndex, ref bx, ref bp, ref cx, ref ax, fadeScratch, channelStateScratch, routingTable);
                return;
            }
            if ((bx & 0x0012) != 0) {
                ChoosePrimary1(channelIndex, ref bx, ref bp, ref cx, ref ax, fadeScratch, channelStateScratch, routingTable);
                return;
            }
            ChoosePrimary0(channelIndex, ref bx, ref bp, ref cx, ref ax, fadeScratch, channelStateScratch, routingTable);
            return;
        }

        if ((bx & 0x0024) != 0) {
            ChooseSecondary2(channelIndex, ref bx, ref bp, ref cx, ref ax, fadeScratch, channelStateScratch, routingTable);
            return;
        }
        if ((bx & 0x0012) != 0) {
            ChooseSecondary1(channelIndex, ref bx, ref bp, ref cx, ref ax, fadeScratch, channelStateScratch, routingTable);
            return;
        }
        ChooseSecondary0(channelIndex, ref bx, ref bp, ref cx, ref ax, fadeScratch, channelStateScratch, routingTable);
    }

    private static bool Try4OpPrimary(ushort probe, ushort axValue, ref ushort bp, out ushort bx, out ushort ax) {
        bx = probe;
        if ((bp & bx) != 0) {
            bp = (ushort)(bp | bx);
            ax = axValue;
            return true;
        }
        ax = 0;
        return false;
    }

    private static bool Try4OpSecondary(ushort probe, ushort axValue, ref ushort cx, out ushort bx, out ushort ax) {
        bx = probe;
        if ((cx & bx) != 0) {
            cx = (ushort)(cx | bx);
            bx = Make16(Lo8(bx), (byte)(Hi8(bx) | 0x80));
            ax = axValue;
            return true;
        }
        ax = 0;
        return false;
    }

    private static void ChoosePrimary0(int channelIndex, ref ushort bx, ref ushort bp, ref ushort cx, ref ushort ax,
        AdgFadeScratchState fadeScratch, AdgChannelStateScratch channelStateScratch, AdgChannelRoutingTable routingTable) {
        ax = 0;
        bx = (ushort)(bx & 0x0001);
        if (bx == 0) {
            ax = 0x0308;
            bx = Make16(0x08, Hi8(bx));
        }
        bp = (ushort)(bp | bx);
        WriteBack(channelIndex, ax, bx, bp, cx, fadeScratch, channelStateScratch, routingTable);
    }

    private static void ChoosePrimary1(int channelIndex, ref ushort bx, ref ushort bp, ref ushort cx, ref ushort ax,
        AdgFadeScratchState fadeScratch, AdgChannelStateScratch channelStateScratch, AdgChannelRoutingTable routingTable) {
        ax = 0x0101;
        bx = (ushort)(bx & 0x0002);
        if (bx == 0) {
            ax = 0x0409;
            bx = Make16(0x10, Hi8(bx));
        }
        bp = (ushort)(bp | bx);
        WriteBack(channelIndex, ax, bx, bp, cx, fadeScratch, channelStateScratch, routingTable);
    }

    private static void ChoosePrimary2(int channelIndex, ref ushort bx, ref ushort bp, ref ushort cx, ref ushort ax,
        AdgFadeScratchState fadeScratch, AdgChannelStateScratch channelStateScratch, AdgChannelRoutingTable routingTable) {
        ax = 0x0202;
        bx = (ushort)(bx & 0x0004);
        if (bx == 0) {
            ax = 0x050A;
            bx = Make16(0x20, Hi8(bx));
        }
        bp = (ushort)(bp | bx);
        WriteBack(channelIndex, ax, bx, bp, cx, fadeScratch, channelStateScratch, routingTable);
    }

    private static void ChooseSecondary0(int channelIndex, ref ushort bx, ref ushort bp, ref ushort cx, ref ushort ax,
        AdgFadeScratchState fadeScratch, AdgChannelStateScratch channelStateScratch, AdgChannelRoutingTable routingTable) {
        ax = 0x8080;
        bx = (ushort)(bx & 0x0001);
        if (bx == 0) {
            ax = 0x8388;
            bx = Make16(0x08, Hi8(bx));
        }
        cx = (ushort)(cx | bx);
        bx = Make16(Lo8(bx), (byte)(Hi8(bx) | 0x80));
        WriteBack(channelIndex, ax, bx, bp, cx, fadeScratch, channelStateScratch, routingTable);
    }

    private static void ChooseSecondary1(int channelIndex, ref ushort bx, ref ushort bp, ref ushort cx, ref ushort ax,
        AdgFadeScratchState fadeScratch, AdgChannelStateScratch channelStateScratch, AdgChannelRoutingTable routingTable) {
        ax = 0x8181;
        bx = (ushort)(bx & 0x0002);
        if (bx == 0) {
            ax = 0x8489;
            bx = Make16(0x10, Hi8(bx));
        }
        cx = (ushort)(cx | bx);
        bx = Make16(Lo8(bx), (byte)(Hi8(bx) | 0x80));
        WriteBack(channelIndex, ax, bx, bp, cx, fadeScratch, channelStateScratch, routingTable);
    }

    private static void ChooseSecondary2(int channelIndex, ref ushort bx, ref ushort bp, ref ushort cx, ref ushort ax,
        AdgFadeScratchState fadeScratch, AdgChannelStateScratch channelStateScratch, AdgChannelRoutingTable routingTable) {
        ax = 0x8282;
        bx = (ushort)(bx & 0x0004);
        if (bx == 0) {
            ax = 0x858A;
            bx = Make16(0x20, Hi8(bx));
        }
        cx = (ushort)(cx | bx);
        bx = Make16(Lo8(bx), (byte)(Hi8(bx) | 0x80));
        WriteBack(channelIndex, ax, bx, bp, cx, fadeScratch, channelStateScratch, routingTable);
    }

    private static void WriteBack(int channelIndex, ushort ax, ushort bx, ushort bp, ushort cx,
        AdgFadeScratchState fadeScratch, AdgChannelStateScratch channelStateScratch, AdgChannelRoutingTable routingTable) {
        channelStateScratch.Set(channelIndex, bx);
        fadeScratch.SetPrimary(bp);
        fadeScratch.SetSecondary(cx);
        byte channelRoute = Hi8(ax);
        byte primaryRoute = Lo8(ax);
        ushort axShadow = (ushort)(ax + 0x0303);
        byte routeShadow = Hi8(axShadow);
        byte secondaryRoute = Lo8(axShadow);
        routingTable.SetEntry(channelIndex, channelRoute, primaryRoute, secondaryRoute, routeShadow);
    }

    private static ushort ReadAllocationWord(ushort offset) {
        int index = offset - 0x08ED;
        if (index < 0 || index + 1 >= OperatorAllocationTable.Length) {
            throw new InvalidOperationException(
                $"AdgConfigureInstrumentRouting_090D attempted out-of-range lookup at 0x{offset:X4}.");
        }
        return (ushort)(OperatorAllocationTable[index] | (OperatorAllocationTable[index + 1] << 8));
    }

    private static byte Lo8(ushort value) {
        return (byte)(value & 0xFF);
    }

    private static byte Hi8(ushort value) {
        return (byte)((value >> 8) & 0xFF);
    }

    private static ushort Make16(byte lo, byte hi) {
        return (ushort)((hi << 8) | lo);
    }
}
