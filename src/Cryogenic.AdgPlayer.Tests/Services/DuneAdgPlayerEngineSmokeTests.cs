namespace Cryogenic.AdgPlayer.Tests.Services;

using Cryogenic.AdgPlayer.Driver;
using Cryogenic.AdgPlayer.Opl;
using Cryogenic.AdgPlayer.Services;

using System;
using System.IO;

using Xunit;

/// <summary>
/// Phase E4 — end-to-end smoke tests against a real DUNE.DAT-decoded
/// AdLib Gold song. Validates that <see cref="DuneAdgPlayerEngine"/>
/// can ingest a real HSQ-compressed image, advance its scheduler
/// over many ticks without throwing, and surface state mutations
/// through the driver-state aggregate. These tests are intentionally
/// loose: they assert that the engine consumed the song (event
/// dispatch occurred, channel pointers advanced) rather than any
/// particular OPL byte stream, since the routing-table extraction
/// from the DNADG driver image is not part of the smoke path.
/// </summary>
public sealed class DuneAdgPlayerEngineSmokeTests {
	/// <summary>
	/// Workspace-relative path of the smallest AdLib-Gold song
	/// bundled with the repository.
	/// </summary>
	private const string ArrakisAgdRelativePath =
		"doc/DUNECDVF/C/DUNECD/DUNE.DAT_/ARRAKIS_AGD.HSQ";

	[Fact]
	public void Load_ArrakisAgd_PopulatesHeaderAndPointers() {
		// Arrange
		string path = ResolveAssetPath(ArrakisAgdRelativePath);
		Assert.True(File.Exists(path), $"Missing test asset: {path}");
		byte[] bytes = File.ReadAllBytes(path);
		DuneAdgPlayerEngine engine = new();

		// Act
		engine.Load(bytes);

		// Assert
		Assert.True(engine.HasSongLoaded);
		Assert.NotNull(engine.SongImage);
		Assert.True(engine.SongImage!.WasCompressed,
			"ARRAKIS_AGD.HSQ must be detected as HSQ-compressed.");
		Assert.NotNull(engine.SongHeader);
		Assert.NotNull(engine.ChannelPointers);
		// At least one of the nine song channels must be active
		// (non-zero event-pointer offset).
		int activeChannels = 0;
		for (int i = 0; i < AdgDriverState.ChannelCount; i++) {
			if (engine.State.EventPointers.Get(i) != 0) {
				activeChannels++;
			}
		}
		Assert.True(activeChannels > 0,
			"Expected at least one active channel after Load.");
	}

	[Fact]
	public void Tick_ArrakisAgd_OneThousandTicks_DispatchesEventsWithoutThrowing() {
		// Arrange
		string path = ResolveAssetPath(ArrakisAgdRelativePath);
		byte[] bytes = File.ReadAllBytes(path);
		DuneAdgPlayerEngine engine = new();
		engine.Load(bytes);
		int initialActive = CountActiveChannels(engine);

		// Act — drive 1000 ticks (~5.5 seconds of music at 181 Hz)
		// and observe state mutation. We do not bind a routing table
		// so OPL emit is gated off; the engine still runs all
		// per-channel state mutations through the dispatcher.
		long ticksRun = 0;
		ulong waitMutationSum = 0;
		for (int t = 0; t < 1000; t++) {
			engine.Tick();
			ticksRun++;
			// Sample the wait counter sum as a proxy for state
			// activity (cheap and avoids depending on any specific
			// opcode handler).
			for (int i = 0; i < AdgDriverState.ChannelCount; i++) {
				waitMutationSum += engine.State.WaitCounters.Get(i);
			}
		}

		// Assert
		Assert.Equal(1000, ticksRun);
		Assert.Equal(1000L, engine.TickCount);
		Assert.True(waitMutationSum > 0,
			"Wait counters never moved — engine did not dispatch any event.");
		Assert.True(initialActive > 0);
	}

	[Fact]
	public void Tick_ArrakisAgd_WithRecordingBus_AndAuxBound_ProducesNoEmitWithoutRoutingTable() {
		// Arrange — wire a bounded recording bus to confirm that
		// without a routing table no OPL writes are emitted (the
		// gate documented on each handler).
		string path = ResolveAssetPath(ArrakisAgdRelativePath);
		byte[] bytes = File.ReadAllBytes(path);
		DuneAdgPlayerEngine engine = new();
		RecordingOplBus bus = new(capacity: 4096);
		engine.SetOplBus(bus);
		engine.Load(bytes);

		// Act
		for (int t = 0; t < 250; t++) {
			engine.Tick();
		}

		// Assert
		Assert.Empty(bus.Writes);
		Assert.Equal(0, bus.DroppedCount);
	}

	private static int CountActiveChannels(DuneAdgPlayerEngine engine) {
		int active = 0;
		for (int i = 0; i < AdgDriverState.ChannelCount; i++) {
			if (engine.State.EventPointers.Get(i) != 0) {
				active++;
			}
		}
		return active;
	}

	/// <summary>
	/// Walks up from <see cref="AppContext.BaseDirectory"/> until a
	/// directory containing <c>Cryogenic.sln</c> is found, then
	/// resolves <paramref name="relativePath"/> beneath it. Falls
	/// back to the original relative path so a clear assertion
	/// failure (rather than a path-not-found) surfaces when the
	/// asset is missing.
	/// </summary>
	private static string ResolveAssetPath(string relativePath) {
		DirectoryInfo? cursor = new(AppContext.BaseDirectory);
		while (cursor is not null) {
			string slnCandidate = Path.Combine(cursor.FullName, "Cryogenic.sln");
			if (File.Exists(slnCandidate)) {
				// Tests live under src/Cryogenic.AdgPlayer.Tests so the
				// solution sits at src/Cryogenic.sln; the bundled assets
				// live one level higher under doc/.
				string repoRoot = cursor.Parent?.FullName ?? cursor.FullName;
				string candidate = Path.Combine(repoRoot, relativePath.Replace('/', Path.DirectorySeparatorChar));
				if (File.Exists(candidate)) {
					return candidate;
				}
			}
			cursor = cursor.Parent;
		}
		return relativePath;
	}
}
