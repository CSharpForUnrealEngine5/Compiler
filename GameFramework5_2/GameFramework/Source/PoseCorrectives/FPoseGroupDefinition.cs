#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseCorrectivesAsset.h")]
///<summary>Predefines what bones/curves are used by the pose in the rbf/algorithm</summary>
public partial struct FPoseGroupDefinition {
// PoseGroupDefinition
	public TArray<sbyte> DriverBones;
	public TArray<sbyte> DriverCurves;
	public TArray<sbyte> CorrectiveBones;
	public TArray<sbyte> CorrectiveCurves;
}
