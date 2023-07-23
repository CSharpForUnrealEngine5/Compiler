#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFSimpleButton.h")]
public partial class UUIFrameworkSimpleButton : UUIFrameworkWidget {
// UIFrameworkSimpleButton
	public sbyte Text;
	public FUIFrameworkClickEventArgument ClickEvent;
	public void SetText(sbyte Value) {}
	public void OnClick(FMVVMEventField Field) {}
	public void OnRep_Text() {}
	public void ServerClick(UObject PlayerController) {}
}
