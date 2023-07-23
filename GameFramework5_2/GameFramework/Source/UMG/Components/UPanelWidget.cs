#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/PanelWidget.h")]
///<summary>The base class for all UMG panel widgets.  Panel widgets layout a collection of child widgets.</summary>
public partial class UPanelWidget : UWidget {
// PanelWidget
	public TArray<UPanelSlot> Slots;
	public int GetChildrenCount(int ReturnValue) { return default; }
	public UObject GetChildAt(int Index,UObject ReturnValue) { return default; }
	public TArray<UObject> GetAllChildren(TArray<UObject> ReturnValue) { return default; }
	public int GetChildIndex(UObject Content,int ReturnValue) { return default; }
	public bool HasChild(UObject Content,bool ReturnValue) { return default; }
	public bool RemoveChildAt(int Index,bool ReturnValue) { return default; }
	public UObject AddChild(UObject Content,UObject ReturnValue) { return default; }
	public bool RemoveChild(UObject Content,bool ReturnValue) { return default; }
	public bool HasAnyChildren(bool ReturnValue) { return default; }
	public void ClearChildren() {}
}
