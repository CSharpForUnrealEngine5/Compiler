#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/Viewport.h")]
public partial class UViewport : UContentWidget {
// Viewport
	public FLinearColor BackgroundColor;
	public UObject GetViewportWorld(UObject ReturnValue) { return default; }
	public FVector GetViewLocation(FVector ReturnValue) { return default; }
	public void SetViewLocation(FVector Location) {}
	public FRotator GetViewRotation(FRotator ReturnValue) { return default; }
	public void SetViewRotation(FRotator Rotation) {}
	public UObject Spawn(UClass ActorClass,UObject ReturnValue) { return default; }
}
