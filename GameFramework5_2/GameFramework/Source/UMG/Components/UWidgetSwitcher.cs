#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/WidgetSwitcher.h")]
///<summary>A widget switcher is like a tab control, but without tabs. At most one widget is visible at time.</summary>
public partial class UWidgetSwitcher : UPanelWidget {
// WidgetSwitcher
	public int ActiveWidgetIndex;
	public int GetNumWidgets(int ReturnValue) { return default; }
	public int GetActiveWidgetIndex(int ReturnValue) { return default; }
	public void SetActiveWidgetIndex(int Index) {}
	public void SetActiveWidget(UObject Widget) {}
	public UObject GetWidgetAtIndex(int Index,UObject ReturnValue) { return default; }
	public UObject GetActiveWidget(UObject ReturnValue) { return default; }
}
