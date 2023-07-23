#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagsSettings.h")]
///<summary>Class for importing GameplayTags directly from a config file.</summary>
public partial class UGameplayTagsSettings : UGameplayTagsList {
// GameplayTagsSettings
	public bool ImportTagsFromConfig;
	public bool WarnOnInvalidTags;
	public bool ClearInvalidTags;
	public bool AllowEditorTagUnloading;
	public bool AllowGameTagUnloading;
	public bool FastReplication;
	public sbyte InvalidTagCharacters;
	public TArray<FGameplayTagCategoryRemap> CategoryRemapping;
	public TArray<FSoftObjectPath> GameplayTagTableList;
	public TArray<FGameplayTagRedirect> GameplayTagRedirects;
	public TArray<sbyte> CommonlyReplicatedTags;
	public int NumBitsForContainerSize;
	public int NetIndexFirstBitSegment;
	public TArray<FRestrictedConfigInfo> RestrictedConfigFiles;
	public sbyte RestrictedTagList;
}
