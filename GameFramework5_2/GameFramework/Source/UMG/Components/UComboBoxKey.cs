#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ComboBoxKey.h")]
///<summary>The combobox allows you to display a list of options to the user in a dropdown menu for them to select one.</summary>
public partial class UComboBoxKey : UWidget {
// ComboBoxKey
	public void FOnSelectionChangedEvent(sbyte SelectedItem,ESelectInfo SelectionType) {}
	public void FOnOpeningEvent() {}
	public UObject FGenerateWidgetEvent(sbyte Item,UObject ReturnValue) { return default; }
	public TArray<sbyte> Options;
	public sbyte SelectedOption;
	public FComboBoxStyle WidgetStyle;
	public FTableRowStyle ItemStyle;
	public FScrollBarStyle ScrollBarStyle;
	public FSlateColor ForegroundColor;
	public FMargin ContentPadding;
	public float MaxListHeight;
	public bool bHasDownArrow;
	public bool bEnableGamepadNavigationMode;
	public bool bIsFocusable;
	public FGenerateWidgetEvent OnGenerateContentWidget;
	public FGenerateWidgetEvent OnGenerateItemWidget;
	public FOnSelectionChangedEvent OnSelectionChanged;
	public FOnOpeningEvent OnOpening;
	public void AddOption(sbyte Option) {}
	public bool RemoveOption(sbyte Option,bool ReturnValue) { return default; }
	public void ClearOptions() {}
	public void ClearSelection() {}
	public void SetSelectedOption(sbyte Option) {}
	public sbyte GetSelectedOption(sbyte ReturnValue) { return default; }
	public bool IsOpen(bool ReturnValue) { return default; }
}
