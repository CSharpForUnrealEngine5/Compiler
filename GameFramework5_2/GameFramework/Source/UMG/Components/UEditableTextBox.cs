#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/EditableTextBox.h")]
///<summary>Allows the user to type in custom text.  Only permits a single line of text to be entered.</summary>
public partial class UEditableTextBox : UWidget {
// EditableTextBox
	public void FOnEditableTextBoxChangedEvent(sbyte Text) {}
	public void FOnEditableTextBoxCommittedEvent(sbyte Text,ETextCommit CommitMethod) {}
	public sbyte Text;
	public FGetText TextDelegate;
	public FEditableTextBoxStyle WidgetStyle;
	public sbyte HintText;
	public FGetText HintTextDelegate;
	public bool IsReadOnly;
	public bool IsPassword;
	public float MinimumDesiredWidth;
	public bool IsCaretMovedWhenGainFocus;
	public bool SelectAllTextWhenFocused;
	public bool RevertTextOnEscape;
	public bool ClearKeyboardFocusOnCommit;
	public bool SelectAllTextOnCommit;
	public bool AllowContextMenu;
	public byte KeyboardType;
	public FVirtualKeyboardOptions VirtualKeyboardOptions;
	public EVirtualKeyboardTrigger VirtualKeyboardTrigger;
	public EVirtualKeyboardDismissAction VirtualKeyboardDismissAction;
	public byte Justification;
	public ETextOverflowPolicy OverflowPolicy;
	public FShapedTextOptions ShapedTextOptions;
	public FOnEditableTextBoxChangedEvent OnTextChanged;
	public FOnEditableTextBoxCommittedEvent OnTextCommitted;
	public sbyte GetText(sbyte ReturnValue) { return default; }
	public void SetText(sbyte InText) {}
	public void SetHintText(sbyte InText) {}
	public void SetError(sbyte InError) {}
	public void SetIsReadOnly(bool bReadOnly) {}
	public void SetIsPassword(bool bIsPassword) {}
	public void ClearError() {}
	public bool HasError(bool ReturnValue) { return default; }
	public void SetJustification(ETextJustify InJustification) {}
	public void SetTextOverflowPolicy(ETextOverflowPolicy InOverflowPolicy) {}
	public void SetForegroundColor(FLinearColor color) {}
	public bool bIsFontDeprecationDone;
}
