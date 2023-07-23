#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFTextBlock.h")]
public partial class UUIFrameworkTextBlock : UUIFrameworkTextBase {
// UIFrameworkTextBlock
	public void SetShadowOffset(FVector2f ShadowOffset) {}
	public FVector2f GetShadowOffset(FVector2f ReturnValue) { return default; }
	public void SetShadowColor(FLinearColor ShadowColor) {}
	public FLinearColor GetShadowColor(FLinearColor ReturnValue) { return default; }
	public void OnRep_ShadowOffset() {}
	public void OnRep_ShadowColor() {}
	public FVector2f ShadowOffset;
	public FLinearColor ShadowColor;
}
