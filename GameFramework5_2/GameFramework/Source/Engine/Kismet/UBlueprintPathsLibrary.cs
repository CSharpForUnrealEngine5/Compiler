#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/BlueprintPathsLibrary.h")]
///<summary>Function library to expose FPaths to Blueprints and Python</summary>
public partial class UBlueprintPathsLibrary : UBlueprintFunctionLibrary {
// BlueprintPathsLibrary
	public bool ShouldSaveToUserDir(bool ReturnValue) { return default; }
	public sbyte LaunchDir(sbyte ReturnValue) { return default; }
	public sbyte EngineDir(sbyte ReturnValue) { return default; }
	public sbyte EngineUserDir(sbyte ReturnValue) { return default; }
	public sbyte EngineVersionAgnosticUserDir(sbyte ReturnValue) { return default; }
	public sbyte EngineContentDir(sbyte ReturnValue) { return default; }
	public sbyte EngineConfigDir(sbyte ReturnValue) { return default; }
	public sbyte EngineIntermediateDir(sbyte ReturnValue) { return default; }
	public sbyte EngineSavedDir(sbyte ReturnValue) { return default; }
	public sbyte EnginePluginsDir(sbyte ReturnValue) { return default; }
	public sbyte EnterpriseDir(sbyte ReturnValue) { return default; }
	public sbyte EnterprisePluginsDir(sbyte ReturnValue) { return default; }
	public sbyte EnterpriseFeaturePackDir(sbyte ReturnValue) { return default; }
	public sbyte RootDir(sbyte ReturnValue) { return default; }
	public sbyte ProjectDir(sbyte ReturnValue) { return default; }
	public sbyte ProjectUserDir(sbyte ReturnValue) { return default; }
	public sbyte ProjectContentDir(sbyte ReturnValue) { return default; }
	public sbyte ProjectConfigDir(sbyte ReturnValue) { return default; }
	public sbyte ProjectSavedDir(sbyte ReturnValue) { return default; }
	public sbyte ProjectIntermediateDir(sbyte ReturnValue) { return default; }
	public sbyte ShaderWorkingDir(sbyte ReturnValue) { return default; }
	public sbyte ProjectPluginsDir(sbyte ReturnValue) { return default; }
	public sbyte ProjectModsDir(sbyte ReturnValue) { return default; }
	public bool HasProjectPersistentDownloadDir(bool ReturnValue) { return default; }
	public sbyte ProjectPersistentDownloadDir(sbyte ReturnValue) { return default; }
	public sbyte SourceConfigDir(sbyte ReturnValue) { return default; }
	public sbyte GeneratedConfigDir(sbyte ReturnValue) { return default; }
	public sbyte SandboxesDir(sbyte ReturnValue) { return default; }
	public sbyte ProfilingDir(sbyte ReturnValue) { return default; }
	public sbyte ScreenShotDir(sbyte ReturnValue) { return default; }
	public sbyte BugItDir(sbyte ReturnValue) { return default; }
	public sbyte VideoCaptureDir(sbyte ReturnValue) { return default; }
	public sbyte ProjectLogDir(sbyte ReturnValue) { return default; }
	public sbyte AutomationDir(sbyte ReturnValue) { return default; }
	public sbyte AutomationTransientDir(sbyte ReturnValue) { return default; }
	public sbyte AutomationLogDir(sbyte ReturnValue) { return default; }
	public sbyte CloudDir(sbyte ReturnValue) { return default; }
	public sbyte GameDevelopersDir(sbyte ReturnValue) { return default; }
	public sbyte GameUserDeveloperDir(sbyte ReturnValue) { return default; }
	public sbyte DiffDir(sbyte ReturnValue) { return default; }
	public TArray<sbyte> GetEngineLocalizationPaths(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetEditorLocalizationPaths(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetPropertyNameLocalizationPaths(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetToolTipLocalizationPaths(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetGameLocalizationPaths(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetRestrictedFolderNames(TArray<sbyte> ReturnValue) { return default; }
	public bool IsRestrictedPath(sbyte InPath,bool ReturnValue) { return default; }
	public sbyte GameAgnosticSavedDir(sbyte ReturnValue) { return default; }
	public sbyte EngineSourceDir(sbyte ReturnValue) { return default; }
	public sbyte GameSourceDir(sbyte ReturnValue) { return default; }
	public sbyte FeaturePackDir(sbyte ReturnValue) { return default; }
	public bool IsProjectFilePathSet(bool ReturnValue) { return default; }
	public sbyte GetProjectFilePath(sbyte ReturnValue) { return default; }
	public void SetProjectFilePath(sbyte NewGameProjectFilePath) {}
	public sbyte GetExtension(sbyte InPath,bool bIncludeDot=false,sbyte ReturnValue) { return default; }
	public sbyte GetCleanFilename(sbyte InPath,sbyte ReturnValue) { return default; }
	public sbyte GetBaseFilename(sbyte InPath,bool bRemovePath=true,sbyte ReturnValue) { return default; }
	public sbyte GetPath(sbyte InPath,sbyte ReturnValue) { return default; }
	public sbyte ChangeExtension(sbyte InPath,sbyte InNewExtension,sbyte ReturnValue) { return default; }
	public sbyte SetExtension(sbyte InPath,sbyte InNewExtension,sbyte ReturnValue) { return default; }
	public bool FileExists(sbyte InPath,bool ReturnValue) { return default; }
	public bool DirectoryExists(sbyte InPath,bool ReturnValue) { return default; }
	public bool IsDrive(sbyte InPath,bool ReturnValue) { return default; }
	public bool IsRelative(sbyte InPath,bool ReturnValue) { return default; }
	public void NormalizeFilename(sbyte InPath,sbyte OutPath) {}
	public bool IsSamePath(sbyte PathA,sbyte PathB,bool ReturnValue) { return default; }
	public void NormalizeDirectoryName(sbyte InPath,sbyte OutPath) {}
	public bool CollapseRelativeDirectories(sbyte InPath,sbyte OutPath,bool ReturnValue) { return default; }
	public void RemoveDuplicateSlashes(sbyte InPath,sbyte OutPath) {}
	public void MakeStandardFilename(sbyte InPath,sbyte OutPath) {}
	public void MakePlatformFilename(sbyte InPath,sbyte OutPath) {}
	public bool MakePathRelativeTo(sbyte InPath,sbyte InRelativeTo,sbyte OutPath,bool ReturnValue) { return default; }
	public sbyte ConvertRelativePathToFull(sbyte InPath,sbyte InBasePath=TEXT,sbyte ReturnValue) { return default; }
	public sbyte ConvertToSandboxPath(sbyte InPath,sbyte InSandboxName,sbyte ReturnValue) { return default; }
	public sbyte ConvertFromSandboxPath(sbyte InPath,sbyte InSandboxName,sbyte ReturnValue) { return default; }
	public sbyte CreateTempFilename(sbyte Path,sbyte Prefix=TEXT,sbyte Extension=TEXT,sbyte ReturnValue) { return default; }
	public sbyte GetInvalidFileSystemChars(sbyte ReturnValue) { return default; }
	public sbyte MakeValidFileName(sbyte InString,sbyte InReplacementChar=TEXT,sbyte ReturnValue) { return default; }
	public void ValidatePath(sbyte InPath,bool bDidSucceed,sbyte OutReason) {}
	public void Split(sbyte InPath,sbyte PathPart,sbyte FilenamePart,sbyte ExtensionPart) {}
	public sbyte GetRelativePathToRoot(sbyte ReturnValue) { return default; }
	public sbyte Combine(TArray<sbyte> InPaths,sbyte ReturnValue) { return default; }
}
