#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTypes.h")]
///<summary>Defines what type of trigger will activate the ability, paired to a tag</summary>
public enum EGameplayAbilityTriggerSource {
	GameplayEvent=0,
	OwnedTagAdded=1,
	OwnedTagPresent=2,
}
