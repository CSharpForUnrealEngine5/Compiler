#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonAnimationTypes.h")]
///<summary>The FRotationRetargetingInfo is used to provide all of the</summary>
public partial struct FRotationRetargetingInfo {
// RotationRetargetingInfo
	public bool bEnabled;
	public FTransform Source;
	public FTransform Target;
	public ERotationComponent RotationComponent;
	public FVector TwistAxis;
	public bool bUseAbsoluteAngle;
	public float SourceMinimum;
	public float SourceMaximum;
	public float TargetMinimum;
	public float TargetMaximum;
	public EEasingFuncType EasingType;
	public FRuntimeFloatCurve CustomCurve;
	public bool bFlipEasing;
	public float EasingWeight;
	public bool bClamp;
}
