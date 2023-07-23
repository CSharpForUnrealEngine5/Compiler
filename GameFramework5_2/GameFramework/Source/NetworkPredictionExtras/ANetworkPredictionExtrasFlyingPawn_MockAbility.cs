#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NetworkPredictionExtrasFlyingPawn.h")]
///<summary>Example subclass of ANetworkPredictionExtrasFlyingPawn that uses the MockAbility simulation</summary>
public partial class ANetworkPredictionExtrasFlyingPawn_MockAbility : ANetworkPredictionExtrasFlyingPawn {
// NetworkPredictionExtrasFlyingPawn_MockAbility
	public UObject GetMockFlyingAbilityComponent(UObject ReturnValue) { return default; }
	public ENetworkPredictionExtrasMockAbilityInputPreset AbilityInputPreset;
	public float GetStamina(float ReturnValue) { return default; }
	public float GetMaxStamina(float ReturnValue) { return default; }
}
