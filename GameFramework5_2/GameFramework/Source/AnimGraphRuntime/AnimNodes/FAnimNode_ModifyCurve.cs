#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_ModifyCurve.h")]
///<summary>Easy way to modify curve values on a pose</summary>
public partial struct FAnimNode_ModifyCurve {
// AnimNode_ModifyCurve
	public FPoseLink SourcePose;
	public TMap<sbyte,float> CurveMap;
	public TArray<float> CurveValues;
	public TArray<sbyte> CurveNames;
	public float Alpha;
	public EModifyCurveApplyMode ApplyMode;
}
