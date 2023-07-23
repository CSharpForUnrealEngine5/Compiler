#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintGameplayTagLibrary.h")]
public partial class UBlueprintGameplayTagLibrary : UBlueprintFunctionLibrary {
// BlueprintGameplayTagLibrary
	public bool MatchesTag(FGameplayTag TagOne,FGameplayTag TagTwo,bool bExactMatch,bool ReturnValue) { return default; }
	public bool MatchesAnyTags(FGameplayTag TagOne,FGameplayTagContainer OtherContainer,bool bExactMatch,bool ReturnValue) { return default; }
	public bool EqualEqual_GameplayTag(FGameplayTag A,FGameplayTag B,bool ReturnValue) { return default; }
	public bool NotEqual_GameplayTag(FGameplayTag A,FGameplayTag B,bool ReturnValue) { return default; }
	public bool IsGameplayTagValid(FGameplayTag GameplayTag,bool ReturnValue) { return default; }
	public sbyte GetTagName(FGameplayTag GameplayTag,sbyte ReturnValue) { return default; }
	public FGameplayTag MakeLiteralGameplayTag(FGameplayTag Value,FGameplayTag ReturnValue) { return default; }
	public int GetNumGameplayTagsInContainer(FGameplayTagContainer TagContainer,int ReturnValue) { return default; }
	public bool HasTag(FGameplayTagContainer TagContainer,FGameplayTag Tag,bool bExactMatch,bool ReturnValue) { return default; }
	public bool HasAnyTags(FGameplayTagContainer TagContainer,FGameplayTagContainer OtherContainer,bool bExactMatch,bool ReturnValue) { return default; }
	public bool HasAllTags(FGameplayTagContainer TagContainer,FGameplayTagContainer OtherContainer,bool bExactMatch,bool ReturnValue) { return default; }
	public bool IsTagQueryEmpty(FGameplayTagQuery TagQuery,bool ReturnValue) { return default; }
	public bool DoesContainerMatchTagQuery(FGameplayTagContainer TagContainer,FGameplayTagQuery TagQuery,bool ReturnValue) { return default; }
	public void GetAllActorsOfClassMatchingTagQuery(UObject WorldContextObject,UClass ActorClass,FGameplayTagQuery GameplayTagQuery,TArray<UObject> OutActors) {}
	public void AddGameplayTag(FGameplayTagContainer TagContainer,FGameplayTag Tag) {}
	public bool RemoveGameplayTag(FGameplayTagContainer TagContainer,FGameplayTag Tag,bool ReturnValue) { return default; }
	public void AppendGameplayTagContainers(FGameplayTagContainer InOutTagContainer,FGameplayTagContainer InTagContainer) {}
	public bool EqualEqual_GameplayTagContainer(FGameplayTagContainer A,FGameplayTagContainer B,bool ReturnValue) { return default; }
	public bool NotEqual_GameplayTagContainer(FGameplayTagContainer A,FGameplayTagContainer B,bool ReturnValue) { return default; }
	public FGameplayTagContainer MakeLiteralGameplayTagContainer(FGameplayTagContainer Value,FGameplayTagContainer ReturnValue) { return default; }
	public FGameplayTagContainer MakeGameplayTagContainerFromArray(TArray<FGameplayTag> GameplayTags,FGameplayTagContainer ReturnValue) { return default; }
	public FGameplayTagContainer MakeGameplayTagContainerFromTag(FGameplayTag SingleTag,FGameplayTagContainer ReturnValue) { return default; }
	public void BreakGameplayTagContainer(FGameplayTagContainer GameplayTagContainer,TArray<FGameplayTag> GameplayTags) {}
	public FGameplayTagQuery MakeGameplayTagQuery(FGameplayTagQuery TagQuery,FGameplayTagQuery ReturnValue) { return default; }
	public bool HasAllMatchingGameplayTags(object /*TagContainerInterface*/ TagContainerInterface,FGameplayTagContainer OtherContainer,bool ReturnValue) { return default; }
	public bool DoesTagAssetInterfaceHaveTag(object /*TagContainerInterface*/ TagContainerInterface,FGameplayTag Tag,bool ReturnValue) { return default; }
	public bool NotEqual_TagTag(FGameplayTag A,sbyte B,bool ReturnValue) { return default; }
	public bool NotEqual_TagContainerTagContainer(FGameplayTagContainer A,sbyte B,bool ReturnValue) { return default; }
	public sbyte GetDebugStringFromGameplayTagContainer(FGameplayTagContainer TagContainer,sbyte ReturnValue) { return default; }
	public sbyte GetDebugStringFromGameplayTag(FGameplayTag GameplayTag,sbyte ReturnValue) { return default; }
}
