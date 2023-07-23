#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HoloLensTargetSettings.h")]
///<summary>Implements the settings for the HoloLens target platform.</summary>
public partial class UHoloLensTargetSettings : UObject {
// HoloLensTargetSettings
	public bool bBuildForEmulation;
	public bool bBuildForDevice;
	public bool bUseNameForLogo;
	public bool bBuildForRetailWindowsStore;
	public bool bAutoIncrementVersion;
	public bool bShouldCreateAppInstaller;
	public sbyte AppInstallerInstallationURL;
	public int HoursBetweenUpdateChecks;
	public bool bEnablePIXProfiling;
	public FColor TileBackgroundColor;
	public FColor SplashScreenBackgroundColor;
	public TArray<FHoloLensCorePackageLocalizedResources> PerCultureResources;
	public sbyte TargetDeviceFamily;
	public sbyte MinimumPlatformVersion;
	public sbyte MaximumPlatformVersionTested;
	public float MaxTrianglesPerCubicMeter;
	public float SpatialMeshingVolumeSize;
	public ECompilerVersion CompilerVersion;
	public sbyte Windows10SDKVersion;
	public TArray<sbyte> CapabilityList;
	public TArray<sbyte> DeviceCapabilityList;
	public TArray<sbyte> UapCapabilityList;
	public TArray<sbyte> Uap2CapabilityList;
	public bool bSetDefaultCapabilities;
	public sbyte SpatializationPlugin;
	public sbyte SourceDataOverridePlugin;
	public sbyte ReverbPlugin;
	public sbyte OcclusionPlugin;
	public int SoundCueCookQualityIndex;
}
