namespace Cryogenic.GameEngineWindow.ViewModels;

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;

using Cryogenic.GameEngineWindow.Models;

using Spice86.Core.Emulator.CPU.Registers;
using Spice86.Core.Emulator.Memory.ReaderWriter;

public class DuneGameStateViewModel : INotifyPropertyChanged, IDisposable {
    private readonly DuneGameState _gameState;
    private readonly Timer _refreshTimer;
    private bool _disposed;

    public event PropertyChangedEventHandler? PropertyChanged;

    public DuneGameStateViewModel(IByteReaderWriter memory, SegmentRegisters segmentRegisters) {
        _gameState = new DuneGameState(memory, segmentRegisters);
        Sietches = new ObservableCollection<SietchViewModel>();
        Troops = new ObservableCollection<TroopViewModel>();
        
        for (int i = 0; i < 70; i++) {
            Sietches.Add(new SietchViewModel(i));
        }
        for (int i = 0; i < 68; i++) {
            Troops.Add(new TroopViewModel(i));
        }
        
        _refreshTimer = new Timer(250);
        _refreshTimer.Elapsed += OnRefreshTimerElapsed;
        _refreshTimer.AutoReset = true;
        _refreshTimer.Start();
    }

    // Core game state
    public ushort GameElapsedTime => _gameState.GameElapsedTime;
    public string GameElapsedTimeHex => $"0x{GameElapsedTime:X4}";
    public byte Charisma => _gameState.Charisma;
    public string CharismaDisplay => $"{Charisma} (0x{Charisma:X2})";
    public byte GameStage => _gameState.GameStage;
    public string GameStageDisplay => _gameState.GetGameStageDescription();
    public ushort Spice => _gameState.Spice;
    public string SpiceDisplay => _gameState.GetFormattedSpice();
    public ushort DateTimeRaw => _gameState.DateTimeRaw;
    public string DateTimeDisplay => _gameState.GetFormattedDateTime();
    public byte ContactDistance => _gameState.ContactDistance;
    public string ContactDistanceDisplay => $"{ContactDistance} (0x{ContactDistance:X2})";

    // HNM Video state
    public byte HnmFinishedFlag => _gameState.HnmFinishedFlag;
    public ushort HnmFrameCounter => _gameState.HnmFrameCounter;
    public ushort HnmCounter2 => _gameState.HnmCounter2;
    public byte CurrentHnmResourceFlag => _gameState.CurrentHnmResourceFlag;
    public ushort HnmVideoId => _gameState.HnmVideoId;
    public ushort HnmActiveVideoId => _gameState.HnmActiveVideoId;
    public uint HnmFileOffset => _gameState.HnmFileOffset;
    public uint HnmFileRemain => _gameState.HnmFileRemain;
    public string HnmVideoIdDisplay => $"0x{HnmVideoId:X4}";
    public string HnmFileOffsetDisplay => $"0x{HnmFileOffset:X8}";
    public string HnmFileRemainDisplay => $"0x{HnmFileRemain:X8} ({HnmFileRemain} bytes)";

    // Display and graphics
    public ushort FramebufferFront => _gameState.FramebufferFront;
    public ushort ScreenBuffer => _gameState.ScreenBuffer;
    public ushort FramebufferActive => _gameState.FramebufferActive;
    public ushort FramebufferBack => _gameState.FramebufferBack;
    public string FramebufferFrontDisplay => $"0x{FramebufferFront:X4}";
    public string ScreenBufferDisplay => $"0x{ScreenBuffer:X4}";
    public string FramebufferActiveDisplay => $"0x{FramebufferActive:X4}";
    public string FramebufferBackDisplay => $"0x{FramebufferBack:X4}";

    // Mouse and cursor
    public ushort MousePosY => _gameState.MousePosY;
    public ushort MousePosX => _gameState.MousePosX;
    public string MousePositionDisplay => $"({MousePosX}, {MousePosY})";
    public ushort MouseDrawPosY => _gameState.MouseDrawPosY;
    public ushort MouseDrawPosX => _gameState.MouseDrawPosX;
    public string MouseDrawPositionDisplay => $"({MouseDrawPosX}, {MouseDrawPosY})";
    public byte CursorHideCounter => _gameState.CursorHideCounter;
    public ushort MapCursorType => _gameState.MapCursorType;
    public string MapCursorTypeDisplay => $"0x{MapCursorType:X4}";

    // Sound
    public byte IsSoundPresent => _gameState.IsSoundPresent;
    public string IsSoundPresentDisplay => IsSoundPresent != 0 ? "Yes" : "No";
    public ushort MidiFunc5ReturnBx => _gameState.MidiFunc5ReturnBx;
    public string MidiFunc5ReturnBxDisplay => $"0x{MidiFunc5ReturnBx:X4}";

    // Effects
    public byte TransitionBitmask => _gameState.TransitionBitmask;
    public string TransitionBitmaskDisplay => $"0x{TransitionBitmask:X2} (0b{Convert.ToString(TransitionBitmask, 2).PadLeft(8, '0')})";

    // Sietches
    public ObservableCollection<SietchViewModel> Sietches { get; }
    public int DiscoveredSietchCount => _gameState.GetDiscoveredSietchCount();
    public string DiscoveredSietchCountDisplay => $"{DiscoveredSietchCount} / 70";

    // Troops
    public ObservableCollection<TroopViewModel> Troops { get; }
    public int ActiveTroopCount => _gameState.GetActiveTroopCount();
    public string ActiveTroopCountDisplay => $"{ActiveTroopCount} / 68";

    // NPCs/Characters
    public byte Follower1Id => _gameState.Follower1Id;
    public string Follower1Name => DuneGameState.GetNpcName(Follower1Id);
    public byte Follower2Id => _gameState.Follower2Id;
    public string Follower2Name => DuneGameState.GetNpcName(Follower2Id);
    public byte CurrentRoomId => _gameState.CurrentRoomId;
    public string CurrentRoomDisplay => $"Room #{CurrentRoomId} (0x{CurrentRoomId:X2})";
    public ushort WorldPosX => _gameState.WorldPosX;
    public ushort WorldPosY => _gameState.WorldPosY;
    public string WorldPositionDisplay => $"({WorldPosX}, {WorldPosY})";
    public byte CurrentSpeakerId => _gameState.CurrentSpeakerId;
    public string CurrentSpeakerName => DuneGameState.GetNpcName(CurrentSpeakerId);
    public ushort DialogueState => _gameState.DialogueState;
    public string DialogueStateDisplay => $"0x{DialogueState:X4}";

    // Player stats
    public ushort WaterReserve => _gameState.WaterReserve;
    public string WaterReserveDisplay => $"{WaterReserve} units";
    public ushort SpiceReserve => _gameState.SpiceReserve;
    public string SpiceReserveDisplay => $"{SpiceReserve} kg";
    public uint Money => _gameState.Money;
    public string MoneyDisplay => $"{Money:N0} solaris";
    public byte MilitaryStrength => _gameState.MilitaryStrength;
    public string MilitaryStrengthDisplay => $"{MilitaryStrength} (0x{MilitaryStrength:X2})";
    public byte EcologyProgress => _gameState.EcologyProgress;
    public string EcologyProgressDisplay => $"{EcologyProgress}% (0x{EcologyProgress:X2})";

    private void OnRefreshTimerElapsed(object? sender, ElapsedEventArgs e) {
        RefreshSietches();
        RefreshTroops();
        NotifyGameStateProperties();
    }

    private void RefreshSietches() {
        for (int i = 0; i < 70; i++) {
            Sietches[i].Status = _gameState.GetSietchStatus(i);
            Sietches[i].SpiceField = _gameState.GetSietchSpiceField(i);
            var coords = _gameState.GetSietchCoordinates(i);
            Sietches[i].X = coords.X;
            Sietches[i].Y = coords.Y;
        }
    }

    private void RefreshTroops() {
        for (int i = 0; i < 68; i++) {
            Troops[i].Occupation = _gameState.GetTroopOccupation(i);
            Troops[i].OccupationName = DuneGameState.GetTroopOccupationDescription(Troops[i].Occupation);
            Troops[i].Location = _gameState.GetTroopLocation(i);
            Troops[i].Motivation = _gameState.GetTroopMotivation(i);
            Troops[i].SpiceSkill = _gameState.GetTroopSpiceSkill(i);
            Troops[i].ArmySkill = _gameState.GetTroopArmySkill(i);
            Troops[i].EcologySkill = _gameState.GetTroopEcologySkill(i);
            Troops[i].Equipment = _gameState.GetTroopEquipment(i);
        }
    }

    private void NotifyGameStateProperties() {
        OnPropertyChanged(nameof(GameElapsedTime));
        OnPropertyChanged(nameof(GameElapsedTimeHex));
        OnPropertyChanged(nameof(DateTimeRaw));
        OnPropertyChanged(nameof(DateTimeDisplay));
        OnPropertyChanged(nameof(Spice));
        OnPropertyChanged(nameof(SpiceDisplay));
        OnPropertyChanged(nameof(Charisma));
        OnPropertyChanged(nameof(CharismaDisplay));
        OnPropertyChanged(nameof(ContactDistance));
        OnPropertyChanged(nameof(ContactDistanceDisplay));
        OnPropertyChanged(nameof(GameStage));
        OnPropertyChanged(nameof(GameStageDisplay));
        OnPropertyChanged(nameof(HnmFinishedFlag));
        OnPropertyChanged(nameof(HnmFrameCounter));
        OnPropertyChanged(nameof(HnmCounter2));
        OnPropertyChanged(nameof(CurrentHnmResourceFlag));
        OnPropertyChanged(nameof(HnmVideoId));
        OnPropertyChanged(nameof(HnmVideoIdDisplay));
        OnPropertyChanged(nameof(HnmActiveVideoId));
        OnPropertyChanged(nameof(HnmFileOffset));
        OnPropertyChanged(nameof(HnmFileOffsetDisplay));
        OnPropertyChanged(nameof(HnmFileRemain));
        OnPropertyChanged(nameof(HnmFileRemainDisplay));
        OnPropertyChanged(nameof(FramebufferFront));
        OnPropertyChanged(nameof(FramebufferFrontDisplay));
        OnPropertyChanged(nameof(ScreenBuffer));
        OnPropertyChanged(nameof(ScreenBufferDisplay));
        OnPropertyChanged(nameof(FramebufferActive));
        OnPropertyChanged(nameof(FramebufferActiveDisplay));
        OnPropertyChanged(nameof(FramebufferBack));
        OnPropertyChanged(nameof(FramebufferBackDisplay));
        OnPropertyChanged(nameof(TransitionBitmask));
        OnPropertyChanged(nameof(TransitionBitmaskDisplay));
        OnPropertyChanged(nameof(MousePosX));
        OnPropertyChanged(nameof(MousePosY));
        OnPropertyChanged(nameof(MousePositionDisplay));
        OnPropertyChanged(nameof(MouseDrawPosX));
        OnPropertyChanged(nameof(MouseDrawPosY));
        OnPropertyChanged(nameof(MouseDrawPositionDisplay));
        OnPropertyChanged(nameof(CursorHideCounter));
        OnPropertyChanged(nameof(MapCursorType));
        OnPropertyChanged(nameof(MapCursorTypeDisplay));
        OnPropertyChanged(nameof(IsSoundPresent));
        OnPropertyChanged(nameof(IsSoundPresentDisplay));
        OnPropertyChanged(nameof(MidiFunc5ReturnBx));
        OnPropertyChanged(nameof(MidiFunc5ReturnBxDisplay));
        OnPropertyChanged(nameof(DiscoveredSietchCount));
        OnPropertyChanged(nameof(DiscoveredSietchCountDisplay));
        OnPropertyChanged(nameof(ActiveTroopCount));
        OnPropertyChanged(nameof(ActiveTroopCountDisplay));
        OnPropertyChanged(nameof(Follower1Id));
        OnPropertyChanged(nameof(Follower1Name));
        OnPropertyChanged(nameof(Follower2Id));
        OnPropertyChanged(nameof(Follower2Name));
        OnPropertyChanged(nameof(CurrentRoomId));
        OnPropertyChanged(nameof(CurrentRoomDisplay));
        OnPropertyChanged(nameof(WorldPosX));
        OnPropertyChanged(nameof(WorldPosY));
        OnPropertyChanged(nameof(WorldPositionDisplay));
        OnPropertyChanged(nameof(CurrentSpeakerId));
        OnPropertyChanged(nameof(CurrentSpeakerName));
        OnPropertyChanged(nameof(DialogueState));
        OnPropertyChanged(nameof(DialogueStateDisplay));
        OnPropertyChanged(nameof(WaterReserve));
        OnPropertyChanged(nameof(WaterReserveDisplay));
        OnPropertyChanged(nameof(SpiceReserve));
        OnPropertyChanged(nameof(SpiceReserveDisplay));
        OnPropertyChanged(nameof(Money));
        OnPropertyChanged(nameof(MoneyDisplay));
        OnPropertyChanged(nameof(MilitaryStrength));
        OnPropertyChanged(nameof(MilitaryStrengthDisplay));
        OnPropertyChanged(nameof(EcologyProgress));
        OnPropertyChanged(nameof(EcologyProgressDisplay));
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public void Dispose() {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing) {
        if (!_disposed) {
            if (disposing) {
                _refreshTimer.Stop();
                _refreshTimer.Dispose();
            }
            _disposed = true;
        }
    }
}

public class SietchViewModel : INotifyPropertyChanged {
    public event PropertyChangedEventHandler? PropertyChanged;

    public SietchViewModel(int index) {
        Index = index;
    }

    public int Index { get; }

    private byte _status;
    public byte Status {
        get => _status;
        set { if (_status != value) { _status = value; OnPropertyChanged(); OnPropertyChanged(nameof(IsDiscovered)); } }
    }

    public bool IsDiscovered => Status != 0;

    private ushort _spiceField;
    public ushort SpiceField {
        get => _spiceField;
        set { if (_spiceField != value) { _spiceField = value; OnPropertyChanged(); } }
    }

    private ushort _x;
    public ushort X {
        get => _x;
        set { if (_x != value) { _x = value; OnPropertyChanged(); } }
    }

    private ushort _y;
    public ushort Y {
        get => _y;
        set { if (_y != value) { _y = value; OnPropertyChanged(); } }
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

public class TroopViewModel : INotifyPropertyChanged {
    public event PropertyChangedEventHandler? PropertyChanged;

    public TroopViewModel(int index) {
        Index = index;
    }

    public int Index { get; }

    private byte _occupation;
    public byte Occupation {
        get => _occupation;
        set { if (_occupation != value) { _occupation = value; OnPropertyChanged(); OnPropertyChanged(nameof(IsActive)); } }
    }

    public bool IsActive => Occupation != 0;

    private string _occupationName = "Idle";
    public string OccupationName {
        get => _occupationName;
        set { if (_occupationName != value) { _occupationName = value; OnPropertyChanged(); } }
    }

    private byte _location;
    public byte Location {
        get => _location;
        set { if (_location != value) { _location = value; OnPropertyChanged(); } }
    }

    private byte _motivation;
    public byte Motivation {
        get => _motivation;
        set { if (_motivation != value) { _motivation = value; OnPropertyChanged(); } }
    }

    private byte _spiceSkill;
    public byte SpiceSkill {
        get => _spiceSkill;
        set { if (_spiceSkill != value) { _spiceSkill = value; OnPropertyChanged(); } }
    }

    private byte _armySkill;
    public byte ArmySkill {
        get => _armySkill;
        set { if (_armySkill != value) { _armySkill = value; OnPropertyChanged(); } }
    }

    private byte _ecologySkill;
    public byte EcologySkill {
        get => _ecologySkill;
        set { if (_ecologySkill != value) { _ecologySkill = value; OnPropertyChanged(); } }
    }

    private byte _equipment;
    public byte Equipment {
        get => _equipment;
        set { if (_equipment != value) { _equipment = value; OnPropertyChanged(); } }
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
