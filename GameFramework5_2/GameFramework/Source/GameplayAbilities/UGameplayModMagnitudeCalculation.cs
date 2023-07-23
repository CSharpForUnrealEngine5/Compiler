#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayModMagnitudeCalculation.h")]
///<summary>Class used to perform custom gameplay effect modifier calculations, either via blueprint or native code</summary>
public partial class UGameplayModMagnitudeCalculation : UGameplayEffectCalculation {
// GameplayModMagnitudeCalculation
	public float CalculateBaseMagnitude(FGameplayEffectSpec Spec,float ReturnValue) { return default; }
	public bool bAllowNonNetAuthorityDependencyRegistration;
	public float K2_GetCapturedAttributeMagnitude(FGameplayEffectSpec EffectSpec,FGameplayAttribute Attribute,FGameplayTagContainer SourceTags,FGameplayTagContainer TargetTags,float ReturnValue) { return default; }
	public float GetSetByCallerMagnitudeByTag(FGameplayEffectSpec EffectSpec,FGameplayTag Tag,float ReturnValue) { return default; }
	public float GetSetByCallerMagnitudeByName(FGameplayEffectSpec EffectSpec,sbyte MagnitudeName,float ReturnValue) { return default; }
	public FGameplayTagContainer GetSourceAggregatedTags(FGameplayEffectSpec EffectSpec,FGameplayTagContainer ReturnValue) { return default; }
	public FGameplayTagContainer GetSourceActorTags(FGameplayEffectSpec EffectSpec,FGameplayTagContainer ReturnValue) { return default; }
	public FGameplayTagContainer GetSourceSpecTags(FGameplayEffectSpec EffectSpec,FGameplayTagContainer ReturnValue) { return default; }
	public FGameplayTagContainer GetTargetAggregatedTags(FGameplayEffectSpec EffectSpec,FGameplayTagContainer ReturnValue) { return default; }
	public FGameplayTagContainer GetTargetActorTags(FGameplayEffectSpec EffectSpec,FGameplayTagContainer ReturnValue) { return default; }
	public FGameplayTagContainer GetTargetSpecTags(FGameplayEffectSpec EffectSpec,FGameplayTagContainer ReturnValue) { return default; }
}
