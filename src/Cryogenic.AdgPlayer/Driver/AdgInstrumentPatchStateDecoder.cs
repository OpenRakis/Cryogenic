namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Pure decoder that derives the per-channel shaping / modulation /
/// pitch state from a 40-byte instrument patch record. Faithful port
/// of the state-mutation block in <c>AdgProgramChange_0831</c>
/// (<c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>, lines 1551 to
/// 1586). The bit-twiddling and rotate-right reproductions here are
/// exact; OPL register emit and the dynamic operator-slot allocator
/// remain out of scope (see <c>AdgConfigureInstrumentRouting_090D</c>
/// for the allocator and <c>AdgInstrumentPatchEmitter</c> for the
/// emit path).
/// </summary>
public static class AdgInstrumentPatchStateDecoder {
	/// <summary>Required length of the patch record (full 4-op).</summary>
	public const int Patch4Length = 0x50;

	/// <summary>Required length of the patch record (basic 2-op).</summary>
	public const int Patch2Length = 0x28;

	/// <summary>Decoded per-channel shaping state.</summary>
	public readonly struct DecodedState {
		/// <summary>Patch type byte at offset 0x00.</summary>
		public byte PatchType { get; init; }

		/// <summary>Pitch-mode byte (low half of word at patch 0x21).</summary>
		public byte PitchMode { get; init; }

		/// <summary>Pitch-transpose byte (high half of word at patch 0x21).</summary>
		public byte PitchTranspose { get; init; }

		/// <summary>Composed envelope-shaping word.</summary>
		public ushort EnvShaping { get; init; }

		/// <summary>TL-shaping word from patch offset 0x1E.</summary>
		public ushort TlShaping { get; init; }

		/// <summary>Volume-modulation word from patch offset 0x26.</summary>
		public ushort VolumeModulation { get; init; }

		/// <summary>Composed connection-shaping word.</summary>
		public ushort ConnectionShaping { get; init; }

		/// <summary>Connection-modulation pair (low=rate, high=current).</summary>
		public ushort ConnectionModulation { get; init; }

		/// <summary>High byte of pitch accumulator (DI+0xD9 mirror).</summary>
		public byte PitchAccumulatorHigh { get; init; }

		/// <summary>Pitch-bend counter low byte (DI+0xB4).</summary>
		public byte PitchBendCounter { get; init; }

		/// <summary>Whether the patch is the 4-operator variant.</summary>
		public bool IsPatch4 { get; init; }

		/// <summary>Patch4 envelope-shaping word (only when 4-op).</summary>
		public ushort Patch4EnvShaping { get; init; }

		/// <summary>Patch4 TL-shaping word (only when 4-op).</summary>
		public ushort Patch4TlShaping { get; init; }

		/// <summary>Patch4 volume-modulation word (only when 4-op).</summary>
		public ushort Patch4VolumeModulation { get; init; }
	}

	private const byte Patch4Marker = 0x04;

	/// <summary>
	/// Decodes the shaping / modulation / pitch state from
	/// <paramref name="patch"/>. The patch must contain at least
	/// <see cref="Patch2Length"/> bytes; if the patch-type byte is
	/// <c>0x04</c> it must contain at least <see cref="Patch4Length"/>
	/// bytes (the 4-op tail at offsets 0x2A..0x4E).
	/// </summary>
	public static DecodedState Decode(byte[] patch) {
		ArgumentNullException.ThrowIfNull(patch);
		if (patch.Length < Patch2Length) {
			throw new ArgumentException(
				$"Patch must be at least {Patch2Length} bytes.",
				nameof(patch));
		}

		byte patchType = patch[0x00];
		bool isPatch4 = patchType == Patch4Marker;
		if (isPatch4 && patch.Length < Patch4Length) {
			throw new ArgumentException(
				$"4-op patch must be at least {Patch4Length} bytes.",
				nameof(patch));
		}

		ushort pitchModeWord = ReadWordLittleEndian(patch, 0x21);
		byte pitchMode = (byte)(pitchModeWord & 0xFF);
		byte pitchTranspose = (byte)(pitchModeWord >> 8);
		ushort envShaping = ComposeShaping(
			patch[0x0A], patch[0x17], patch[0x0F], patch[0x02]);
		ushort tlShaping = ReadWordLittleEndian(patch, 0x1E);
		ushort volumeModulation = ReadWordLittleEndian(patch, 0x26);
		ushort connectionShaping = ComposeConnectionShaping(
			patch[0x04], patch[0x0E], patch[0x20]);
		ushort connectionModulation = (ushort)(patch[0x1B] << 8);
		ushort pitchSeed = ReadWordLittleEndian(patch, 0x23);
		byte pitchAccumulatorHigh = (byte)(pitchSeed >> 8);
		byte pitchBendCounter = (byte)(pitchSeed & 0xFF);

		ushort patch4Env = 0;
		ushort patch4Tl = 0;
		ushort patch4Vol = 0;
		if (isPatch4) {
			patch4Env = ComposeShaping(
				patch[0x32], patch[0x3F], patch[0x37], patch[0x2A]);
			patch4Tl = ReadWordLittleEndian(patch, 0x46);
			patch4Vol = ReadWordLittleEndian(patch, 0x4E);
		}

		return new DecodedState {
			PatchType = patchType,
			PitchMode = pitchMode,
			PitchTranspose = pitchTranspose,
			EnvShaping = envShaping,
			TlShaping = tlShaping,
			VolumeModulation = volumeModulation,
			ConnectionShaping = connectionShaping,
			ConnectionModulation = connectionModulation,
			PitchAccumulatorHigh = pitchAccumulatorHigh,
			PitchBendCounter = pitchBendCounter,
			IsPatch4 = isPatch4,
			Patch4EnvShaping = patch4Env,
			Patch4TlShaping = patch4Tl,
			Patch4VolumeModulation = patch4Vol,
		};
	}

	/// <summary>
	/// Mirrors the oracle's envelope-shaping composition:
	/// <c>AX = Make16(hi=patch[a], lo=patch[b])</c> OR
	/// <c>((Make16(hi=patch[c], lo=patch[d]) AND 0x0303) ROR 2)</c>.
	/// Returned word is <c>(Hi8=patch[a], Lo8=patch[b])</c> OR
	/// <c>ROR2((patch[c]&amp;0x03)|((patch[d]&amp;0x03)&lt;&lt;8))</c>.
	/// </summary>
	private static ushort ComposeShaping(byte hiA, byte loB, byte hiC, byte loD) {
		ushort ax = (ushort)((hiA << 8) | loB);
		ushort bx = (ushort)(((hiC << 8) | loD) & 0x0303);
		bx = RotateRight16(bx, 2);
		return (ushort)(ax | bx);
	}

	/// <summary>
	/// Mirrors the oracle's connection-shaping composition:
	/// <list type="number">
	///   <item>AX = Make16(hi=~patch[0x0E], lo=patch[0x04]);</item>
	///   <item>AX = ROR1(AX);</item>
	///   <item>AX = AX SHL 1;</item>
	///   <item>AX = Make16(hi=patch[0x20], lo=Hi8(AX)).</item>
	/// </list>
	/// </summary>
	private static ushort ComposeConnectionShaping(byte patch04, byte patch0E,
		byte patch20) {
		ushort ax = (ushort)(((byte)~patch0E << 8) | patch04);
		ax = RotateRight16(ax, 1);
		ax = (ushort)(ax << 1);
		byte hi = patch20;
		byte lo = (byte)(ax >> 8);
		return (ushort)((hi << 8) | lo);
	}

	private static ushort ReadWordLittleEndian(byte[] data, int offset) {
		return (ushort)(data[offset] | (data[offset + 1] << 8));
	}

	private static ushort RotateRight16(ushort value, int count) {
		count &= 15;
		return (ushort)((value >> count) | (value << (16 - count)));
	}
}