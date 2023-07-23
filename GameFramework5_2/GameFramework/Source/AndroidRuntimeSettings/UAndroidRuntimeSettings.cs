#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AndroidRuntimeSettings.h")]
///<summary>Implements the settings for the Android runtime platform.</summary>
public partial class UAndroidRuntimeSettings : UObject {
// AndroidRuntimeSettings
	public sbyte PackageName;
	public int StoreVersion;
	public int StoreVersionOffsetArm64;
	public int StoreVersionOffsetX8664;
	public sbyte ApplicationDisplayName;
	public sbyte VersionDisplayName;
	public int MinSDKVersion;
	public int TargetSDKVersion;
	public byte InstallLocation;
	public bool bEnableLint;
	public bool bPackageDataInsideApk;
	public bool bCreateAllPlatformsInstall;
	public bool bDisableVerifyOBBOnStartUp;
	public bool bForceSmallOBBFiles;
	public bool bAllowLargeOBBFiles;
	public bool bAllowPatchOBBFile;
	public bool bAllowOverflowOBBFiles;
	public bool bUseExternalFilesDir;
	public bool bPublicLogFiles;
	public byte Orientation;
	public float MaxAspectRatio;
	public bool bUseDisplayCutout;
	public bool bRestoreNotificationsOnReboot;
	public bool bFullScreen;
	public bool bEnableNewKeyboard;
	public byte DepthBufferPreference;
	public bool bValidateTextureFormats;
	public bool bForceCompressNativeLibs;
	public bool bEnableAdvancedBinaryCompression;
	public bool bEnableBundle;
	public bool bEnableUniversalAPK;
	public bool bBundleABISplit;
	public bool bBundleLanguageSplit;
	public bool bBundleDensitySplit;
	public TArray<sbyte> ExtraManifestNodeTags;
	public TArray<sbyte> ExtraApplicationNodeTags;
	public sbyte ExtraApplicationSettings;
	public TArray<sbyte> ExtraActivityNodeTags;
	public sbyte ExtraActivitySettings;
	public TArray<sbyte> ExtraPermissions;
	public bool bAndroidVoiceEnabled;
	public bool bEnableMulticastSupport;
	public TArray<byte> PackageForOculusMobile;
	public bool bRemoveOSIG;
	public sbyte KeyStore;
	public sbyte KeyAlias;
	public sbyte KeyStorePassword;
	public sbyte KeyPassword;
	public bool bBuildForArm64;
	public bool bBuildForX8664;
	public bool bBuildForES31;
	public bool bSupportsVulkan;
	public bool bSupportsVulkanSM5;
	public FDirectoryPath DebugVulkanLayerDirectory;
	public TArray<sbyte> DebugVulkanDeviceLayers;
	public TArray<sbyte> DebugVulkanInstanceLayers;
	public bool bAndroidOpenGLSupportsBackbufferSampling;
	public bool bDetectVulkanByDefault;
	public bool bBuildWithHiddenSymbolVisibility;
	public bool bDisableStackProtector;
	public bool bDisableLibCppSharedDependencyValidation;
	public bool bSaveSymbols;
	public bool bStripShaderReflection;
	public bool bEnableGooglePlaySupport;
	public bool bUseGetAccounts;
	public sbyte GamesAppID;
	public TArray<FGooglePlayAchievementMapping> AchievementMap;
	public TArray<FGooglePlayLeaderboardMapping> LeaderboardMap;
	public bool bEnableSnapshots;
	public bool bSupportAdMob;
	public sbyte AdMobAppID;
	public byte TagForChildDirectedTreatment;
	public byte TagForUnderAgeOfConsent;
	public byte MaxAdContentRating;
	public sbyte AdMobAdUnitID;
	public TArray<sbyte> AdMobAdUnitIDs;
	public sbyte GooglePlayLicenseKey;
	public sbyte GCMClientSenderID;
	public bool bShowLaunchImage;
	public bool bAllowIMU;
	public bool bAllowControllers;
	public bool bBlockAndroidKeysOnControllers;
	public bool bControllersBlockDeviceFeedback;
	public byte AndroidAudio;
	public int AudioSampleRate;
	public int AudioCallbackBufferFrameSize;
	public int AudioNumBuffersToEnqueue;
	public int AudioMaxChannels;
	public int AudioNumSourceWorkers;
	public sbyte SpatializationPlugin;
	public sbyte SourceDataOverridePlugin;
	public sbyte ReverbPlugin;
	public sbyte OcclusionPlugin;
	public FPlatformRuntimeAudioCompressionOverrides CompressionOverrides;
	public int CacheSizeKB;
	public int MaxChunkSizeOverrideKB;
	public bool bResampleForDevice;
	public int SoundCueCookQualityIndex;
	public float MaxSampleRate;
	public float HighSampleRate;
	public float MedSampleRate;
	public float LowSampleRate;
	public float MinSampleRate;
	public float CompressionQualityModifier;
	public float AutoStreamingThreshold;
	public byte AndroidGraphicsDebugger;
	public FDirectoryPath MaliGraphicsDebuggerPath;
	public bool bEnableMaliPerfCounters;
	public bool bMultiTargetFormat_ETC2;
	public bool bMultiTargetFormat_DXT;
	public bool bMultiTargetFormat_ASTC;
	public float TextureFormatPriority_ETC2;
	public float TextureFormatPriority_DXT;
	public float TextureFormatPriority_ASTC;
	public sbyte SDKAPILevelOverride;
	public sbyte NDKAPILevelOverride;
	public sbyte BuildToolsOverride;
	public bool bStreamLandscapeMeshLODs;
	public bool bEnableDomStorage;
}
