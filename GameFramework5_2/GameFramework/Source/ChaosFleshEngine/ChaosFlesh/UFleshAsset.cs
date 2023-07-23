#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosFlesh/FleshAsset.h")]
///<summary>UFleshAsset (UObject)</summary>
public partial class UFleshAsset : UObject {
// FleshAsset
	public UDataflow DataflowAsset;
	public sbyte DataflowTerminal;
	public TArray<FStringValuePair> Overrides;
	public USkeletalMesh SkeletalMesh;
	public USkeleton Skeleton;
	public USkeletalMesh TargetDeformationSkeleton;
	public UStaticMesh StaticMesh;
	public sbyte TargetSkeletalMesh;
	public bool bRenderInEditor;
	public UThumbnailInfo ThumbnailInfo;
}
