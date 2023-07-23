#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusPlatformToolSettings.h")]
public partial class UDEPRECATED_UOculusPlatformToolSettings : UObject {
// UOculusPlatformToolSettings
	public sbyte OculusRiftBuildDirectory;
	public sbyte OculusRiftBuildVersion;
	public sbyte OculusRiftLaunchParams;
	public bool OculusRiftFireWallException;
	public sbyte OculusRift2DLaunchPath;
	public sbyte OculusRift2DLaunchParams;
	public TArray<FRedistPackage> OculusRedistPackages;
	public bool UploadDebugSymbols;
	public bool DebugSymbolsOnly;
	public sbyte BuildID;
	public EOculusPlatformTarget OculusTargetPlatform;
	public TArray<sbyte> OculusApplicationID;
	public TArray<sbyte> OculusApplicationToken;
	public TArray<sbyte> OculusReleaseChannel;
	public TArray<sbyte> OculusReleaseNote;
	public TArray<sbyte> OculusLaunchFilePath;
	public EOculusGamepadEmulation OculusRiftGamepadEmulation;
	public TArray<sbyte> OculusLanguagePacksPath;
	public TArray<sbyte> OculusExpansionFilesPath;
	public TArray<sbyte> OculusSymbolDirPath;
	public TArray<FAssetConfigArray> OculusAssetConfigs;
}
