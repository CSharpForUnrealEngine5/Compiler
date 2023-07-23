#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/GameViewportSubsystem.h")]
public partial class UGameViewportSubsystem : UEngineSubsystem {
// GameViewportSubsystem
	public bool IsWidgetAdded(UObject Widget,bool ReturnValue) { return default; }
	public void AddWidget(UObject Widget,FGameViewportWidgetSlot Slot) {}
	public void AddWidgetForPlayer(UObject Widget,UObject Player,FGameViewportWidgetSlot Slot) {}
	public void RemoveWidget(UObject Widget) {}
	public FGameViewportWidgetSlot GetWidgetSlot(UObject Widget,FGameViewportWidgetSlot ReturnValue) { return default; }
	public void SetWidgetSlot(UObject Widget,FGameViewportWidgetSlot Slot) {}
	public FGameViewportWidgetSlot SetWidgetSlotPosition(FGameViewportWidgetSlot Slot,UObject Widget,FVector2D Position,bool bRemoveDPIScale,FGameViewportWidgetSlot ReturnValue) { return default; }
	public FGameViewportWidgetSlot SetWidgetSlotDesiredSize(FGameViewportWidgetSlot Slot,FVector2D Size,FGameViewportWidgetSlot ReturnValue) { return default; }
}
