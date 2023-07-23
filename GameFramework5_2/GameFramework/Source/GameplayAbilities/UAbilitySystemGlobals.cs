#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AbilitySystemGlobals.h")]
///<summary>Holds global data for the ability system. Can be configured per project via config file</summary>
public partial class UAbilitySystemGlobals : UObject {
// AbilitySystemGlobals
	public FSoftClassPath AbilitySystemGlobalsClassName;
	public void ToggleIgnoreAbilitySystemCooldowns() {}
	public void ToggleIgnoreAbilitySystemCosts() {}
	public void ListPlayerAbilities() {}
	public void ServerActivatePlayerAbility(sbyte AbilityNameMatch) {}
	public void ServerEndPlayerAbility(sbyte AbilityNameMatch) {}
	public void ServerCancelPlayerAbility(sbyte AbilityNameMatch) {}
	public bool bUseDebugTargetFromHud;
	public FGameplayTag ActivateFailIsDeadTag;
	public sbyte ActivateFailIsDeadName;
	public FGameplayTag ActivateFailCooldownTag;
	public sbyte ActivateFailCooldownName;
	public FGameplayTag ActivateFailCostTag;
	public sbyte ActivateFailCostName;
	public FGameplayTag ActivateFailTagsBlockedTag;
	public sbyte ActivateFailTagsBlockedName;
	public FGameplayTag ActivateFailTagsMissingTag;
	public sbyte ActivateFailTagsMissingName;
	public FGameplayTag ActivateFailNetworkingTag;
	public sbyte ActivateFailNetworkingName;
	public int MinimalReplicationTagCountBits;
	public FNetSerializeScriptStructCache TargetDataStructCache;
	public bool bAllowGameplayModEvaluationChannels;
	public EGameplayModEvaluationChannel DefaultGameplayModEvaluationChannel;
	public sbyte GameplayModEvaluationChannelAliases;
	public FSoftObjectPath GlobalCurveTableName;
	public UCurveTable GlobalCurveTable;
	public FSoftObjectPath GlobalAttributeMetaDataTableName;
	public UDataTable GlobalAttributeMetaDataTable;
	public FSoftObjectPath GlobalAttributeSetDefaultsTableName;
	public TArray<FSoftObjectPath> GlobalAttributeSetDefaultsTableNames;
	public TArray<UCurveTable> GlobalAttributeDefaultsTables;
	public FSoftObjectPath GlobalGameplayCueManagerClass;
	public FSoftObjectPath GlobalGameplayCueManagerName;
	public TArray<sbyte> GameplayCueNotifyPaths;
	public FSoftObjectPath GameplayTagResponseTableName;
	public UGameplayTagReponseTable GameplayTagResponseTable;
	public bool PredictTargetGameplayEffects;
	public bool ReplicateActivationOwnedTags;
	public UGameplayCueManager GlobalGameplayCueManager;
}
