#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/PlayerInput.h")]
///<summary>Object within PlayerController that processes player input.</summary>
public partial class UPlayerInput : UObject {
// PlayerInput
	public TArray<FKeyBind> DebugExecBindings;
	public TArray<sbyte> InvertedAxis;
	public void SetMouseSensitivity(float Sensitivity) {}
	public void SetBind(sbyte BindName,sbyte Command) {}
	public void InvertAxisKey(FKey AxisKey) {}
	public void InvertAxis(sbyte AxisName) {}
	public void ClearSmoothing() {}
	public UObject GetOuterAPlayerController(UObject ReturnValue) { return default; }
}
