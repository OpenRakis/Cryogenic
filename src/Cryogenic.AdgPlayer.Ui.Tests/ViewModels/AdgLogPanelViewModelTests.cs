namespace Cryogenic.AdgPlayer.Ui.Tests.ViewModels;

using Cryogenic.AdgPlayer.Ui.Logging;
using Cryogenic.AdgPlayer.Ui.ViewModels;

using Serilog.Events;
using Serilog.Parsing;

using System;

using Xunit;

/// <summary>Unit tests for <see cref="AdgLogPanelViewModel"/>.</summary>
public sealed class AdgLogPanelViewModelTests {
	/// <summary>Logs already buffered in the sink appear immediately.</summary>
	[Fact]
	public void Constructor_DrainsExistingEntries() {
		// Arrange
		ObservableSerilogSink sink = new();
		sink.Emit(MakeEvent("startup-log"));
		AdgLogPanelViewModel viewModel = new(sink, RunInline);

		// Act
		// Assert
		Assert.Single(viewModel.Logs);
		Assert.Contains("startup-log", viewModel.Logs[0].Message);
	}

	/// <summary>New emissions arrive via the dispatcher and append rows.</summary>
	[Fact]
	public void Emit_AfterConstruction_AppendsRow() {
		// Arrange
		ObservableSerilogSink sink = new();
		AdgLogPanelViewModel viewModel = new(sink, RunInline);

		// Act
		sink.Emit(MakeEvent("late-log"));

		// Assert
		Assert.Single(viewModel.Logs);
		Assert.Contains("late-log", viewModel.Logs[0].Message);
	}

	/// <summary>Once <see cref="AdgLogPanelViewModel.MaxDisplayedEntries"/> is exceeded, oldest rows drop.</summary>
	[Fact]
	public void Emit_BeyondCap_EvictsOldest() {
		// Arrange
		ObservableSerilogSink sink = new();
		AdgLogPanelViewModel viewModel = new(sink, RunInline);

		// Act
		for (int i = 0; i < AdgLogPanelViewModel.MaxDisplayedEntries + 5; i++) {
			sink.Emit(MakeEvent("msg-" + i));
		}

		// Assert
		Assert.Equal(AdgLogPanelViewModel.MaxDisplayedEntries, viewModel.Logs.Count);
		Assert.Contains("msg-5", viewModel.Logs[0].Message);
	}

	/// <summary>Disposing detaches from the sink so further emissions don't bind dead VM.</summary>
	[Fact]
	public void Dispose_StopsListening() {
		// Arrange
		ObservableSerilogSink sink = new();
		AdgLogPanelViewModel viewModel = new(sink, RunInline);

		// Act
		viewModel.Dispose();
		sink.Emit(MakeEvent("post-dispose"));

		// Assert
		Assert.Empty(viewModel.Logs);
	}

	private static void RunInline(Action action) {
		action();
	}

	private static LogEvent MakeEvent(string message) {
		MessageTemplate template = new MessageTemplateParser().Parse(message);
		return new LogEvent(DateTimeOffset.Now, LogEventLevel.Information, exception: null, template, properties: Array.Empty<LogEventProperty>());
	}
}