#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/PoseAssetFactory.h")]
public partial class UPoseAssetFactory : UFactory {
// PoseAssetFactory
	public UAnimSequence SourceAnimation;
	public TArray<sbyte> PoseNames;
	public USkeleton TargetSkeleton;
	public USkeletalMesh PreviewSkeletalMesh;
}
