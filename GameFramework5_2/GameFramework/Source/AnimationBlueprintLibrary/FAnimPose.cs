#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimPose.h")]
///<summary>Script friendly representation of an evaluated animation bone pose</summary>
public partial struct FAnimPose {
// AnimPose
	public TArray<sbyte> BoneNames;
	public TArray<int> BoneIndices;
	public TArray<int> ParentBoneIndices;
	public TArray<FTransform> LocalSpacePoses;
	public TArray<FTransform> WorldSpacePoses;
	public TArray<FTransform> RefLocalSpacePoses;
	public TArray<FTransform> RefWorldSpacePoses;
	public TArray<sbyte> CurveNames;
	public TArray<float> CurveValues;
}
