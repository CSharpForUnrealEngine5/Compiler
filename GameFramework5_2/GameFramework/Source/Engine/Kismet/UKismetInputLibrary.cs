#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetInputLibrary.h")]
public partial class UKismetInputLibrary : UBlueprintFunctionLibrary {
// KismetInputLibrary
	public void CalibrateTilt() {}
	public bool EqualEqual_KeyKey(FKey A,FKey B,bool ReturnValue) { return default; }
	public bool EqualEqual_InputChordInputChord(FInputChord A,FInputChord B,bool ReturnValue) { return default; }
	public bool Key_IsModifierKey(FKey Key,bool ReturnValue) { return default; }
	public bool Key_IsGamepadKey(FKey Key,bool ReturnValue) { return default; }
	public bool Key_IsMouseButton(FKey Key,bool ReturnValue) { return default; }
	public bool Key_IsKeyboardKey(FKey Key,bool ReturnValue) { return default; }
	public bool Key_IsVectorAxis(FKey Key,bool ReturnValue) { return default; }
	public bool Key_IsAxis1D(FKey Key,bool ReturnValue) { return default; }
	public bool Key_IsAxis2D(FKey Key,bool ReturnValue) { return default; }
	public bool Key_IsAxis3D(FKey Key,bool ReturnValue) { return default; }
	public bool Key_IsButtonAxis(FKey Key,bool ReturnValue) { return default; }
	public bool Key_IsAnalog(FKey Key,bool ReturnValue) { return default; }
	public bool Key_IsDigital(FKey Key,bool ReturnValue) { return default; }
	public bool Key_IsValid(FKey Key,bool ReturnValue) { return default; }
	public EUINavigationAction Key_GetNavigationAction(FKey InKey,EUINavigationAction ReturnValue) { return default; }
	public EUINavigationAction Key_GetNavigationActionFromKey(FKeyEvent InKeyEvent,EUINavigationAction ReturnValue) { return default; }
	public EUINavigation Key_GetNavigationDirectionFromKey(FKeyEvent InKeyEvent,EUINavigation ReturnValue) { return default; }
	public EUINavigation Key_GetNavigationDirectionFromAnalog(FAnalogInputEvent InAnalogEvent,EUINavigation ReturnValue) { return default; }
	public sbyte Key_GetDisplayName(FKey Key,bool bLongDisplayName=true,sbyte ReturnValue) { return default; }
	public bool InputEvent_IsRepeat(FInputEvent Input,bool ReturnValue) { return default; }
	public bool InputEvent_IsShiftDown(FInputEvent Input,bool ReturnValue) { return default; }
	public bool InputEvent_IsLeftShiftDown(FInputEvent Input,bool ReturnValue) { return default; }
	public bool InputEvent_IsRightShiftDown(FInputEvent Input,bool ReturnValue) { return default; }
	public bool InputEvent_IsControlDown(FInputEvent Input,bool ReturnValue) { return default; }
	public bool InputEvent_IsLeftControlDown(FInputEvent Input,bool ReturnValue) { return default; }
	public bool InputEvent_IsRightControlDown(FInputEvent Input,bool ReturnValue) { return default; }
	public bool InputEvent_IsAltDown(FInputEvent Input,bool ReturnValue) { return default; }
	public bool InputEvent_IsLeftAltDown(FInputEvent Input,bool ReturnValue) { return default; }
	public bool InputEvent_IsRightAltDown(FInputEvent Input,bool ReturnValue) { return default; }
	public bool InputEvent_IsCommandDown(FInputEvent Input,bool ReturnValue) { return default; }
	public bool InputEvent_IsLeftCommandDown(FInputEvent Input,bool ReturnValue) { return default; }
	public bool InputEvent_IsRightCommandDown(FInputEvent Input,bool ReturnValue) { return default; }
	public bool ModifierKeysState_IsShiftDown(FSlateModifierKeysState KeysState,bool ReturnValue) { return default; }
	public bool ModifierKeysState_IsControlDown(FSlateModifierKeysState KeysState,bool ReturnValue) { return default; }
	public bool ModifierKeysState_IsAltDown(FSlateModifierKeysState KeysState,bool ReturnValue) { return default; }
	public bool ModifierKeysState_IsCommandDown(FSlateModifierKeysState KeysState,bool ReturnValue) { return default; }
	public FSlateModifierKeysState GetModifierKeysState(FSlateModifierKeysState ReturnValue) { return default; }
	public sbyte InputChord_GetDisplayName(FInputChord Key,sbyte ReturnValue) { return default; }
	public FKey GetKey(FKeyEvent Input,FKey ReturnValue) { return default; }
	public int GetUserIndex(FKeyEvent Input,int ReturnValue) { return default; }
	public float GetAnalogValue(FAnalogInputEvent Input,float ReturnValue) { return default; }
	public FVector2D PointerEvent_GetScreenSpacePosition(FPointerEvent Input,FVector2D ReturnValue) { return default; }
	public FVector2D PointerEvent_GetLastScreenSpacePosition(FPointerEvent Input,FVector2D ReturnValue) { return default; }
	public FVector2D PointerEvent_GetCursorDelta(FPointerEvent Input,FVector2D ReturnValue) { return default; }
	public bool PointerEvent_IsMouseButtonDown(FPointerEvent Input,FKey MouseButton,bool ReturnValue) { return default; }
	public FKey PointerEvent_GetEffectingButton(FPointerEvent Input,FKey ReturnValue) { return default; }
	public float PointerEvent_GetWheelDelta(FPointerEvent Input,float ReturnValue) { return default; }
	public int PointerEvent_GetUserIndex(FPointerEvent Input,int ReturnValue) { return default; }
	public int PointerEvent_GetPointerIndex(FPointerEvent Input,int ReturnValue) { return default; }
	public int PointerEvent_GetTouchpadIndex(FPointerEvent Input,int ReturnValue) { return default; }
	public bool PointerEvent_IsTouchEvent(FPointerEvent Input,bool ReturnValue) { return default; }
	public ESlateGesture PointerEvent_GetGestureType(FPointerEvent Input,ESlateGesture ReturnValue) { return default; }
	public FVector2D PointerEvent_GetGestureDelta(FPointerEvent Input,FVector2D ReturnValue) { return default; }
}
