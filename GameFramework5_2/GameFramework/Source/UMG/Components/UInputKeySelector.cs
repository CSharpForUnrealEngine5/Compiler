#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/InputKeySelector.h")]
///<summary>A widget for selecting a single key or a single key with a modifier.</summary>
public partial class UInputKeySelector : UWidget {
// InputKeySelector
	public void FOnKeySelected(FInputChord SelectedKey) {}
	public void FOnIsSelectingKeyChanged() {}
	public FButtonStyle WidgetStyle;
	public FTextBlockStyle TextStyle;
	public FInputChord SelectedKey;
	public FMargin Margin;
	public sbyte KeySelectionText;
	public sbyte NoKeySpecifiedText;
	public bool bAllowModifierKeys;
	public bool bAllowGamepadKeys;
	public TArray<FKey> EscapeKeys;
	public FOnKeySelected OnKeySelected;
	public FOnIsSelectingKeyChanged OnIsSelectingKeyChanged;
	public void SetSelectedKey(FInputChord InSelectedKey) {}
	public void SetKeySelectionText(sbyte InKeySelectionText) {}
	public void SetNoKeySpecifiedText(sbyte InNoKeySpecifiedText) {}
	public void SetAllowModifierKeys(bool bInAllowModifierKeys) {}
	public void SetAllowGamepadKeys(bool bInAllowGamepadKeys) {}
	public bool GetIsSelectingKey(bool ReturnValue) { return default; }
	public void SetTextBlockVisibility(ESlateVisibility InVisibility) {}
	public void SetEscapeKeys(TArray<FKey> InKeys) {}
}
