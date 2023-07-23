#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/WidgetBlueprintLibrary.h")]
public partial class UWidgetBlueprintLibrary : UBlueprintFunctionLibrary {
// WidgetBlueprintLibrary
	public UObject Create(UObject WorldContextObject,UClass WidgetType,UObject OwningPlayer,UObject ReturnValue) { return default; }
	public UObject CreateDragDropOperation(UClass OperationClass,UObject ReturnValue) { return default; }
	public void SetInputMode_UIOnlyEx(UObject PlayerController,UObject InWidgetToFocus=nullptr,EMouseLockMode InMouseLockMode=EMouseLockMode,bool bFlushInput=false) {}
	public void SetInputMode_GameAndUIEx(UObject PlayerController,UObject InWidgetToFocus=nullptr,EMouseLockMode InMouseLockMode=EMouseLockMode,bool bHideCursorDuringCapture=true,bool bFlushInput=false) {}
	public void SetInputMode_GameOnly(UObject PlayerController,bool bFlushInput=false) {}
	public void SetFocusToGameViewport() {}
	public void DrawBox(FPaintContext Context,FVector2D Position,FVector2D Size,UObject Brush,FLinearColor Tint=FLinearColor) {}
	public void DrawSpline(FPaintContext Context,FVector2D Start,FVector2D StartDir,FVector2D End,FVector2D EndDir,FLinearColor Tint=FLinearColor,float Thickness=1.0f) {}
	public void DrawLine(FPaintContext Context,FVector2D PositionA,FVector2D PositionB,FLinearColor Tint=FLinearColor,bool bAntiAlias=true,float Thickness=1.0f) {}
	public void DrawLines(FPaintContext Context,TArray<FVector2D> Points,FLinearColor Tint=FLinearColor,bool bAntiAlias=true,float Thickness=1.0f) {}
	public void DrawText(FPaintContext Context,sbyte InString,FVector2D Position,FLinearColor Tint=FLinearColor) {}
	public void DrawTextFormatted(FPaintContext Context,sbyte Text,FVector2D Position,UObject Font,int FontSize=16,sbyte FontTypeFace=FName,FLinearColor Tint=FLinearColor) {}
	public FEventReply Handled(FEventReply ReturnValue) { return default; }
	public FEventReply Unhandled(FEventReply ReturnValue) { return default; }
	public FEventReply CaptureMouse(FEventReply Reply,UObject CapturingWidget,FEventReply ReturnValue) { return default; }
	public FEventReply ReleaseMouseCapture(FEventReply Reply,FEventReply ReturnValue) { return default; }
	public FEventReply LockMouse(FEventReply Reply,UObject CapturingWidget,FEventReply ReturnValue) { return default; }
	public FEventReply UnlockMouse(FEventReply Reply,FEventReply ReturnValue) { return default; }
	public FEventReply SetUserFocus(FEventReply Reply,UObject FocusWidget,bool bInAllUsers=false,FEventReply ReturnValue) { return default; }
	public FEventReply CaptureJoystick(FEventReply Reply,UObject CapturingWidget,bool bInAllJoysticks=false,FEventReply ReturnValue) { return default; }
	public FEventReply ClearUserFocus(FEventReply Reply,bool bInAllUsers=false,FEventReply ReturnValue) { return default; }
	public FEventReply ReleaseJoystickCapture(FEventReply Reply,bool bInAllJoysticks=false,FEventReply ReturnValue) { return default; }
	public FEventReply SetMousePosition(FEventReply Reply,FVector2D NewMousePosition,FEventReply ReturnValue) { return default; }
	public FEventReply DetectDrag(FEventReply Reply,UObject WidgetDetectingDrag,FKey DragKey,FEventReply ReturnValue) { return default; }
	public FEventReply DetectDragIfPressed(FPointerEvent PointerEvent,UObject WidgetDetectingDrag,FKey DragKey,FEventReply ReturnValue) { return default; }
	public FEventReply EndDragDrop(FEventReply Reply,FEventReply ReturnValue) { return default; }
	public bool IsDragDropping(bool ReturnValue) { return default; }
	public UObject GetDragDroppingContent(UObject ReturnValue) { return default; }
	public void CancelDragDrop() {}
	public FSlateBrush MakeBrushFromAsset(UObject BrushAsset,FSlateBrush ReturnValue) { return default; }
	public FSlateBrush MakeBrushFromTexture(UObject Texture,int Width=0,int Height=0,FSlateBrush ReturnValue) { return default; }
	public FSlateBrush MakeBrushFromMaterial(UObject Material,int Width=32,int Height=32,FSlateBrush ReturnValue) { return default; }
	public UObject GetBrushResource(FSlateBrush Brush,UObject ReturnValue) { return default; }
	public UObject GetBrushResourceAsTexture2D(FSlateBrush Brush,UObject ReturnValue) { return default; }
	public UObject GetBrushResourceAsMaterial(FSlateBrush Brush,UObject ReturnValue) { return default; }
	public void SetBrushResourceToTexture(FSlateBrush Brush,UObject Texture) {}
	public void SetBrushResourceToMaterial(FSlateBrush Brush,UObject Material) {}
	public FSlateBrush NoResourceBrush(FSlateBrush ReturnValue) { return default; }
	public UObject GetDynamicMaterial(FSlateBrush Brush,UObject ReturnValue) { return default; }
	public void DismissAllMenus() {}
	public void GetAllWidgetsOfClass(UObject WorldContextObject,TArray<UObject> FoundWidgets,UClass WidgetClass,bool TopLevelOnly=true) {}
	public void GetAllWidgetsWithInterface(UObject WorldContextObject,TArray<UObject> FoundWidgets,UClass Interface,bool TopLevelOnly) {}
	public FInputEvent GetInputEventFromKeyEvent(FKeyEvent Event,FInputEvent ReturnValue) { return default; }
	public FKeyEvent GetKeyEventFromAnalogInputEvent(FAnalogInputEvent Event,FKeyEvent ReturnValue) { return default; }
	public FInputEvent GetInputEventFromCharacterEvent(FCharacterEvent Event,FInputEvent ReturnValue) { return default; }
	public FInputEvent GetInputEventFromPointerEvent(FPointerEvent Event,FInputEvent ReturnValue) { return default; }
	public FInputEvent GetInputEventFromNavigationEvent(FNavigationEvent Event,FInputEvent ReturnValue) { return default; }
	public void GetSafeZonePadding(UObject WorldContextObject,FVector4 SafePadding,FVector2D SafePaddingScale,FVector4 SpillOverPadding) {}
	public void SetColorVisionDeficiencyType(EColorVisionDeficiency Type,float Severity,bool CorrectDeficiency,bool ShowCorrectionWithDeficiency) {}
	public bool SetHardwareCursor(UObject WorldContextObject,EMouseCursor CursorShape,sbyte CursorName,FVector2D HotSpot,bool ReturnValue) { return default; }
	public void SetWindowTitleBarState(UObject TitleBarContent,EWindowTitleBarMode Mode,bool bTitleBarDragEnabled,bool bWindowButtonsVisible,bool bTitleBarVisible) {}
	public void RestorePreviousWindowTitleBarState() {}
	public void FOnGameWindowCloseButtonClickedDelegate() {}
	public void SetWindowTitleBarOnCloseClickedDelegate(FOnGameWindowCloseButtonClickedDelegate Delegate) {}
	public void SetWindowTitleBarCloseButtonActive(bool bActive) {}
}
