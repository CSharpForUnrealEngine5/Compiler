#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/LevelEditorPlaySettings.h")]
///<summary>Implements the Editor's play settings.</summary>
public partial class ULevelEditorPlaySettings : UObject {
// LevelEditorPlaySettings
	public sbyte PlayFromHerePlayerStartClassName;
	public bool GameGetsMouseControl;
	public bool UseMouseForTouch;
	public bool ShowMouseControlLabel;
	public byte MouseControlLabelPosition;
	public bool ViewportGetsHMDControl;
	public bool ShouldMinimizeEditorOnVRPIE;
	public bool bShouldMinimizeEditorOnNonVRPIE;
	public bool bEmulateStereo;
	public bool AutoRecompileBlueprints;
	public bool EnableGameSound;
	public bool SoloAudioInFirstPIEClient;
	public bool EnablePIEEnterAndExitSounds;
	public int PlayInEditorSoundQualityLevel;
	public bool bUseNonRealtimeAudioDevice;
	public bool bOnlyLoadVisibleLevelsInPIE;
	public bool bPreferToStreamLevelsInPIE;
	public bool bPromoteOutputLogWarningsDuringPIE;
	public int NewWindowWidth;
	public int NewWindowHeight;
	public FIntPoint NewWindowPosition;
	public bool CenterNewWindow;
	public bool PIEAlwaysOnTop;
	public bool DisableStandaloneSound;
	public sbyte AdditionalLaunchParameters;
	public byte BuildGameBeforeLaunch;
	public byte LaunchConfiguration;
	public EPlayOnPakFileMode PackFilesForLaunch;
	public bool bAutoCompileBlueprintsOnLaunch;
	public bool bLaunchSeparateServer;
	public byte PlayNetMode;
	public bool RunUnderOneProcess;
	public bool PlayNetDedicated;
	public int PlayNumberOfClients;
	public int PrimaryPIEClientIndex;
	public ushort ServerPort;
	public int ClientWindowWidth;
	public bool AutoConnectToServer;
	public bool RouteGamepadToSecondWindow;
	public bool CreateAudioDeviceForEveryPlayer;
	public int ClientWindowHeight;
	public sbyte ServerMapNameOverride;
	public sbyte AdditionalServerGameOptions;
	public sbyte AdditionalLaunchOptions;
	public bool bShowServerDebugDrawingByDefault;
	public float ServerDebugDrawingColorTintStrength;
	public FLinearColor ServerDebugDrawingColorTint;
	public sbyte AdditionalServerLaunchParameters;
	public int ServerFixedFPS;
	public TArray<int> ClientFixedFPS;
	public FLevelEditorPlayNetworkEmulationSettings NetworkEmulationSettings;
	public FIntPoint LastSize;
	public TArray<FIntPoint> MultipleInstancePositions;
	public sbyte LastExecutedLaunchDevice;
	public sbyte LastExecutedLaunchName;
	public byte LastExecutedLaunchModeType;
	public byte LastExecutedPlayModeLocation;
	public byte LastExecutedPlayModeType;
	public sbyte LastExecutedPIEPreviewDevice;
	public TArray<FPlayScreenResolution> LaptopScreenResolutions;
	public TArray<FPlayScreenResolution> MonitorScreenResolutions;
	public TArray<FPlayScreenResolution> PhoneScreenResolutions;
	public TArray<FPlayScreenResolution> TabletScreenResolutions;
	public TArray<FPlayScreenResolution> TelevisionScreenResolutions;
	public sbyte DeviceToEmulate;
	public FMargin PIESafeZoneOverride;
	public TArray<FVector2D> CustomUnsafeZoneStarts;
	public TArray<FVector2D> CustomUnsafeZoneDimensions;
}