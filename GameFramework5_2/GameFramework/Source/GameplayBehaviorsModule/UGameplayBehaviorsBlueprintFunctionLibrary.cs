#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayBehaviorsBlueprintFunctionLibrary.h")]
public partial class UGameplayBehaviorsBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// GameplayBehaviorsBlueprintFunctionLibrary
	public FGameplayTagContainer GetBlackboardValueAsGameplayTag(UObject NodeOwner,FBlackboardKeySelector Key,FGameplayTagContainer ReturnValue) { return default; }
	public void SetBlackboardValueAsGameplayTag(UObject NodeOwner,FBlackboardKeySelector Key,FGameplayTagContainer Value) {}
	public void AddGameplayTagFilterToBlackboardKeySelector(FBlackboardKeySelector InSelector,UObject Owner,sbyte PropertyName) {}
	public FGameplayTagContainer GetBlackboardValueAsGameplayTagFromBlackboardComp(UObject BlackboardComp,sbyte KeyName,FGameplayTagContainer ReturnValue) { return default; }
	public void SetValueAsGameplayTagForBlackboardComp(UObject BlackboardComp,sbyte KeyName,FGameplayTagContainer GameplayTagValue) {}
}
