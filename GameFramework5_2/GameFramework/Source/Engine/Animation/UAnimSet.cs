#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimSet.h")]
public partial class UAnimSet : UObject {
// AnimSet
	public bool bAnimRotationOnly;
	public TArray<sbyte> TrackBoneNames;
	public TArray<UAnimSequence> Sequences;
	public TArray<FAnimSetMeshLinkup> LinkupCache;
	public TArray<byte> BoneUseAnimTranslation;
	public TArray<byte> ForceUseMeshTranslation;
	public TArray<sbyte> UseTranslationBoneNames;
	public TArray<sbyte> ForceMeshTranslationBoneNames;
	public sbyte PreviewSkelMeshName;
	public sbyte BestRatioSkelMeshName;
}
