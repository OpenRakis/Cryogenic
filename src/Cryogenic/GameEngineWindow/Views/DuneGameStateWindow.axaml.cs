namespace Cryogenic.GameEngineWindow.Views;

using Avalonia.Controls;

/// <summary>
/// Window that displays live Dune game engine state from memory.
/// </summary>
/// <remarks>
/// This window provides a real-time view into the game's memory state,
/// organized into tabs for different aspects of the game engine:
/// - Savegame Structure: Core game state values
/// - HNM Video: Video playback state
/// - Display: Graphics and framebuffer information
/// - Input: Mouse and cursor state
/// - Sound: Audio subsystem information
/// - Memory Regions: Documentation of memory layout
/// </remarks>
public partial class DuneGameStateWindow : Window {
    /// <summary>
    /// Initializes a new instance of the <see cref="DuneGameStateWindow"/> class.
    /// </summary>
    public DuneGameStateWindow() {
        InitializeComponent();
    }
}
