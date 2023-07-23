#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/WidgetLayoutLibrary.h")]
public partial class UWidgetLayoutLibrary : UBlueprintFunctionLibrary {
// WidgetLayoutLibrary
	public bool ProjectWorldLocationToWidgetPosition(UObject PlayerController,FVector WorldLocation,FVector2D ScreenPosition,bool bPlayerViewportRelative,bool ReturnValue) { return default; }
	public float GetViewportScale(UObject WorldContextObject,float ReturnValue) { return default; }
	public FVector2D GetViewportSize(UObject WorldContextObject,FVector2D ReturnValue) { return default; }
	public FGeometry GetViewportWidgetGeometry(UObject WorldContextObject,FGeometry ReturnValue) { return default; }
	public FGeometry GetPlayerScreenWidgetGeometry(UObject PlayerController,FGeometry ReturnValue) { return default; }
	public FVector2D GetMousePositionOnPlatform(FVector2D ReturnValue) { return default; }
	public FVector2D GetMousePositionOnViewport(UObject WorldContextObject,FVector2D ReturnValue) { return default; }
	public bool GetMousePositionScaledByDPI(UObject Player,float LocationX,float LocationY,bool ReturnValue) { return default; }
	public UObject SlotAsBorderSlot(UObject Widget,UObject ReturnValue) { return default; }
	public UObject SlotAsCanvasSlot(UObject Widget,UObject ReturnValue) { return default; }
	public UObject SlotAsGridSlot(UObject Widget,UObject ReturnValue) { return default; }
	public UObject SlotAsHorizontalBoxSlot(UObject Widget,UObject ReturnValue) { return default; }
	public UObject SlotAsOverlaySlot(UObject Widget,UObject ReturnValue) { return default; }
	public UObject SlotAsUniformGridSlot(UObject Widget,UObject ReturnValue) { return default; }
	public UObject SlotAsVerticalBoxSlot(UObject Widget,UObject ReturnValue) { return default; }
	public UObject SlotAsScrollBoxSlot(UObject Widget,UObject ReturnValue) { return default; }
	public UObject SlotAsSafeBoxSlot(UObject Widget,UObject ReturnValue) { return default; }
	public UObject SlotAsScaleBoxSlot(UObject Widget,UObject ReturnValue) { return default; }
	public UObject SlotAsSizeBoxSlot(UObject Widget,UObject ReturnValue) { return default; }
	public UObject SlotAsWrapBoxSlot(UObject Widget,UObject ReturnValue) { return default; }
	public UObject SlotAsWidgetSwitcherSlot(UObject Widget,UObject ReturnValue) { return default; }
	public void RemoveAllWidgets(UObject WorldContextObject) {}
}
