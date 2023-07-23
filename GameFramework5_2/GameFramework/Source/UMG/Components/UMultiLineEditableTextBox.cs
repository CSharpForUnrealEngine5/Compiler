#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/MultiLineEditableTextBox.h")]
///<summary>Allows a user to enter multiple lines of text</summary>
public partial class UMultiLineEditableTextBox : UTextLayoutWidget {
// MultiLineEditableTextBox
	public void FOnMultiLineEditableTextBoxChangedEvent(sbyte Text) {}
	public void FOnMultiLineEditableTextBoxCommittedEvent(sbyte Text,ETextCommit CommitMethod) {}
	public sbyte Text;
	public sbyte HintText;
	public FGetText HintTextDelegate;
	public FEditableTextBoxStyle WidgetStyle;
	public FTextBlockStyle TextStyle_DEPRECATED;
	public bool bIsReadOnly;
	public bool AllowContextMenu;
	public FVirtualKeyboardOptions VirtualKeyboardOptions;
	public EVirtualKeyboardDismissAction VirtualKeyboardDismissAction;
	public FOnMultiLineEditableTextBoxChangedEvent OnTextChanged;
	public FOnMultiLineEditableTextBoxCommittedEvent OnTextCommitted;
	public sbyte GetText(sbyte ReturnValue) { return default; }
	public void SetText(sbyte InText) {}
	public sbyte GetHintText(sbyte ReturnValue) { return default; }
	public void SetHintText(sbyte InHintText) {}
	public void SetError(sbyte InError) {}
	public void SetIsReadOnly(bool bReadOnly) {}
	public void SetTextStyle(FTextBlockStyle InTextStyle) {}
	public void SetForegroundColor(FLinearColor color) {}
	public bool bIsFontDeprecationDone;
}
