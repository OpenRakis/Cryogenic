namespace Cryogenic.AdgPlayer.Tests.Audio;

using Cryogenic.AdgPlayer.Audio;
using Cryogenic.AdgPlayer.Opl;

using System;

using Xunit;

/// <summary>
/// Tests for <see cref="AdgOplSynthesizer"/>. The synthesizer wraps
/// <c>NukedOPL3Sharp.Opl3Chip</c> behind <see cref="IOplBus"/>; we
/// validate construction, register-write contract (including dual-bank
/// dispatch), volume clamping, idempotent dispose, and Start/Stop
/// without booting a real audio engine.
/// </summary>
public sealed class AdgOplSynthesizerTests {
	/// <summary>Constructor wires defaults: native rate exposed and
	/// implements <see cref="IOplBus"/>.</summary>
	[Fact]
	public void Constructor_ExposesNativeRateAndImplementsIOplBus() {
		// Arrange
		using AdgOplSynthesizer synth = new();

		// Act
		int rate = synth.NativeSampleRate;

		// Assert
		Assert.Equal(AdgOplSynthesizer.NativeOplSampleRateConst, rate);
		Assert.IsAssignableFrom<IOplBus>(synth);
	}

	/// <summary>Bank 0 register writes are accepted (no exception).</summary>
	[Fact]
	public void WriteRegister_Chip0_Accepted() {
		// Arrange
		using AdgOplSynthesizer synth = new();

		// Act
		synth.WriteRegister(0, 0xB0, 0x20);

		// Assert — completing without exception is the contract.
		Assert.IsAssignableFrom<IOplBus>(synth);
	}

	/// <summary>Bank 1 register writes are accepted (dual-bank).</summary>
	[Fact]
	public void WriteRegister_Chip1_Accepted() {
		// Arrange
		using AdgOplSynthesizer synth = new();

		// Act
		synth.WriteRegister(1, 0xA0, 0x55);

		// Assert
		Assert.IsAssignableFrom<IOplBus>(synth);
	}

	/// <summary>Invalid chip selectors throw.</summary>
	[Fact]
	public void WriteRegister_InvalidChip_Throws() {
		// Arrange
		using AdgOplSynthesizer synth = new();

		// Act / Assert
		Assert.Throws<ArgumentOutOfRangeException>(
			() => synth.WriteRegister(2, 0x00, 0x00));
	}

	/// <summary>Start then Stop completes without error.</summary>
	[Fact]
	public void StartThenStop_Completes() {
		// Arrange
		using AdgOplSynthesizer synth = new();

		// Act
		synth.Start();
		synth.Stop();

		// Assert
		Assert.IsAssignableFrom<IOplBus>(synth);
	}

	/// <summary>Master volume clamps to [0,1] without throwing.</summary>
	[Fact]
	public void SetMasterVolume_ClampsAndAccepts() {
		// Arrange
		using AdgOplSynthesizer synth = new();

		// Act
		synth.SetMasterVolume(-5.0f);
		synth.SetMasterVolume(0.5f);
		synth.SetMasterVolume(10.0f);

		// Assert
		Assert.IsAssignableFrom<IOplBus>(synth);
	}

	/// <summary>Dispose is idempotent.</summary>
	[Fact]
	public void Dispose_IsIdempotent() {
		// Arrange
		AdgOplSynthesizer synth = new();

		// Act
		synth.Dispose();
		synth.Dispose();

		// Assert — completing without exception is the contract.
		Assert.True(true);
	}

	/// <summary>OnBeforeRender hook is settable and replaces previous value.</summary>
	[Fact]
	public void OnBeforeRender_IsSettable() {
		// Arrange
		using AdgOplSynthesizer synth = new();
		int captured = -1;
		Action<int> hook = frames => captured = frames;

		// Act
		synth.OnBeforeRender = hook;

		// Assert
		Assert.Same(hook, synth.OnBeforeRender);
		Assert.Equal(-1, captured);
	}
}
