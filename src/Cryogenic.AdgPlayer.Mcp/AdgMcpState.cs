namespace Cryogenic.AdgPlayer.Mcp;

using Cryogenic.AdgPlayer.Services;

using Serilog;

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

/// <summary>
/// Singleton state holder for the MCP server session.
/// Owns the <see cref="DuneAdgPlayerEngine"/> — which uses the full Spice86
/// <see cref="OplSynthesizer"/> including the AdLib Gold stereo/surround processor —
/// and maintains circular log buffers for OPL writes and channel events so that MCP
/// tools can inspect the playback trace without locking the engine thread.
/// </summary>
public sealed class AdgMcpState : IDisposable {
	private static readonly ILogger Logger = Log.ForContext<AdgMcpState>();

	private const int MaxLogEntries = 512;

	private readonly ConcurrentQueue<OplWriteRecord> _oplLog = new();
	private readonly ConcurrentQueue<ChannelEventRecord> _channelLog = new();

	/// <summary>The live engine instance. Backed by the full AdLib Gold pipeline.</summary>
	public DuneAdgPlayerEngine Engine { get; }

	/// <summary>Path of the most recently loaded song file, or empty when none has been loaded.</summary>
	public string LoadedPath { get; private set; } = string.Empty;

	/// <summary>
	/// Creates the engine with the full Spice86 OPL/AdLib Gold pipeline and wires event
	/// subscriptions. The <see cref="OplSynthesizer"/> starts the SoftwareMixer audio
	/// pipeline; on headless systems Spice86's cross-platform audio engine uses a null
	/// output sink so tick processing and OPL write capture still work correctly.
	/// </summary>
	public AdgMcpState() {
		Engine = new DuneAdgPlayerEngine();
		Engine.OplRegisterWritten += OnOplWrite;
		Engine.ChannelEventDispatched += OnChannelEvent;
		Engine.SongFinished += () => Logger.Information("Song finished");
		Logger.Information("ADG MCP state ready — full AdLib Gold pipeline active");
	}

	/// <summary>
	/// Loads raw ADG/HSQ bytes into the engine and records the file path.
	/// Clears the OPL and channel event logs so the next inspection session starts clean.
	/// </summary>
	public void LoadSong(string filePath, byte[] rawData) {
		Engine.LoadSong(rawData);
		LoadedPath = filePath;
		_oplLog.Clear();
		_channelLog.Clear();
		Logger.Information("Song loaded: {Path} ({Bytes} bytes)", filePath, rawData.Length);
	}

	/// <summary>Returns up to <paramref name="maxEntries"/> recent OPL register writes, oldest first.</summary>
	public List<OplWriteRecord> GetOplLog(int maxEntries) {
		OplWriteRecord[] snapshot = _oplLog.ToArray();
		int start = Math.Max(0, snapshot.Length - maxEntries);
		List<OplWriteRecord> result = new List<OplWriteRecord>(snapshot.Length - start);
		for (int i = start; i < snapshot.Length; i++) {
			result.Add(snapshot[i]);
		}
		return result;
	}

	/// <summary>Returns up to <paramref name="maxEntries"/> recent channel events, oldest first.</summary>
	public List<ChannelEventRecord> GetChannelLog(int maxEntries) {
		ChannelEventRecord[] snapshot = _channelLog.ToArray();
		int start = Math.Max(0, snapshot.Length - maxEntries);
		List<ChannelEventRecord> result = new List<ChannelEventRecord>(snapshot.Length - start);
		for (int i = start; i < snapshot.Length; i++) {
			result.Add(snapshot[i]);
		}
		return result;
	}

	/// <inheritdoc />
	public void Dispose() {
		Engine.OplRegisterWritten -= OnOplWrite;
		Engine.ChannelEventDispatched -= OnChannelEvent;
		Engine.Dispose();
	}

	private void OnOplWrite(ushort register, byte value, long tick) {
		_oplLog.Enqueue(new OplWriteRecord(register, value, tick));
		while (_oplLog.Count > MaxLogEntries) {
			_oplLog.TryDequeue(out OplWriteRecord _);
		}
	}

	private void OnChannelEvent(int channel, string eventType, string detail, long tick) {
		_channelLog.Enqueue(new ChannelEventRecord(channel, eventType, detail, tick));
		while (_channelLog.Count > MaxLogEntries) {
			_channelLog.TryDequeue(out ChannelEventRecord _);
		}
	}
}

/// <summary>A single captured OPL register write.</summary>
public readonly record struct OplWriteRecord(ushort Register, byte Value, long Tick);

/// <summary>A single captured channel event from the tick dispatcher.</summary>
public readonly record struct ChannelEventRecord(int Channel, string EventType, string Detail, long Tick);
