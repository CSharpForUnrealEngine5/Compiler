#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Async/AbilityAsync_WaitGameplayTag.h")]
public partial class UAbilityAsync_WaitGameplayTagAdded : UAbilityAsync_WaitGameplayTag {
// AbilityAsync_WaitGameplayTagAdded
	public FAsyncWaitGameplayTagDelegate Added;
	public UObject WaitGameplayTagAddToActor(UObject TargetActor,FGameplayTag Tag,bool OnlyTriggerOnce/*=false*/) { return default; }
}
