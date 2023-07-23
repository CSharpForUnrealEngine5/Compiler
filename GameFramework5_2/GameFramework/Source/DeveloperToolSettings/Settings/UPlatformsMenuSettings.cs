#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/PlatformsMenuSettings.h")]
public partial class UPlatformsMenuSettings : UObject {
// PlatformsMenuSettings
	public FDirectoryPath StagingDirectory;
	public sbyte LaunchOnTarget;
	public TMap<sbyte,EProjectPackagingBuildConfigurations> PerPlatformBuildConfig;
	public TMap<sbyte,sbyte> PerPlatformTargetFlavorName;
	public TMap<sbyte,sbyte> PerPlatformBuildTarget;
}
