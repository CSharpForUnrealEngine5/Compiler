#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/MultiLineEditableText.h")]
///<summary>Editable text box widget</summary>
public partial class UMultiLineEditableText : UTextLayoutWidget {
// MultiLineEditableText
	public void FOnMultiLineEditableTextChangedEvent(sbyte Text) {}
	public void FOnMultiLineEditableTextCommittedEvent(sbyte Text,ETextCommit CommitMethod) {}
	public sbyte Text;
	public sbyte HintText;
	public FGetText HintTextDelegate;
	public FTextBlockStyle WidgetStyle;
	public bool bIsReadOnly;
	public bool SelectAllTextWhenFocused;
	public bool ClearTextSelectionOnFocusLoss;
	public bool RevertTextOnEscape;
	public bool ClearKeyboardFocusOnCommit;
	public bool AllowContextMenu;
	public FVirtualKeyboardOptions VirtualKeyboardOptions;
	public EVirtualKeyboardDismissAction VirtualKeyboardDismissAction;
	public FOnMultiLineEditableTextChangedEvent OnTextChanged;
	public FOnMultiLineEditableTextCommittedEvent OnTextCommitted;
	public sbyte GetText(sbyte ReturnValue) { return default; }
	public void SetText(sbyte InText) {}
	public sbyte GetHintText(sbyte ReturnValue) { return default; }
	public void SetHintText(sbyte InHintText) {}
	public void SetIsReadOnly(bool bReadOnly) {}
	public void SetWidgetStyle(FTextBlockStyle InWidgetStyle) {}
	public FSlateFontInfo GetFont(FSlateFontInfo ReturnValue) { return default; }
	public void SetFont(FSlateFontInfo InFontInfo) {}
	public void SetFontMaterial(UObject InMaterial) {}
	public void SetFontOutlineMaterial(UObject InMaterial) {}
}
