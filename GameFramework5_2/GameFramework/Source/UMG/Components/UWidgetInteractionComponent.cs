#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/WidgetInteractionComponent.h")]
///<summary>This is a component to allow interaction with the Widget Component.  This class allows you to</summary>
public partial class UWidgetInteractionComponent : USceneComponent {
// WidgetInteractionComponent
	public FOnHoveredWidgetChanged OnHoveredWidgetChanged;
	public void PressPointerKey(FKey Key) {}
	public void ReleasePointerKey(FKey Key) {}
	public bool PressKey(FKey Key,bool bRepeat=false,bool ReturnValue) { return default; }
	public bool ReleaseKey(FKey Key,bool ReturnValue) { return default; }
	public bool PressAndReleaseKey(FKey Key,bool ReturnValue) { return default; }
	public bool SendKeyChar(sbyte Characters,bool bRepeat=false,bool ReturnValue) { return default; }
	public void ScrollWheel(float ScrollDelta) {}
	public UObject GetHoveredWidgetComponent(UObject ReturnValue) { return default; }
	public bool IsOverInteractableWidget(bool ReturnValue) { return default; }
	public bool IsOverFocusableWidget(bool ReturnValue) { return default; }
	public bool IsOverHitTestVisibleWidget(bool ReturnValue) { return default; }
	public FHitResult GetLastHitResult(FHitResult ReturnValue) { return default; }
	public FVector2D Get2DHitLocation(FVector2D ReturnValue) { return default; }
	public void SetCustomHitResult(FHitResult HitResult) {}
	public void SetFocus(UObject FocusWidget) {}
	public int VirtualUserIndex;
	public int PointerIndex;
	public byte TraceChannel;
	public float InteractionDistance;
	public EWidgetInteractionSource InteractionSource;
	public bool bEnableHitTesting;
	public bool bShowDebug;
	public float DebugSphereLineThickness;
	public float DebugLineThickness;
	public FLinearColor DebugColor;
	public FHitResult CustomHitResult;
	public FVector2D LocalHitLocation;
	public FVector2D LastLocalHitLocation;
	public UWidgetComponent HoveredWidgetComponent;
	public FHitResult LastHitResult;
	public bool bIsHoveredWidgetInteractable;
	public bool bIsHoveredWidgetFocusable;
	public bool bIsHoveredWidgetHitTestVisible;
	public UArrowComponent ArrowComponent;
}
