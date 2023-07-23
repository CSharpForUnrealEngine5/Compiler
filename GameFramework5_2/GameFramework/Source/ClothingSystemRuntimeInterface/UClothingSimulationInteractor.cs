#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ClothingSimulationInteractor.h")]
///<summary>If a clothing simulation is able to be interacted with at runtime then a derived</summary>
public partial class UClothingSimulationInteractor : UObject {
// ClothingSimulationInteractor
	public void PhysicsAssetUpdated() {}
	public void ClothConfigUpdated() {}
	public void SetAnimDriveSpringStiffness(float InStiffness) {}
	public void EnableGravityOverride(FVector InVector) {}
	public void DisableGravityOverride() {}
	public void SetNumIterations(int NumIterations=1) {}
	public void SetMaxNumIterations(int MaxNumIterations=10) {}
	public void SetNumSubsteps(int NumSubsteps=1) {}
	public int GetNumCloths(int ReturnValue) { return default; }
	public int GetNumKinematicParticles(int ReturnValue) { return default; }
	public int GetNumDynamicParticles(int ReturnValue) { return default; }
	public int GetNumIterations(int ReturnValue) { return default; }
	public int GetNumSubsteps(int ReturnValue) { return default; }
	public float GetSimulationTime(float ReturnValue) { return default; }
	public UObject GetClothingInteractor(sbyte ClothingAssetName,UObject ReturnValue) { return default; }
	public TMap<sbyte,UClothingInteractor> ClothingInteractors;
}
