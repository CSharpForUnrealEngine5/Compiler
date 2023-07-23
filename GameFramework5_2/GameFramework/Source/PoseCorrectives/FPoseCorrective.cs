#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseCorrectivesAsset.h")]
public partial struct FPoseCorrective {
// PoseCorrective
	public TArray<FTransform> PoseLocal;
	public TSet<int> DriverBoneIndices;
	public TArray<float> CurveData;
	public TSet<int> DriverCurveIndices;
	public TArray<FTransform> CorrectivePoseLocal;
	public TSet<int> CorrectiveBoneIndices;
	public TArray<float> CorrectiveCurvesDelta;
	public TSet<int> CorrectiveCurveIndices;
	public sbyte GroupName;
}
