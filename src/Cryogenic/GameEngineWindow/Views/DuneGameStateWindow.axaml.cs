namespace Cryogenic.GameEngineWindow.Views;

using Avalonia.Controls;

/// <summary>
/// Window that displays live Dune game engine state from memory.
/// </summary>
/// <remarks>
/// This window provides a real-time view into the game's memory state,
/// organized into tabs for different aspects of the game engine:
/// - Player Stats: Core player-related values (spice, charisma, game stage)
/// - NPCs: Non-player character data (sprite, room, dialogue state)
/// - Followers: Current party members and position
/// - Locations: All 70 locations with status, spice, water, equipment
/// - Troops: All 68 troops with occupation, skills, equipment
/// - Smugglers: All 6 smugglers with inventory and prices
/// - HNM Video: Video playback state
/// - Display: Graphics and framebuffer information
/// - Input: Mouse and cursor state
/// - Sound: Audio subsystem information
/// </remarks>
public partial class DuneGameStateWindow : Window {
    /// <summary>
    /// Initializes a new instance of the <see cref="DuneGameStateWindow"/> class.
    /// </summary>
    public DuneGameStateWindow() {
        InitializeComponent();
    }
}
