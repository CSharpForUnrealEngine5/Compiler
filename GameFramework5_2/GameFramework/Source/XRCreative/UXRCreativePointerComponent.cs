#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRCreativePointerComponent.h")]
public partial class UXRCreativePointerComponent : USceneComponent {
// XRCreativePointerComponent
	public FVector GetRawTraceEnd(bool bScaledByImpact=true,FVector ReturnValue) { return default; }
	public FVector GetFilteredTraceEnd(bool bScaledByImpact=true,FVector ReturnValue) { return default; }
	public FHitResult GetHitResult(FHitResult ReturnValue) { return default; }
	public bool IsEnabled(bool ReturnValue) { return default; }
	public void SetEnabled(bool bInEnabled) {}
	public float TraceMaxLength;
	public float SmoothingLag;
	public float SmoothingMinCutoff;
	public bool bEnabled;
}
