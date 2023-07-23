#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Location/ParticleModuleLocationSkelVertSurface.h")]
public partial class UParticleModuleLocationSkelVertSurface : UParticleModuleLocationBase {
// ParticleModuleLocationSkelVertSurface
	public byte SourceType;
	public FVector UniversalOffset;
	public bool bUpdatePositionEachFrame;
	public bool bOrientMeshEmitters;
	public bool bInheritBoneVelocity;
	public float InheritVelocityScale;
	public sbyte SkelMeshActorParamName;
	public USkeletalMesh EditorSkelMesh;
	public TArray<sbyte> ValidAssociatedBones;
	public bool bEnforceNormalCheck;
	public FVector NormalToCompare;
	public float NormalCheckToleranceDegrees;
	public float NormalCheckTolerance;
	public TArray<int> ValidMaterialIndices;
	public bool bInheritVertexColor;
	public bool bInheritUV;
	public uint InheritUVChannel;
}
