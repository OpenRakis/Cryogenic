namespace Cryogenic.GameEngineWindow.ViewModels;

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;

using Cryogenic.GameEngineWindow.Models;

using Spice86.Core.Emulator.CPU.Registers;
using Spice86.Core.Emulator.Memory.ReaderWriter;

/// <summary>
/// ViewModel for the Dune Game Engine Window that displays live game state from memory.
/// </summary>
/// <remarks>
/// This ViewModel refreshes the game state periodically to show live memory values
/// from the running emulator. It supports multiple tabs for different aspects of
/// the game engine state.
/// </remarks>
public class DuneGameStateViewModel : INotifyPropertyChanged, IDisposable {
    private readonly DuneGameState _gameState;
    private readonly Timer _refreshTimer;
    private bool _disposed;

    /// <summary>
    /// Occurs when a property value changes.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Initializes a new instance of the <see cref="DuneGameStateViewModel"/> class.
    /// </summary>
    /// <param name="memory">The memory reader/writer interface for accessing emulated memory.</param>
    /// <param name="segmentRegisters">The CPU segment registers.</param>
    public DuneGameStateViewModel(IByteReaderWriter memory, SegmentRegisters segmentRegisters) {
        _gameState = new DuneGameState(memory, segmentRegisters);
        
        // Set up a timer to refresh the view periodically
        _refreshTimer = new Timer(100); // Refresh every 100ms
        _refreshTimer.Elapsed += OnRefreshTimerElapsed;
        _refreshTimer.AutoReset = true;
        _refreshTimer.Start();
    }

    #region Core Game State Properties

    /// <summary>
    /// Gets the game elapsed time.
    /// </summary>
    public ushort GameElapsedTime => _gameState.GameElapsedTime;

    /// <summary>
    /// Gets the formatted game elapsed time.
    /// </summary>
    public string GameElapsedTimeHex => $"0x{GameElapsedTime:X4}";

    /// <summary>
    /// Gets the player's charisma level.
    /// </summary>
    public byte Charisma => _gameState.Charisma;

    /// <summary>
    /// Gets the formatted charisma value.
    /// </summary>
    public string CharismaDisplay => $"{Charisma} (0x{Charisma:X2})";

    /// <summary>
    /// Gets the current game stage.
    /// </summary>
    public byte GameStage => _gameState.GameStage;

    /// <summary>
    /// Gets the game stage description.
    /// </summary>
    public string GameStageDisplay => _gameState.GetGameStageDescription();

    /// <summary>
    /// Gets the total spice amount.
    /// </summary>
    public ushort Spice => _gameState.Spice;

    /// <summary>
    /// Gets the formatted spice amount.
    /// </summary>
    public string SpiceDisplay => _gameState.GetFormattedSpice();

    /// <summary>
    /// Gets the raw date/time value.
    /// </summary>
    public ushort DateTimeRaw => _gameState.DateTimeRaw;

    /// <summary>
    /// Gets the formatted date/time.
    /// </summary>
    public string DateTimeDisplay => _gameState.GetFormattedDateTime();

    /// <summary>
    /// Gets the contact distance.
    /// </summary>
    public byte ContactDistance => _gameState.ContactDistance;

    /// <summary>
    /// Gets the formatted contact distance.
    /// </summary>
    public string ContactDistanceDisplay => $"{ContactDistance} (0x{ContactDistance:X2})";

    #endregion

    #region HNM Video State Properties

    /// <summary>
    /// Gets the HNM finished flag.
    /// </summary>
    public byte HnmFinishedFlag => _gameState.HnmFinishedFlag;

    /// <summary>
    /// Gets the HNM frame counter.
    /// </summary>
    public ushort HnmFrameCounter => _gameState.HnmFrameCounter;

    /// <summary>
    /// Gets the HNM counter 2.
    /// </summary>
    public ushort HnmCounter2 => _gameState.HnmCounter2;

    /// <summary>
    /// Gets the current HNM resource flag.
    /// </summary>
    public byte CurrentHnmResourceFlag => _gameState.CurrentHnmResourceFlag;

    /// <summary>
    /// Gets the HNM video ID.
    /// </summary>
    public ushort HnmVideoId => _gameState.HnmVideoId;

    /// <summary>
    /// Gets the HNM active video ID.
    /// </summary>
    public ushort HnmActiveVideoId => _gameState.HnmActiveVideoId;

    /// <summary>
    /// Gets the HNM file offset.
    /// </summary>
    public uint HnmFileOffset => _gameState.HnmFileOffset;

    /// <summary>
    /// Gets the HNM file remaining bytes.
    /// </summary>
    public uint HnmFileRemain => _gameState.HnmFileRemain;

    /// <summary>
    /// Gets the HNM video ID display string.
    /// </summary>
    public string HnmVideoIdDisplay => $"0x{HnmVideoId:X4}";

    /// <summary>
    /// Gets the HNM file offset display string.
    /// </summary>
    public string HnmFileOffsetDisplay => $"0x{HnmFileOffset:X8}";

    /// <summary>
    /// Gets the HNM file remaining display string.
    /// </summary>
    public string HnmFileRemainDisplay => $"0x{HnmFileRemain:X8} ({HnmFileRemain} bytes)";

    #endregion

    #region Display and Graphics Properties

    /// <summary>
    /// Gets the front framebuffer segment.
    /// </summary>
    public ushort FramebufferFront => _gameState.FramebufferFront;

    /// <summary>
    /// Gets the screen buffer segment.
    /// </summary>
    public ushort ScreenBuffer => _gameState.ScreenBuffer;

    /// <summary>
    /// Gets the active framebuffer segment.
    /// </summary>
    public ushort FramebufferActive => _gameState.FramebufferActive;

    /// <summary>
    /// Gets the back framebuffer segment.
    /// </summary>
    public ushort FramebufferBack => _gameState.FramebufferBack;

    /// <summary>
    /// Gets the framebuffer front display string.
    /// </summary>
    public string FramebufferFrontDisplay => $"0x{FramebufferFront:X4}";

    /// <summary>
    /// Gets the screen buffer display string.
    /// </summary>
    public string ScreenBufferDisplay => $"0x{ScreenBuffer:X4}";

    /// <summary>
    /// Gets the framebuffer active display string.
    /// </summary>
    public string FramebufferActiveDisplay => $"0x{FramebufferActive:X4}";

    /// <summary>
    /// Gets the framebuffer back display string.
    /// </summary>
    public string FramebufferBackDisplay => $"0x{FramebufferBack:X4}";

    #endregion

    #region Mouse and Cursor Properties

    /// <summary>
    /// Gets the mouse Y position.
    /// </summary>
    public ushort MousePosY => _gameState.MousePosY;

    /// <summary>
    /// Gets the mouse X position.
    /// </summary>
    public ushort MousePosX => _gameState.MousePosX;

    /// <summary>
    /// Gets the mouse position display string.
    /// </summary>
    public string MousePositionDisplay => $"({MousePosX}, {MousePosY})";

    /// <summary>
    /// Gets the mouse draw Y position.
    /// </summary>
    public ushort MouseDrawPosY => _gameState.MouseDrawPosY;

    /// <summary>
    /// Gets the mouse draw X position.
    /// </summary>
    public ushort MouseDrawPosX => _gameState.MouseDrawPosX;

    /// <summary>
    /// Gets the mouse draw position display string.
    /// </summary>
    public string MouseDrawPositionDisplay => $"({MouseDrawPosX}, {MouseDrawPosY})";

    /// <summary>
    /// Gets the cursor hide counter.
    /// </summary>
    public byte CursorHideCounter => _gameState.CursorHideCounter;

    /// <summary>
    /// Gets the map cursor type.
    /// </summary>
    public ushort MapCursorType => _gameState.MapCursorType;

    /// <summary>
    /// Gets the map cursor type display string.
    /// </summary>
    public string MapCursorTypeDisplay => $"0x{MapCursorType:X4}";

    #endregion

    #region Sound Properties

    /// <summary>
    /// Gets whether sound is present.
    /// </summary>
    public byte IsSoundPresent => _gameState.IsSoundPresent;

    /// <summary>
    /// Gets the sound present display string.
    /// </summary>
    public string IsSoundPresentDisplay => IsSoundPresent != 0 ? "Yes" : "No";

    /// <summary>
    /// Gets the MIDI func5 return value.
    /// </summary>
    public ushort MidiFunc5ReturnBx => _gameState.MidiFunc5ReturnBx;

    /// <summary>
    /// Gets the MIDI func5 return display string.
    /// </summary>
    public string MidiFunc5ReturnBxDisplay => $"0x{MidiFunc5ReturnBx:X4}";

    #endregion

    #region Effects Properties

    /// <summary>
    /// Gets the transition bitmask.
    /// </summary>
    public byte TransitionBitmask => _gameState.TransitionBitmask;

    /// <summary>
    /// Gets the transition bitmask display string.
    /// </summary>
    public string TransitionBitmaskDisplay => $"0x{TransitionBitmask:X2} (0b{Convert.ToString(TransitionBitmask, 2).PadLeft(8, '0')})";

    #endregion

    #region Refresh Timer

    private void OnRefreshTimerElapsed(object? sender, ElapsedEventArgs e) {
        // Notify that all properties have changed to refresh the UI
        OnPropertyChanged(string.Empty);
    }

    /// <summary>
    /// Raises the PropertyChanged event.
    /// </summary>
    /// <param name="propertyName">Name of the property that changed.</param>
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion

    #region IDisposable

    /// <summary>
    /// Disposes of the ViewModel and stops the refresh timer.
    /// </summary>
    public void Dispose() {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Disposes managed resources.
    /// </summary>
    /// <param name="disposing">True if disposing managed resources.</param>
    protected virtual void Dispose(bool disposing) {
        if (!_disposed) {
            if (disposing) {
                _refreshTimer.Stop();
                _refreshTimer.Dispose();
            }
            _disposed = true;
        }
    }

    #endregion
}
