#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFTextBlock.h")]
public partial class UUIFrameworkTextBase : UUIFrameworkWidget {
// UIFrameworkTextBase
	public void SetText(sbyte Text) {}
	public sbyte GetText(sbyte ReturnValue) { return default; }
	public void SetTextColor(FLinearColor TextColor) {}
	public FLinearColor GetTextColor(FLinearColor ReturnValue) { return default; }
	public void SetJustification(ETextJustify Justification) {}
	public ETextJustify GetJustification(ETextJustify ReturnValue) { return default; }
	public void SetOverflowPolicy(ETextOverflowPolicy OverflowPolicy) {}
	public ETextOverflowPolicy GetOverflowPolicy(ETextOverflowPolicy ReturnValue) { return default; }
	public void OnRep_Text() {}
	public void OnRep_TextColor() {}
	public void OnRep_Justification() {}
	public void OnRep_OverflowPolicy() {}
	public sbyte Text;
	public FLinearColor TextColor;
	public byte Justification;
	public ETextOverflowPolicy OverflowPolicy;
}
