namespace Cryogenic.AdgPlayer.Driver;

/// <summary>
/// Pure port of the connection-modulation tail of
/// <c>AdgVolumeModulation_0B2E</c> (oracle lines 1793–1814 in
/// <c>src/Cryogenic/Overrides/AdgDriverCode.cs</c>). Given a
/// channel's connection-modulation slot (rate in low byte,
/// current connection byte in high byte) and the event's
/// direct/inverse velocity pair, computes the next connection
/// register value to publish via <c>0xC0</c> +channelRoute.
/// </summary>
public static class AdgConnectionModulationComputer {
	/// <summary>
	/// Result of a connection-modulation computation. When
	/// <see cref="Active"/> is <c>false</c> the caller must skip
	/// both the slot update and the OPL emit (matches the
	/// <c>JZ</c> early-exit in the oracle when the rate byte is
	/// zero).
	/// </summary>
	public readonly struct Result {
		/// <summary>True when the routine should publish a new connection byte.</summary>
		public bool Active { get; }
		/// <summary>The new connection byte (high byte of the slot and OPL value).</summary>
		public byte NewConnection { get; }

		/// <summary>Constructs a result.</summary>
		public Result(bool active, byte newConnection) {
			Active = active;
			NewConnection = newConnection;
		}
	}

	/// <summary>
	/// Computes the connection-modulation result for a single
	/// event. <paramref name="rate"/> is the low byte of the
	/// connection-modulation slot; <paramref name="current"/> is
	/// the high byte (the current connection register value).
	/// </summary>
	public static Result Compute(byte rate, byte current,
		byte directVelocity, byte inverseVelocity) {
		if (rate == 0) {
			return new Result(false, current);
		}
		byte shapingMode = rate;
		byte scale = directVelocity;
		if ((shapingMode & 0x80) != 0) {
			shapingMode = (byte)(0 - shapingMode);
			scale = inverseVelocity;
		}
		shapingMode = (byte)(0 - (byte)(shapingMode - 0x06));
		scale = (byte)(scale >> shapingMode);
		scale = (byte)(scale & 0xFE);
		scale = (byte)(scale + current);
		if (scale > 0x0F) {
			scale = (byte)((scale & 0x0F) | 0x0E);
		}
		scale = (byte)((scale & 0x0F) | (current & 0x30));
		return new Result(true, scale);
	}
}