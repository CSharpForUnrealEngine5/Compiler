#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/EditableText.h")]
///<summary>Editable text box widget</summary>
public partial class UEditableText : UWidget {
// EditableText
	public void FOnEditableTextChangedEvent(sbyte Text) {}
	public void FOnEditableTextCommittedEvent(sbyte Text,ETextCommit CommitMethod) {}
	public sbyte Text;
	public FGetText TextDelegate;
	public sbyte HintText;
	public FGetText HintTextDelegate;
	public FEditableTextStyle WidgetStyle;
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
	public FOnEditableTextChangedEvent OnTextChanged;
	public FOnEditableTextCommittedEvent OnTextCommitted;
	public sbyte GetText(sbyte ReturnValue) { return default; }
	public void SetText(sbyte InText) {}
	public void SetIsPassword(bool InbIsPassword) {}
	public sbyte GetHintText(sbyte ReturnValue) { return default; }
	public void SetHintText(sbyte InHintText) {}
	public void SetMinimumDesiredWidth(float InMinDesiredWidth) {}
	public void SetIsReadOnly(bool InbIsReadyOnly) {}
	public ETextJustify GetJustification(ETextJustify ReturnValue) { return default; }
	public void SetJustification(ETextJustify InJustification) {}
	public void SetTextOverflowPolicy(ETextOverflowPolicy InOverflowPolicy) {}
	public FSlateFontInfo GetFont(FSlateFontInfo ReturnValue) { return default; }
	public void SetFont(FSlateFontInfo InFontInfo) {}
	public void SetFontMaterial(UObject InMaterial) {}
	public void SetFontOutlineMaterial(UObject InMaterial) {}
}
