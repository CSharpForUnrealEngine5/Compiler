#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnhancedInputLibrary.h")]
public partial class UEnhancedInputLibrary : UBlueprintFunctionLibrary {
// EnhancedInputLibrary
	public void RequestRebuildControlMappingsUsingContext(UObject Context,bool bForceImmediately=false) {}
	public void BreakInputActionValue(FInputActionValue InActionValue,double X,double Y,double Z,EInputActionValueType Type) {}
	public FInputActionValue MakeInputActionValueOfType(double X,double Y,double Z,EInputActionValueType ValueType,FInputActionValue ReturnValue) { return default; }
	public FInputActionValue MakeInputActionValue(double X,double Y,double Z,FInputActionValue MatchValueType,FInputActionValue ReturnValue) { return default; }
	public UObject GetPlayerMappableKeySettings(FEnhancedActionKeyMapping ActionKeyMapping,UObject ReturnValue) { return default; }
	public sbyte GetMappingName(FEnhancedActionKeyMapping ActionKeyMapping,sbyte ReturnValue) { return default; }
	public bool IsActionKeyMappingPlayerMappable(FEnhancedActionKeyMapping ActionKeyMapping,bool ReturnValue) { return default; }
	public FInputActionValue GetBoundActionValue(UObject Actor,UObject Action,FInputActionValue ReturnValue) { return default; }
	public bool Conv_InputActionValueToBool(FInputActionValue InValue,bool ReturnValue) { return default; }
	public double Conv_InputActionValueToAxis1D(FInputActionValue InValue,double ReturnValue) { return default; }
	public FVector2D Conv_InputActionValueToAxis2D(FInputActionValue InValue,FVector2D ReturnValue) { return default; }
	public FVector Conv_InputActionValueToAxis3D(FInputActionValue ActionValue,FVector ReturnValue) { return default; }
	public sbyte Conv_InputActionValueToString(FInputActionValue ActionValue,sbyte ReturnValue) { return default; }
	public FPlayerMappableKeySlot GetFirstPlayerMappableKeySlot(FPlayerMappableKeySlot ReturnValue) { return default; }
	public FPlayerMappableKeySlot GetSecondPlayerMappableKeySlot(FPlayerMappableKeySlot ReturnValue) { return default; }
	public FPlayerMappableKeySlot GetThirdPlayerMappableKeySlot(FPlayerMappableKeySlot ReturnValue) { return default; }
	public FPlayerMappableKeySlot GetFourthPlayerMappableKeySlot(FPlayerMappableKeySlot ReturnValue) { return default; }
}
