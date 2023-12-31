#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Async/AbilityAsync_WaitGameplayEffectApplied.h")]
///<summary>This action listens for specific gameplay effect applications based off specified tags.</summary>
public partial class UAbilityAsync_WaitGameplayEffectApplied : UAbilityAsync {
// AbilityAsync_WaitGameplayEffectApplied
	public UObject WaitGameplayEffectAppliedToActor(UObject TargetActor,FGameplayTargetDataFilterHandle SourceFilter,FGameplayTagRequirements SourceTagRequirements,FGameplayTagRequirements TargetTagRequirements,bool TriggerOnce/*=false*/,bool ListenForPeriodicEffect/*=false*/) { return default; }
	public void FOnAppliedDelegate(UObject Source,FGameplayEffectSpecHandle SpecHandle,FActiveGameplayEffectHandle ActiveHandle) {}
	public FOnAppliedDelegate OnApplied;
}
