#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimToTextureDataAsset.h")]
public partial class UAnimToTextureDataAsset : UPrimaryDataAsset {
// AnimToTextureDataAsset
	public TSoftObjectPtr<USkeletalMesh> SkeletalMesh;
	public int SkeletalLODIndex;
	public TSoftObjectPtr<UStaticMesh> StaticMesh;
	public int StaticLODIndex;
	public int UVChannel;
	public int MaxHeight;
	public int MaxWidth;
	public bool bEnforcePowerOfTwo;
	public EAnimToTexturePrecision Precision;
	public EAnimToTextureMode Mode;
	public TSoftObjectPtr<UTexture2D> VertexPositionTexture;
	public TSoftObjectPtr<UTexture2D> VertexNormalTexture;
	public TSoftObjectPtr<UTexture2D> BonePositionTexture;
	public TSoftObjectPtr<UTexture2D> BoneRotationTexture;
	public TSoftObjectPtr<UTexture2D> BoneWeightTexture;
	public sbyte AttachToSocket;
	public float SampleRate;
	public TArray<FAnimSequenceInfo> AnimSequences;
	public int NumFrames;
	public int VertexRowsPerFrame;
	public FVector VertexMinBBox;
	public FVector VertexSizeBBox;
	public int BoneWeightRowsPerFrame;
	public int BoneRowsPerFrame;
	public FVector BoneMinBBox;
	public FVector BoneSizeBBox;
	public TArray<FAnimInfo> Animations;
	public int GetIndexFromAnimSequence(UObject Sequence,int ReturnValue) { return default; }
	public void ResetInfo() {}
	public UObject BP_GetStaticMesh(UObject ReturnValue) { return default; }
	public UObject BP_GetSkeletalMesh(UObject ReturnValue) { return default; }
	public UObject BP_GetBonePositionTexture(UObject ReturnValue) { return default; }
	public UObject BP_GetBoneRotationTexture(UObject ReturnValue) { return default; }
	public UObject BP_GetBoneWeightTexture(UObject ReturnValue) { return default; }
}
