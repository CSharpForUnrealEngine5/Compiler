#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/CanvasPanelSlot.h")]
public partial class UCanvasPanelSlot : UPanelSlot {
// CanvasPanelSlot
	public FAnchorData LayoutData;
	public bool bAutoSize;
	public int ZOrder;
	public void SetLayout(FAnchorData InLayoutData) {}
	public FAnchorData GetLayout(FAnchorData ReturnValue) { return default; }
	public void SetPosition(FVector2D InPosition) {}
	public FVector2D GetPosition(FVector2D ReturnValue) { return default; }
	public void SetSize(FVector2D InSize) {}
	public FVector2D GetSize(FVector2D ReturnValue) { return default; }
	public void SetOffsets(FMargin InOffset) {}
	public FMargin GetOffsets(FMargin ReturnValue) { return default; }
	public void SetAnchors(FAnchors InAnchors) {}
	public FAnchors GetAnchors(FAnchors ReturnValue) { return default; }
	public void SetAlignment(FVector2D InAlignment) {}
	public FVector2D GetAlignment(FVector2D ReturnValue) { return default; }
	public void SetAutoSize(bool InbAutoSize) {}
	public bool GetAutoSize(bool ReturnValue) { return default; }
	public void SetZOrder(int InZOrder) {}
	public int GetZOrder(int ReturnValue) { return default; }
	public void SetMinimum(FVector2D InMinimumAnchors) {}
	public void SetMaximum(FVector2D InMaximumAnchors) {}
}
