#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffectTypes.h")]
///<summary>Indicates what type of action happened to a specific gameplay cue tag. Sometimes you will get multiple events at once</summary>
public enum EGameplayCueEvent {
	OnActive=0,
	WhileActive=1,
	Executed=2,
	Removed=3,
}
