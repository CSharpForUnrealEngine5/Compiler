#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Validation/ControlRigNumericalValidationPass.h")]
///<summary>Used to perform a numerical comparison of the poses</summary>
public partial class UControlRigNumericalValidationPass : UControlRigValidationPass {
// ControlRigNumericalValidationPass
	public bool bCheckControls;
	public bool bCheckBones;
	public bool bCheckCurves;
	public float TranslationPrecision;
	public float RotationPrecision;
	public float ScalePrecision;
	public float CurvePrecision;
	public sbyte EventNameA;
	public sbyte EventNameB;
	public FRigPose Pose;
}
