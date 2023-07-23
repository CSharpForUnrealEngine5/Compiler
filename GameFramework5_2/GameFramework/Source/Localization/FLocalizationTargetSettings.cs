#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LocalizationTargetTypes.h")]
public partial struct FLocalizationTargetSettings {
// LocalizationTargetSettings
	public sbyte Name;
	public FGuid Guid;
	public ELocalizationTargetConflictStatus ConflictStatus;
	public TArray<FGuid> TargetDependencies;
	public TArray<FFilePath> AdditionalManifestDependencies;
	public TArray<sbyte> RequiredModuleNames;
	public FGatherTextFromTextFilesConfiguration GatherFromTextFiles;
	public FGatherTextFromPackagesConfiguration GatherFromPackages;
	public FGatherTextFromMetaDataConfiguration GatherFromMetaData;
	public FLocalizationExportingSettings ExportSettings;
	public FLocalizationCompilationSettings CompileSettings;
	public FLocalizationImportDialogueSettings ImportDialogueSettings;
	public int NativeCultureIndex;
	public TArray<FCultureStatistics> SupportedCulturesStatistics;
}
