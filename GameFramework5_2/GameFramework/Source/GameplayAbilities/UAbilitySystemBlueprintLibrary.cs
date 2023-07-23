#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AbilitySystemBlueprintLibrary.h")]
///<summary>Blueprint library for ability system. Many of these functions are useful to call from native as well</summary>
public partial class UAbilitySystemBlueprintLibrary : UBlueprintFunctionLibrary {
// AbilitySystemBlueprintLibrary
	public UObject GetAbilitySystemComponent(UObject Actor,UObject ReturnValue) { return default; }
	public void SendGameplayEventToActor(UObject Actor,FGameplayTag EventTag,FGameplayEventData Payload) {}
	public bool IsValid(FGameplayAttribute Attribute,bool ReturnValue) { return default; }
	public float GetFloatAttribute(UObject Actor,FGameplayAttribute Attribute,bool bSuccessfullyFoundAttribute,float ReturnValue) { return default; }
	public float GetFloatAttributeFromAbilitySystemComponent(UObject AbilitySystem,FGameplayAttribute Attribute,bool bSuccessfullyFoundAttribute,float ReturnValue) { return default; }
	public float GetFloatAttributeBase(UObject Actor,FGameplayAttribute Attribute,bool bSuccessfullyFoundAttribute,float ReturnValue) { return default; }
	public float GetFloatAttributeBaseFromAbilitySystemComponent(UObject AbilitySystemComponent,FGameplayAttribute Attribute,bool bSuccessfullyFoundAttribute,float ReturnValue) { return default; }
	public float EvaluateAttributeValueWithTags(UObject AbilitySystem,FGameplayAttribute Attribute,FGameplayTagContainer SourceTags,FGameplayTagContainer TargetTags,bool bSuccess,float ReturnValue) { return default; }
	public float EvaluateAttributeValueWithTagsAndBase(UObject AbilitySystem,FGameplayAttribute Attribute,FGameplayTagContainer SourceTags,FGameplayTagContainer TargetTags,float BaseValue,bool bSuccess,float ReturnValue) { return default; }
	public bool EqualEqual_GameplayAttributeGameplayAttribute(FGameplayAttribute AttributeA,FGameplayAttribute AttributeB,bool ReturnValue) { return default; }
	public bool NotEqual_GameplayAttributeGameplayAttribute(FGameplayAttribute AttributeA,FGameplayAttribute AttributeB,bool ReturnValue) { return default; }
	public sbyte GetDebugStringFromGameplayAttribute(FGameplayAttribute Attribute,sbyte ReturnValue) { return default; }
	public FGameplayAbilityTargetDataHandle AppendTargetDataHandle(FGameplayAbilityTargetDataHandle TargetHandle,FGameplayAbilityTargetDataHandle HandleToAdd,FGameplayAbilityTargetDataHandle ReturnValue) { return default; }
	public FGameplayAbilityTargetDataHandle AbilityTargetDataFromLocations(FGameplayAbilityTargetingLocationInfo SourceLocation,FGameplayAbilityTargetingLocationInfo TargetLocation,FGameplayAbilityTargetDataHandle ReturnValue) { return default; }
	public FGameplayAbilityTargetDataHandle AbilityTargetDataFromHitResult(FHitResult HitResult,FGameplayAbilityTargetDataHandle ReturnValue) { return default; }
	public int GetDataCountFromTargetData(FGameplayAbilityTargetDataHandle TargetData,int ReturnValue) { return default; }
	public FGameplayAbilityTargetDataHandle AbilityTargetDataFromActor(UObject Actor,FGameplayAbilityTargetDataHandle ReturnValue) { return default; }
	public FGameplayAbilityTargetDataHandle AbilityTargetDataFromActorArray(TArray<UObject> ActorArray,bool OneTargetPerHandle,FGameplayAbilityTargetDataHandle ReturnValue) { return default; }
	public FGameplayAbilityTargetDataHandle FilterTargetData(FGameplayAbilityTargetDataHandle TargetDataHandle,FGameplayTargetDataFilterHandle ActorFilterClass,FGameplayAbilityTargetDataHandle ReturnValue) { return default; }
	public FGameplayTargetDataFilterHandle MakeFilterHandle(FGameplayTargetDataFilter Filter,UObject FilterActor,FGameplayTargetDataFilterHandle ReturnValue) { return default; }
	public FGameplayEffectSpecHandle MakeSpecHandle(UObject InGameplayEffect,UObject InInstigator,UObject InEffectCauser,float InLevel=1.0f,FGameplayEffectSpecHandle ReturnValue) { return default; }
	public FGameplayEffectSpecHandle CloneSpecHandle(UObject InNewInstigator,UObject InEffectCauser,FGameplayEffectSpecHandle GameplayEffectSpecHandle_Clone,FGameplayEffectSpecHandle ReturnValue) { return default; }
	public TArray<UObject> GetActorsFromTargetData(FGameplayAbilityTargetDataHandle TargetData,int Index,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetAllActorsFromTargetData(FGameplayAbilityTargetDataHandle TargetData,TArray<UObject> ReturnValue) { return default; }
	public bool DoesTargetDataContainActor(FGameplayAbilityTargetDataHandle TargetData,int Index,UObject Actor,bool ReturnValue) { return default; }
	public bool TargetDataHasActor(FGameplayAbilityTargetDataHandle TargetData,int Index,bool ReturnValue) { return default; }
	public bool TargetDataHasHitResult(FGameplayAbilityTargetDataHandle HitResult,int Index,bool ReturnValue) { return default; }
	public FHitResult GetHitResultFromTargetData(FGameplayAbilityTargetDataHandle HitResult,int Index,FHitResult ReturnValue) { return default; }
	public bool TargetDataHasOrigin(FGameplayAbilityTargetDataHandle TargetData,int Index,bool ReturnValue) { return default; }
	public FTransform GetTargetDataOrigin(FGameplayAbilityTargetDataHandle TargetData,int Index,FTransform ReturnValue) { return default; }
	public bool TargetDataHasEndPoint(FGameplayAbilityTargetDataHandle TargetData,int Index,bool ReturnValue) { return default; }
	public FVector GetTargetDataEndPoint(FGameplayAbilityTargetDataHandle TargetData,int Index,FVector ReturnValue) { return default; }
	public FTransform GetTargetDataEndPointTransform(FGameplayAbilityTargetDataHandle TargetData,int Index,FTransform ReturnValue) { return default; }
	public bool EffectContextIsValid(FGameplayEffectContextHandle EffectContext,bool ReturnValue) { return default; }
	public bool EffectContextIsInstigatorLocallyControlled(FGameplayEffectContextHandle EffectContext,bool ReturnValue) { return default; }
	public FHitResult EffectContextGetHitResult(FGameplayEffectContextHandle EffectContext,FHitResult ReturnValue) { return default; }
	public bool EffectContextHasHitResult(FGameplayEffectContextHandle EffectContext,bool ReturnValue) { return default; }
	public void EffectContextAddHitResult(FGameplayEffectContextHandle EffectContext,FHitResult HitResult,bool bReset) {}
	public FVector EffectContextGetOrigin(FGameplayEffectContextHandle EffectContext,FVector ReturnValue) { return default; }
	public void EffectContextSetOrigin(FGameplayEffectContextHandle EffectContext,FVector Origin) {}
	public UObject EffectContextGetInstigatorActor(FGameplayEffectContextHandle EffectContext,UObject ReturnValue) { return default; }
	public UObject EffectContextGetOriginalInstigatorActor(FGameplayEffectContextHandle EffectContext,UObject ReturnValue) { return default; }
	public UObject EffectContextGetEffectCauser(FGameplayEffectContextHandle EffectContext,UObject ReturnValue) { return default; }
	public UObject EffectContextGetSourceObject(FGameplayEffectContextHandle EffectContext,UObject ReturnValue) { return default; }
	public bool IsInstigatorLocallyControlled(FGameplayCueParameters Parameters,bool ReturnValue) { return default; }
	public bool IsInstigatorLocallyControlledPlayer(FGameplayCueParameters Parameters,bool ReturnValue) { return default; }
	public int GetActorCount(FGameplayCueParameters Parameters,int ReturnValue) { return default; }
	public UObject GetActorByIndex(FGameplayCueParameters Parameters,int Index,UObject ReturnValue) { return default; }
	public FHitResult GetHitResult(FGameplayCueParameters Parameters,FHitResult ReturnValue) { return default; }
	public bool HasHitResult(FGameplayCueParameters Parameters,bool ReturnValue) { return default; }
	public void ForwardGameplayCueToTarget(object /*TargetCueInterface*/ TargetCueInterface,EGameplayCueEvent EventType,FGameplayCueParameters Parameters) {}
	public UObject GetInstigatorActor(FGameplayCueParameters Parameters,UObject ReturnValue) { return default; }
	public FTransform GetInstigatorTransform(FGameplayCueParameters Parameters,FTransform ReturnValue) { return default; }
	public FVector GetOrigin(FGameplayCueParameters Parameters,FVector ReturnValue) { return default; }
	public bool GetGameplayCueEndLocationAndNormal(UObject TargetActor,FGameplayCueParameters Parameters,FVector Location,FVector Normal,bool ReturnValue) { return default; }
	public bool GetGameplayCueDirection(UObject TargetActor,FGameplayCueParameters Parameters,FVector Direction,bool ReturnValue) { return default; }
	public bool DoesGameplayCueMeetTagRequirements(FGameplayCueParameters Parameters,FGameplayTagRequirements SourceTagReqs,FGameplayTagRequirements TargetTagReqs,bool ReturnValue) { return default; }
	public FGameplayCueParameters MakeGameplayCueParameters(float NormalizedMagnitude,float RawMagnitude,FGameplayEffectContextHandle EffectContext,FGameplayTag MatchedTagName,FGameplayTag OriginalTag,FGameplayTagContainer AggregatedSourceTags,FGameplayTagContainer AggregatedTargetTags,FVector Location,FVector Normal,UObject Instigator,UObject EffectCauser,UObject SourceObject,UObject PhysicalMaterial,int GameplayEffectLevel,int AbilityLevel,UObject TargetAttachComponent,bool bReplicateLocationWhenUsingMinimalRepProxy,FGameplayCueParameters ReturnValue) { return default; }
	public void BreakGameplayCueParameters(FGameplayCueParameters Parameters,float NormalizedMagnitude,float RawMagnitude,FGameplayEffectContextHandle EffectContext,FGameplayTag MatchedTagName,FGameplayTag OriginalTag,FGameplayTagContainer AggregatedSourceTags,FGameplayTagContainer AggregatedTargetTags,FVector Location,FVector Normal,UObject Instigator,UObject EffectCauser,UObject SourceObject,UObject PhysicalMaterial,int GameplayEffectLevel,int AbilityLevel,UObject TargetAttachComponent,bool bReplicateLocationWhenUsingMinimalRepProxy) {}
	public FGameplayEffectSpecHandle AssignSetByCallerMagnitude(FGameplayEffectSpecHandle SpecHandle,sbyte DataName,float Magnitude,FGameplayEffectSpecHandle ReturnValue) { return default; }
	public FGameplayEffectSpecHandle AssignTagSetByCallerMagnitude(FGameplayEffectSpecHandle SpecHandle,FGameplayTag DataTag,float Magnitude,FGameplayEffectSpecHandle ReturnValue) { return default; }
	public FGameplayEffectSpecHandle SetDuration(FGameplayEffectSpecHandle SpecHandle,float Duration,FGameplayEffectSpecHandle ReturnValue) { return default; }
	public FGameplayEffectSpecHandle AddGrantedTag(FGameplayEffectSpecHandle SpecHandle,FGameplayTag NewGameplayTag,FGameplayEffectSpecHandle ReturnValue) { return default; }
	public FGameplayEffectSpecHandle AddGrantedTags(FGameplayEffectSpecHandle SpecHandle,FGameplayTagContainer NewGameplayTags,FGameplayEffectSpecHandle ReturnValue) { return default; }
	public FGameplayEffectSpecHandle AddAssetTag(FGameplayEffectSpecHandle SpecHandle,FGameplayTag NewGameplayTag,FGameplayEffectSpecHandle ReturnValue) { return default; }
	public FGameplayEffectSpecHandle AddAssetTags(FGameplayEffectSpecHandle SpecHandle,FGameplayTagContainer NewGameplayTags,FGameplayEffectSpecHandle ReturnValue) { return default; }
	public FGameplayEffectSpecHandle AddLinkedGameplayEffectSpec(FGameplayEffectSpecHandle SpecHandle,FGameplayEffectSpecHandle LinkedGameplayEffectSpec,FGameplayEffectSpecHandle ReturnValue) { return default; }
	public FGameplayEffectSpecHandle AddLinkedGameplayEffect(FGameplayEffectSpecHandle SpecHandle,UClass LinkedGameplayEffect,FGameplayEffectSpecHandle ReturnValue) { return default; }
	public FGameplayEffectSpecHandle SetStackCount(FGameplayEffectSpecHandle SpecHandle,int StackCount,FGameplayEffectSpecHandle ReturnValue) { return default; }
	public FGameplayEffectSpecHandle SetStackCountToMax(FGameplayEffectSpecHandle SpecHandle,FGameplayEffectSpecHandle ReturnValue) { return default; }
	public FGameplayEffectContextHandle GetEffectContext(FGameplayEffectSpecHandle SpecHandle,FGameplayEffectContextHandle ReturnValue) { return default; }
	public TArray<FGameplayEffectSpecHandle> GetAllLinkedGameplayEffectSpecHandles(FGameplayEffectSpecHandle SpecHandle,TArray<FGameplayEffectSpecHandle> ReturnValue) { return default; }
	public bool AddLooseGameplayTags(UObject Actor,FGameplayTagContainer GameplayTags,bool bShouldReplicate=false,bool ReturnValue) { return default; }
	public bool RemoveLooseGameplayTags(UObject Actor,FGameplayTagContainer GameplayTags,bool bShouldReplicate=false,bool ReturnValue) { return default; }
	public float GetModifiedAttributeMagnitude(FGameplayEffectSpecHandle SpecHandle,FGameplayAttribute Attribute,float ReturnValue) { return default; }
	public int GetActiveGameplayEffectStackCount(FActiveGameplayEffectHandle ActiveHandle,int ReturnValue) { return default; }
	public int GetActiveGameplayEffectStackLimitCount(FActiveGameplayEffectHandle ActiveHandle,int ReturnValue) { return default; }
	public float GetActiveGameplayEffectStartTime(FActiveGameplayEffectHandle ActiveHandle,float ReturnValue) { return default; }
	public float GetActiveGameplayEffectExpectedEndTime(FActiveGameplayEffectHandle ActiveHandle,float ReturnValue) { return default; }
	public float GetActiveGameplayEffectTotalDuration(FActiveGameplayEffectHandle ActiveHandle,float ReturnValue) { return default; }
	public float GetActiveGameplayEffectRemainingDuration(UObject WorldContextObject,FActiveGameplayEffectHandle ActiveHandle,float ReturnValue) { return default; }
	public sbyte GetActiveGameplayEffectDebugString(FActiveGameplayEffectHandle ActiveHandle,sbyte ReturnValue) { return default; }
	public UObject GetGameplayEffectUIData(UClass EffectClass,UClass DataType,UObject ReturnValue) { return default; }
	public bool EqualEqual_ActiveGameplayEffectHandle(FActiveGameplayEffectHandle A,FActiveGameplayEffectHandle B,bool ReturnValue) { return default; }
	public bool NotEqual_ActiveGameplayEffectHandle(FActiveGameplayEffectHandle A,FActiveGameplayEffectHandle B,bool ReturnValue) { return default; }
	public UObject GetGameplayEffectFromActiveEffectHandle(FActiveGameplayEffectHandle ActiveHandle,UObject ReturnValue) { return default; }
	public UObject GetGameplayAbilityFromSpecHandle(UObject AbilitySystem,FGameplayAbilitySpecHandle AbilitySpecHandle,bool bIsInstance,UObject ReturnValue) { return default; }
	public bool EqualEqual_GameplayAbilitySpecHandle(FGameplayAbilitySpecHandle A,FGameplayAbilitySpecHandle B,bool ReturnValue) { return default; }
	public bool NotEqual_GameplayAbilitySpecHandle(FGameplayAbilitySpecHandle A,FGameplayAbilitySpecHandle B,bool ReturnValue) { return default; }
}
