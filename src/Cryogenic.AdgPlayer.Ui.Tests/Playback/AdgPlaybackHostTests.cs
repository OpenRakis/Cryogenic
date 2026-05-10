namespace Cryogenic.AdgPlayer.Ui.Tests.Playback;

using System;

using Cryogenic.AdgPlayer.Opl;
using Cryogenic.AdgPlayer.Ui.Playback;

using Xunit;

/// <summary>Tests for <see cref="AdgPlaybackHost"/>.</summary>
public sealed class AdgPlaybackHostTests {
    /// <summary>Constructor rejects null arguments.</summary>
    [Fact]
    public void Constructor_RejectsNullArguments() {
        // Arrange
        RecordingOplBus bus = new();

        // Act / Assert
        Assert.Throws<ArgumentNullException>(() => new AdgPlaybackHost(null!, _ => { }));
        Assert.Throws<ArgumentNullException>(() => new AdgPlaybackHost(bus, null!));
    }

    /// <summary>A new host is not running and has zero ticks.</summary>
    [Fact]
    public void NewHost_IsNotRunning() {
        // Arrange
        using AdgPlaybackHost host = new(new RecordingOplBus(), _ => { });

        // Act / Assert
        Assert.False(host.IsRunning);
        Assert.Equal(0, host.TickCount);
        Assert.Equal(1000.0 / 181.0, host.TickIntervalMilliseconds, 5);
    }

    /// <summary>Manual <see cref="AdgPlaybackHost.Tick"/> increments the counter and forwards the bus.</summary>
    [Fact]
    public void Tick_InvokesCallbackWithBoundBus() {
        // Arrange
        RecordingOplBus bus = new();
        IOplBus? observed = null;
        using AdgPlaybackHost host = new(bus, b => {
            observed = b;
            b.WriteRegister(0, 0x20, 0x01);
        });

        // Act
        host.Tick();
        host.Tick();

        // Assert
        Assert.Same(bus, observed);
        Assert.Equal(2, host.TickCount);
        Assert.Equal(2, bus.Writes.Count);
    }

    /// <summary>Start sets <see cref="AdgPlaybackHost.IsRunning"/> and Stop clears it.</summary>
    [Fact]
    public void StartStop_TogglesIsRunning() {
        // Arrange
        using AdgPlaybackHost host = new(new RecordingOplBus(), _ => { });

        // Act
        host.Start();
        bool startedRunning = host.IsRunning;
        host.Stop();

        // Assert
        Assert.True(startedRunning);
        Assert.False(host.IsRunning);
    }

    /// <summary>Calling Start twice throws.</summary>
    [Fact]
    public void Start_WhenAlreadyRunning_Throws() {
        // Arrange
        using AdgPlaybackHost host = new(new RecordingOplBus(), _ => { });
        host.Start();

        // Act / Assert
        Assert.Throws<InvalidOperationException>(host.Start);
        host.Stop();
    }

    /// <summary>Stop is idempotent.</summary>
    [Fact]
    public void Stop_WhenNotRunning_DoesNotThrow() {
        // Arrange
        using AdgPlaybackHost host = new(new RecordingOplBus(), _ => { });

        // Act / Assert (does not throw)
        host.Stop();
    }

    /// <summary>Dispose stops the host and prevents further ticks.</summary>
    [Fact]
    public void Dispose_StopsHostAndBlocksFurtherTicks() {
        // Arrange
        AdgPlaybackHost host = new(new RecordingOplBus(), _ => { });
        host.Start();

        // Act
        host.Dispose();

        // Assert
        Assert.False(host.IsRunning);
        Assert.Throws<ObjectDisposedException>(host.Tick);
    }
}
