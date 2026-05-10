namespace Cryogenic.AdgPlayer.Ui.Tests.Opl;

using Cryogenic.AdgPlayer.Opl;
using Cryogenic.AdgPlayer.Ui.Opl;

using Xunit;

/// <summary>Unit tests for <see cref="OplCaptureBus"/>.</summary>
public sealed class OplCaptureBusTests {
	/// <summary>Every write is forwarded to the inner bus.</summary>
	[Fact]
	public void WriteRegister_ForwardsToInnerBus() {
		// Arrange
		RecordingOplBus inner = new();
		OplCaptureBus capture = new(inner);

		// Act
		capture.WriteRegister(0, 0x40, 0x10);
		capture.WriteRegister(1, 0x05, 0x01);

		// Assert
		Assert.Equal(2, inner.Writes.Count);
		Assert.Equal((0, (byte)0x40, (byte)0x10), (inner.Writes[0].Chip, inner.Writes[0].Register, inner.Writes[0].Value));
		Assert.Equal((1, (byte)0x05, (byte)0x01), (inner.Writes[1].Chip, inner.Writes[1].Register, inner.Writes[1].Value));
		Assert.Equal(2, capture.ObservedCount);
	}

	/// <summary>Subscribers receive every write in order.</summary>
	[Fact]
	public void Subscribe_NotifiesSubscribers() {
		// Arrange
		RecordingOplBus inner = new();
		OplCaptureBus capture = new(inner);
		System.Collections.Generic.List<OplWrite> observed = new();
		void Handler(OplWrite write) {
			observed.Add(write);
		}
		capture.Subscribe(Handler);

		// Act
		capture.WriteRegister(0, 0x20, 0xAA);
		capture.WriteRegister(0, 0x21, 0xBB);

		// Assert
		Assert.Equal(2, observed.Count);
		Assert.Equal(0xAA, observed[0].Value);
		Assert.Equal(0xBB, observed[1].Value);
	}

	/// <summary><c>Unsubscribe</c> stops further notifications without affecting forwarding.</summary>
	[Fact]
	public void Unsubscribe_StopsNotifications() {
		// Arrange
		RecordingOplBus inner = new();
		OplCaptureBus capture = new(inner);
		int notifications = 0;
		void Handler(OplWrite _) {
			notifications++;
		}
		capture.Subscribe(Handler);
		capture.WriteRegister(0, 0x40, 0x01);

		// Act
		capture.Unsubscribe(Handler);
		capture.WriteRegister(0, 0x41, 0x02);

		// Assert
		Assert.Equal(1, notifications);
		Assert.Equal(2, inner.Writes.Count);
	}
}