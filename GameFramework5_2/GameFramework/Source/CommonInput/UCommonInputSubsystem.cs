#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonInputSubsystem.h")]
public partial class UCommonInputSubsystem : ULocalPlayerSubsystem {
// CommonInputSubsystem
	public bool IsInputMethodActive(ECommonInputType InputMethod,bool ReturnValue) { return default; }
	public ECommonInputType GetCurrentInputType(ECommonInputType ReturnValue) { return default; }
	public ECommonInputType GetDefaultInputType(ECommonInputType ReturnValue) { return default; }
	public void SetCurrentInputType(ECommonInputType NewInputType) {}
	public sbyte GetCurrentGamepadName(sbyte ReturnValue) { return default; }
	public void SetGamepadInputType(sbyte InGamepadInputType) {}
	public bool IsUsingPointerInput(bool ReturnValue) { return default; }
	public bool ShouldShowInputKeys(bool ReturnValue) { return default; }
	public void BroadcastInputMethodChanged() {}
	public FInputMethodChangedDelegate OnInputMethodChanged;
	public int NumberOfInputMethodChangesRecently;
	public double LastInputMethodChangeTime;
	public double LastTimeInputMethodThrashingBegan;
	public ECommonInputType LastInputType;
	public ECommonInputType CurrentInputType;
	public sbyte GamepadInputType;
	public TMap<sbyte,ECommonInputType> CurrentInputLocks;
	public UCommonInputActionDomainTable ActionDomainTable;
	public bool bIsGamepadSimulatedClick;
}
