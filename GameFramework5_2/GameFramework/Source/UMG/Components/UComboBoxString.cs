#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ComboBoxString.h")]
///<summary>The combobox allows you to display a list of options to the user in a dropdown menu for them to select one.</summary>
public partial class UComboBoxString : UWidget {
// ComboBoxString
	public void FOnSelectionChangedEvent(sbyte SelectedItem,ESelectInfo SelectionType) {}
	public void FOnOpeningEvent() {}
	public TArray<sbyte> DefaultOptions;
	public sbyte SelectedOption;
	public FComboBoxStyle WidgetStyle;
	public FTableRowStyle ItemStyle;
	public FScrollBarStyle ScrollBarStyle;
	public FMargin ContentPadding;
	public float MaxListHeight;
	public bool HasDownArrow;
	public bool EnableGamepadNavigationMode;
	public FSlateFontInfo Font;
	public FSlateColor ForegroundColor;
	public bool bIsFocusable;
	public FGenerateWidgetForString OnGenerateWidgetEvent;
	public FOnSelectionChangedEvent OnSelectionChanged;
	public FOnOpeningEvent OnOpening;
	public void AddOption(sbyte Option) {}
	public bool RemoveOption(sbyte Option,bool ReturnValue) { return default; }
	public int FindOptionIndex(sbyte Option,int ReturnValue) { return default; }
	public sbyte GetOptionAtIndex(int Index,sbyte ReturnValue) { return default; }
	public void ClearOptions() {}
	public void ClearSelection() {}
	public void RefreshOptions() {}
	public void SetSelectedOption(sbyte Option) {}
	public void SetSelectedIndex(int Index) {}
	public sbyte GetSelectedOption(sbyte ReturnValue) { return default; }
	public int GetSelectedIndex(int ReturnValue) { return default; }
	public int GetOptionCount(int ReturnValue) { return default; }
	public bool IsOpen(bool ReturnValue) { return default; }
}
