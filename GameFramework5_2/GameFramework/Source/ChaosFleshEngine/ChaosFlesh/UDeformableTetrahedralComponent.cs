#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosFlesh/ChaosDeformableTetrahedralComponent.h")]
///<summary>UDeformableTetrahedralComponent</summary>
public partial class UDeformableTetrahedralComponent : UDeformablePhysicsComponent {
// DeformableTetrahedralComponent
	public TArray<FVector> GetSkeletalMeshBindingPositions(UObject InSkeletalMesh,TArray<FVector> ReturnValue) { return default; }
	public TArray<FVector> GetSkeletalMeshEmbeddedPositions(ChaosDeformableBindingOption Format,FTransform TargetDeformationSkeletonOffset,sbyte TargetBone="",float SimulationBlendWeight=1.f,TArray<FVector> ReturnValue) { return default; }
	public FFleshSimulationSpaceGroup SimulationSpace;
	public FBodyForcesGroup BodyForces;
	public float MassMultiplier;
	public UProceduralMeshComponent Mesh;
	public UFleshAsset RestCollection;
	public UFleshDynamicAsset DynamicCollection;
	public USimulationAsset SimulationCollection;
	public TArray<sbyte> GetSimSpaceBoneNameOptions(TArray<sbyte> ReturnValue) { return default; }
}
