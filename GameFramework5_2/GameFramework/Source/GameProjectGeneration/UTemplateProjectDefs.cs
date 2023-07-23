#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TemplateProjectDefs.h")]
public partial class UTemplateProjectDefs : UObject {
// TemplateProjectDefs
	public TArray<FLocalizedTemplateString> LocalizedDisplayNames;
	public TArray<FLocalizedTemplateString> LocalizedDescriptions;
	public TArray<sbyte> FoldersToIgnore;
	public TArray<sbyte> FilesToIgnore;
	public TArray<FTemplateFolderRename> FolderRenames;
	public TArray<FTemplateReplacement> FilenameReplacements;
	public TArray<FTemplateReplacement> ReplacementsInFiles;
	public sbyte SortKey;
	public TArray<sbyte> Categories;
	public sbyte ClassTypes;
	public sbyte AssetTypes;
	public bool bAllowProjectCreation;
	public bool bIsEnterprise;
	public bool bIsBlank;
	public bool bThumbnailAsIcon;
	public TArray<ETemplateSetting> HiddenSettings;
	public TArray<sbyte> PacksToInclude;
	public EFeaturePackDetailLevel EditDetailLevelPreference;
	public TArray<FFeaturePackLevelSet> SharedContentPacks;
	public sbyte StarterContent;
}
