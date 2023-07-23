#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicsAsset.h")]
///<summary>PhysicsAsset contains a set of rigid bodies and constraints that make up a single ragdoll.</summary>
public partial class UPhysicsAsset : UObject {
// PhysicsAsset
	public USkeletalMesh DefaultSkelMesh_DEPRECATED;
	public TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh;
	public TArray<sbyte> PhysicalAnimationProfiles;
	public TArray<sbyte> ConstraintProfiles;
	public sbyte CurrentPhysicalAnimationProfileName;
	public sbyte CurrentConstraintProfileName;
	public TArray<int> BoundsBodies;
	public TArray<USkeletalBodySetup> SkeletalBodySetups;
	public TArray<UPhysicsConstraintTemplate> ConstraintSetup;
	public FPhysicsAssetSolverSettings SolverSettings;
	public FSolverIterations SolverIterations;
	public EPhysicsAssetSolverType SolverType;
	public bool bNotForDedicatedServer;
	public UThumbnailInfo ThumbnailInfo;
	public FConstraintInstanceAccessor GetConstraintByName(sbyte ConstraintName,FConstraintInstanceAccessor ReturnValue) { return default; }
	public FConstraintInstanceAccessor GetConstraintByBoneNames(sbyte Bone1Name,sbyte Bone2Name,FConstraintInstanceAccessor ReturnValue) { return default; }
	public void GetConstraints(bool bIncludesTerminated,TArray<FConstraintInstanceAccessor> OutConstraints) {}
	public TArray<UBodySetup> BodySetup_DEPRECATED;
}
