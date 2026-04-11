namespace Cryogenic.Mt32DriverDebug.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;

/// <summary>
/// Represents one entry in the DNMID driver export/jump table.
/// </summary>
public sealed partial class ExportEntryViewModel : ObservableObject {
	/// <summary>Export index (0..6).</summary>
	public int Index { get; }

	/// <summary>Human-readable function name.</summary>
	public string Name { get; }

	/// <summary>Opcode byte (should be 0xE9 for JMP near).</summary>
	[ObservableProperty]
	private string _opcode = "--";

	/// <summary>JMP target offset in hex.</summary>
	[ObservableProperty]
	private string _target = "----";

	/// <summary>CS:offset string for the resolved address.</summary>
	[ObservableProperty]
	private string _resolvedAddress = "----:----";

	/// <summary>
	/// Initializes an export entry row.
	/// </summary>
	/// <param name="index">Export index.</param>
	/// <param name="name">Human-readable name for this entry.</param>
	public ExportEntryViewModel(int index, string name) {
		Index = index;
		Name = name;
	}
}