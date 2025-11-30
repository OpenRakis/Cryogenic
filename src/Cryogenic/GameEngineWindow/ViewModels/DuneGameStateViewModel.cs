namespace Cryogenic.GameEngineWindow.ViewModels;

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Cryogenic.GameEngineWindow.Models;

using Spice86.Core.Emulator.Memory.ReaderWriter;
using Spice86.Core.Emulator.VM;

public class DuneGameStateViewModel : INotifyPropertyChanged, IDisposable {
    private readonly DuneGameState _gameState;
    private readonly IPauseHandler? _pauseHandler;
    private bool _disposed;
    private bool _isPaused;

    public event PropertyChangedEventHandler? PropertyChanged;

    public bool IsPaused {
        get => _isPaused;
        private set {
            if (_isPaused != value) {
                _isPaused = value;
                OnPropertyChanged();
            }
        }
    }

    public DuneGameStateViewModel(IByteReaderWriter memory, IPauseHandler? pauseHandler = null) {
        _gameState = new DuneGameState(memory);
        _pauseHandler = pauseHandler;
        
        Locations = new ObservableCollection<LocationViewModel>();
        Troops = new ObservableCollection<TroopViewModel>();
        Npcs = new ObservableCollection<NpcViewModel>();
        Smugglers = new ObservableCollection<SmugglerViewModel>();
        Sietches = new ObservableCollection<SietchViewModel>();
        
        for (int i = 0; i < DuneGameState.MaxLocations; i++) {
            Locations.Add(new LocationViewModel(i));
            Sietches.Add(new SietchViewModel(i));
        }
        for (int i = 0; i < DuneGameState.MaxTroops; i++) {
            Troops.Add(new TroopViewModel(i));
        }
        for (int i = 0; i < DuneGameState.MaxNpcs; i++) {
            Npcs.Add(new NpcViewModel(i));
        }
        for (int i = 0; i < DuneGameState.MaxSmugglers; i++) {
            Smugglers.Add(new SmugglerViewModel(i));
        }
        
        if (_pauseHandler != null) {
            _pauseHandler.Paused += OnEmulatorPaused;
            _pauseHandler.Resumed += OnEmulatorResumed;
            IsPaused = _pauseHandler.IsPaused;
        }
    }

    private void OnEmulatorPaused() {
        IsPaused = true;
        RefreshAllData();
    }

    private void OnEmulatorResumed() {
        IsPaused = false;
    }

    public void RefreshAllData() {
        RefreshLocations();
        RefreshSietches();
        RefreshTroops();
        RefreshNpcs();
        RefreshSmugglers();
        NotifyGameStateProperties();
    }

    // Core game state
    public ushort GameElapsedTime => _gameState.GameElapsedTime;
    public string GameElapsedTimeHex => $"0x{GameElapsedTime:X4}";
    public byte CharismaRaw => _gameState.CharismaRaw;
    public int CharismaDisplayed => _gameState.CharismaDisplayed;
    public string CharismaDisplay => $"{CharismaDisplayed} (raw: 0x{CharismaRaw:X2})";
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

    public ObservableCollection<SietchViewModel> Sietches { get; }
    public int DiscoveredSietchCount => _gameState.GetDiscoveredSietchCount();
    public string DiscoveredSietchCountDisplay => $"{DiscoveredSietchCount} / {DuneGameState.MaxLocations}";

    public ObservableCollection<LocationViewModel> Locations { get; }
    public int DiscoveredLocationCount => _gameState.GetDiscoveredLocationCount();
    public string DiscoveredLocationCountDisplay => $"{DiscoveredLocationCount} / {DuneGameState.MaxLocations}";

    public ObservableCollection<TroopViewModel> Troops { get; }
    public int ActiveTroopCount => _gameState.GetActiveTroopCount();
    public string ActiveTroopCountDisplay => $"{ActiveTroopCount} / {DuneGameState.MaxTroops}";

    public ObservableCollection<NpcViewModel> Npcs { get; }
    public ObservableCollection<SmugglerViewModel> Smugglers { get; }

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

    private void RefreshLocations() {
        for (int i = 0; i < DuneGameState.MaxLocations; i++) {
            Locations[i].NameFirst = _gameState.GetLocationNameFirst(i);
            Locations[i].NameSecond = _gameState.GetLocationNameSecond(i);
            Locations[i].Status = _gameState.GetLocationStatus(i);
            Locations[i].Appearance = _gameState.GetLocationAppearance(i);
            Locations[i].HousedTroopId = _gameState.GetLocationHousedTroopId(i);
            Locations[i].SpiceFieldId = _gameState.GetLocationSpiceFieldId(i);
            Locations[i].SpiceAmount = _gameState.GetLocationSpiceAmount(i);
            Locations[i].SpiceDensity = _gameState.GetLocationSpiceDensity(i);
            Locations[i].Harvesters = _gameState.GetLocationHarvesters(i);
            Locations[i].Ornithopters = _gameState.GetLocationOrnithopters(i);
            Locations[i].Water = _gameState.GetLocationWater(i);
            var coords = _gameState.GetLocationCoordinates(i);
            Locations[i].X = coords.X;
            Locations[i].Y = coords.Y;
        }
    }

    private void RefreshSietches() {
        for (int i = 0; i < DuneGameState.MaxLocations; i++) {
            Sietches[i].Status = _gameState.GetSietchStatus(i);
            Sietches[i].SpiceField = _gameState.GetSietchSpiceField(i);
            var coords = _gameState.GetSietchCoordinates(i);
            Sietches[i].X = coords.X;
            Sietches[i].Y = coords.Y;
        }
    }

    private void RefreshTroops() {
        for (int i = 0; i < DuneGameState.MaxTroops; i++) {
            Troops[i].TroopId = _gameState.GetTroopId(i);
            Troops[i].Occupation = _gameState.GetTroopOccupation(i);
            Troops[i].OccupationName = DuneGameState.GetTroopOccupationDescription(Troops[i].Occupation);
            Troops[i].IsFremen = DuneGameState.IsTroopFremen(Troops[i].Occupation);
            Troops[i].Position = _gameState.GetTroopPosition(i);
            Troops[i].Location = _gameState.GetTroopLocation(i);
            Troops[i].Motivation = _gameState.GetTroopMotivation(i);
            Troops[i].Dissatisfaction = _gameState.GetTroopDissatisfaction(i);
            Troops[i].SpiceSkill = _gameState.GetTroopSpiceSkill(i);
            Troops[i].ArmySkill = _gameState.GetTroopArmySkill(i);
            Troops[i].EcologySkill = _gameState.GetTroopEcologySkill(i);
            Troops[i].Equipment = _gameState.GetTroopEquipment(i);
            Troops[i].EquipmentDescription = DuneGameState.GetTroopEquipmentDescription(Troops[i].Equipment);
            Troops[i].Population = _gameState.GetTroopPopulation(i);
        }
    }

    private void RefreshNpcs() {
        for (int i = 0; i < DuneGameState.MaxNpcs; i++) {
            Npcs[i].SpriteId = _gameState.GetNpcSpriteId(i);
            Npcs[i].RoomLocation = _gameState.GetNpcRoomLocation(i);
            Npcs[i].PlaceType = _gameState.GetNpcPlaceType(i);
            Npcs[i].ExactPlace = _gameState.GetNpcExactPlace(i);
            Npcs[i].DialogueFlag = _gameState.GetNpcDialogueFlag(i);
        }
    }

    private void RefreshSmugglers() {
        for (int i = 0; i < DuneGameState.MaxSmugglers; i++) {
            Smugglers[i].Region = _gameState.GetSmugglerRegion(i);
            Smugglers[i].LocationName = _gameState.GetSmugglerLocationName(i);
            Smugglers[i].WillingnessToHaggle = _gameState.GetSmugglerWillingnessToHaggle(i);
            Smugglers[i].Harvesters = _gameState.GetSmugglerHarvesters(i);
            Smugglers[i].Ornithopters = _gameState.GetSmugglerOrnithopters(i);
            Smugglers[i].KrysKnives = _gameState.GetSmugglerKrysKnives(i);
            Smugglers[i].LaserGuns = _gameState.GetSmugglerLaserGuns(i);
            Smugglers[i].WeirdingModules = _gameState.GetSmugglerWeirdingModules(i);
            Smugglers[i].HarvesterPrice = _gameState.GetSmugglerHarvesterPrice(i);
            Smugglers[i].OrnithopterPrice = _gameState.GetSmugglerOrnithopterPrice(i);
            Smugglers[i].KrysKnifePrice = _gameState.GetSmugglerKrysKnifePrice(i);
            Smugglers[i].LaserGunPrice = _gameState.GetSmugglerLaserGunPrice(i);
            Smugglers[i].WeirdingModulePrice = _gameState.GetSmugglerWeirdingModulePrice(i);
        }
    }

    private void NotifyGameStateProperties() {
        OnPropertyChanged(nameof(GameElapsedTime));
        OnPropertyChanged(nameof(GameElapsedTimeHex));
        OnPropertyChanged(nameof(DateTimeRaw));
        OnPropertyChanged(nameof(DateTimeDisplay));
        OnPropertyChanged(nameof(Spice));
        OnPropertyChanged(nameof(SpiceDisplay));
        OnPropertyChanged(nameof(CharismaRaw));
        OnPropertyChanged(nameof(CharismaDisplayed));
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
        OnPropertyChanged(nameof(DiscoveredLocationCount));
        OnPropertyChanged(nameof(DiscoveredLocationCountDisplay));
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
            if (disposing && _pauseHandler != null) {
                _pauseHandler.Paused -= OnEmulatorPaused;
                _pauseHandler.Resumed -= OnEmulatorResumed;
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

    private byte _troopId;
    public byte TroopId {
        get => _troopId;
        set { if (_troopId != value) { _troopId = value; OnPropertyChanged(); } }
    }

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

    private bool _isFremen;
    public bool IsFremen {
        get => _isFremen;
        set { if (_isFremen != value) { _isFremen = value; OnPropertyChanged(); } }
    }

    private byte _position;
    public byte Position {
        get => _position;
        set { if (_position != value) { _position = value; OnPropertyChanged(); } }
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

    private byte _dissatisfaction;
    public byte Dissatisfaction {
        get => _dissatisfaction;
        set { if (_dissatisfaction != value) { _dissatisfaction = value; OnPropertyChanged(); } }
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

    private string _equipmentDescription = "None";
    public string EquipmentDescription {
        get => _equipmentDescription;
        set { if (_equipmentDescription != value) { _equipmentDescription = value; OnPropertyChanged(); } }
    }

    private ushort _population;
    public ushort Population {
        get => _population;
        set { if (_population != value) { _population = value; OnPropertyChanged(); } }
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

public class LocationViewModel : INotifyPropertyChanged {
    public event PropertyChangedEventHandler? PropertyChanged;

    public LocationViewModel(int index) {
        Index = index;
    }

    public int Index { get; }

    private byte _nameFirst;
    public byte NameFirst {
        get => _nameFirst;
        set { if (_nameFirst != value) { _nameFirst = value; OnPropertyChanged(); OnPropertyChanged(nameof(Name)); OnPropertyChanged(nameof(LocationType)); } }
    }

    private byte _nameSecond;
    public byte NameSecond {
        get => _nameSecond;
        set { if (_nameSecond != value) { _nameSecond = value; OnPropertyChanged(); OnPropertyChanged(nameof(Name)); OnPropertyChanged(nameof(LocationType)); } }
    }

    public string Name => DuneGameState.GetLocationNameStr(NameFirst, NameSecond);
    public string LocationType => DuneGameState.GetLocationTypeStr(NameSecond);

    private byte _status;
    public byte Status {
        get => _status;
        set { if (_status != value) { _status = value; OnPropertyChanged(); OnPropertyChanged(nameof(IsDiscovered)); } }
    }

    public bool IsDiscovered => (Status & DuneGameState.LocationStatusUndiscovered) == 0;

    private byte _appearance;
    public byte Appearance {
        get => _appearance;
        set { if (_appearance != value) { _appearance = value; OnPropertyChanged(); } }
    }

    private byte _housedTroopId;
    public byte HousedTroopId {
        get => _housedTroopId;
        set { if (_housedTroopId != value) { _housedTroopId = value; OnPropertyChanged(); } }
    }

    private byte _spiceFieldId;
    public byte SpiceFieldId {
        get => _spiceFieldId;
        set { if (_spiceFieldId != value) { _spiceFieldId = value; OnPropertyChanged(); } }
    }

    private byte _spiceAmount;
    public byte SpiceAmount {
        get => _spiceAmount;
        set { if (_spiceAmount != value) { _spiceAmount = value; OnPropertyChanged(); } }
    }

    private byte _spiceDensity;
    public byte SpiceDensity {
        get => _spiceDensity;
        set { if (_spiceDensity != value) { _spiceDensity = value; OnPropertyChanged(); } }
    }

    private byte _harvesters;
    public byte Harvesters {
        get => _harvesters;
        set { if (_harvesters != value) { _harvesters = value; OnPropertyChanged(); } }
    }

    private byte _ornithopters;
    public byte Ornithopters {
        get => _ornithopters;
        set { if (_ornithopters != value) { _ornithopters = value; OnPropertyChanged(); } }
    }

    private byte _water;
    public byte Water {
        get => _water;
        set { if (_water != value) { _water = value; OnPropertyChanged(); } }
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

public class NpcViewModel : INotifyPropertyChanged {
    public event PropertyChangedEventHandler? PropertyChanged;

    public NpcViewModel(int index) {
        Index = index;
    }

    public int Index { get; }
    public string Name => DuneGameState.GetNpcName((byte)(Index + 1));

    private byte _spriteId;
    public byte SpriteId {
        get => _spriteId;
        set { if (_spriteId != value) { _spriteId = value; OnPropertyChanged(); } }
    }

    private byte _roomLocation;
    public byte RoomLocation {
        get => _roomLocation;
        set { if (_roomLocation != value) { _roomLocation = value; OnPropertyChanged(); } }
    }

    private byte _placeType;
    public byte PlaceType {
        get => _placeType;
        set { if (_placeType != value) { _placeType = value; OnPropertyChanged(); OnPropertyChanged(nameof(PlaceTypeDescription)); } }
    }

    public string PlaceTypeDescription => DuneGameState.GetNpcPlaceTypeDescription(PlaceType);

    private byte _exactPlace;
    public byte ExactPlace {
        get => _exactPlace;
        set { if (_exactPlace != value) { _exactPlace = value; OnPropertyChanged(); } }
    }

    private byte _dialogueFlag;
    public byte DialogueFlag {
        get => _dialogueFlag;
        set { if (_dialogueFlag != value) { _dialogueFlag = value; OnPropertyChanged(); } }
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

public class SmugglerViewModel : INotifyPropertyChanged {
    public event PropertyChangedEventHandler? PropertyChanged;

    public SmugglerViewModel(int index) {
        Index = index;
    }

    public int Index { get; }

    private byte _region;
    public byte Region {
        get => _region;
        set { if (_region != value) { _region = value; OnPropertyChanged(); } }
    }

    private string _locationName = "";
    public string LocationName {
        get => _locationName;
        set { if (_locationName != value) { _locationName = value; OnPropertyChanged(); } }
    }

    private byte _willingnessToHaggle;
    public byte WillingnessToHaggle {
        get => _willingnessToHaggle;
        set { if (_willingnessToHaggle != value) { _willingnessToHaggle = value; OnPropertyChanged(); } }
    }

    private byte _harvesters;
    public byte Harvesters {
        get => _harvesters;
        set { if (_harvesters != value) { _harvesters = value; OnPropertyChanged(); } }
    }

    private byte _ornithopters;
    public byte Ornithopters {
        get => _ornithopters;
        set { if (_ornithopters != value) { _ornithopters = value; OnPropertyChanged(); } }
    }

    private byte _krysKnives;
    public byte KrysKnives {
        get => _krysKnives;
        set { if (_krysKnives != value) { _krysKnives = value; OnPropertyChanged(); } }
    }

    private byte _laserGuns;
    public byte LaserGuns {
        get => _laserGuns;
        set { if (_laserGuns != value) { _laserGuns = value; OnPropertyChanged(); } }
    }

    private byte _weirdingModules;
    public byte WeirdingModules {
        get => _weirdingModules;
        set { if (_weirdingModules != value) { _weirdingModules = value; OnPropertyChanged(); } }
    }

    private ushort _harvesterPrice;
    public ushort HarvesterPrice {
        get => _harvesterPrice;
        set { if (_harvesterPrice != value) { _harvesterPrice = value; OnPropertyChanged(); } }
    }

    private ushort _ornithopterPrice;
    public ushort OrnithopterPrice {
        get => _ornithopterPrice;
        set { if (_ornithopterPrice != value) { _ornithopterPrice = value; OnPropertyChanged(); } }
    }

    private ushort _krysKnifePrice;
    public ushort KrysKnifePrice {
        get => _krysKnifePrice;
        set { if (_krysKnifePrice != value) { _krysKnifePrice = value; OnPropertyChanged(); } }
    }

    private ushort _laserGunPrice;
    public ushort LaserGunPrice {
        get => _laserGunPrice;
        set { if (_laserGunPrice != value) { _laserGunPrice = value; OnPropertyChanged(); } }
    }

    private ushort _weirdingModulePrice;
    public ushort WeirdingModulePrice {
        get => _weirdingModulePrice;
        set { if (_weirdingModulePrice != value) { _weirdingModulePrice = value; OnPropertyChanged(); } }
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
