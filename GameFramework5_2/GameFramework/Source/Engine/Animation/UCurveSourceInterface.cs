#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/CurveSourceInterface.h")]
public partial class UCurveSourceInterface : UInterface {
// CurveSourceInterface
	public sbyte GetBindingName(sbyte ReturnValue) { return default; }
	public float GetCurveValue(sbyte CurveName,float ReturnValue) { return default; }
	public void GetCurves(TArray<FNamedCurveValue> OutValues) {}
}
