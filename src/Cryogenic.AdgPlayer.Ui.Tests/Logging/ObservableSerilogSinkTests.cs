namespace Cryogenic.AdgPlayer.Ui.Tests.Logging;

using Cryogenic.AdgPlayer.Ui.Logging;

using Serilog.Events;
using Serilog.Parsing;

using System;

using Xunit;

/// <summary>Unit tests for <see cref="ObservableSerilogSink"/>.</summary>
public sealed class ObservableSerilogSinkTests {
	/// <summary>Each emitted event is rendered and forwarded to subscribers.</summary>
	[Fact]
	public void Emit_NotifiesSubscribers() {
		// Arrange
		ObservableSerilogSink sink = new();
		string captured = "";
		void Handler(string message) {
			captured = message;
		}
		sink.Subscribe(Handler);

		// Act
		sink.Emit(MakeEvent("hello world", LogEventLevel.Information));

		// Assert
		Assert.Contains("hello world", captured);
		Assert.Contains("INF", captured);
	}

	/// <summary><c>DrainAll</c> returns every buffered entry.</summary>
	[Fact]
	public void DrainAll_ReturnsBufferedEntries() {
		// Arrange
		ObservableSerilogSink sink = new();
		sink.Emit(MakeEvent("alpha", LogEventLevel.Information));
		sink.Emit(MakeEvent("beta", LogEventLevel.Warning));

		// Act
		string[] buffered = sink.DrainAll();

		// Assert
		Assert.Equal(2, buffered.Length);
		Assert.Contains("alpha", buffered[0]);
		Assert.Contains("beta", buffered[1]);
	}

	/// <summary><c>Unsubscribe</c> stops further notifications.</summary>
	[Fact]
	public void Unsubscribe_StopsNotifications() {
		// Arrange
		ObservableSerilogSink sink = new();
		int notifications = 0;
		void Handler(string _) {
			notifications++;
		}
		sink.Subscribe(Handler);
		sink.Emit(MakeEvent("first", LogEventLevel.Information));

		// Act
		sink.Unsubscribe(Handler);
		sink.Emit(MakeEvent("second", LogEventLevel.Information));

		// Assert
		Assert.Equal(1, notifications);
	}

	private static LogEvent MakeEvent(string message, LogEventLevel level) {
		MessageTemplate template = new MessageTemplateParser().Parse(message);
		return new LogEvent(DateTimeOffset.Now, level, exception: null, template, properties: Array.Empty<LogEventProperty>());
	}
}