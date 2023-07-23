#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingElementPasses.h")]
///<summary>UCompositingElementPass</summary>
public partial class UCompositingElementPass : UObject {
// CompositingElementPass
	public bool bEnabled;
	public sbyte PassName;
	public void OnFrameBegin(bool bCameraCutThisFrame) {}
	public void OnFrameEnd() {}
	public void Reset() {}
	public bool IsPassEnabled(bool ReturnValue) { return default; }
	public void SetPassEnabled(bool bSetEnabledTo=true) {}
	public void OnDisabled() {}
	public void OnEnabled() {}
	public UObject RequestRenderTarget(FIntPoint Dimensions,ETextureRenderTargetFormat Format,UObject ReturnValue) { return default; }
	public UObject RequestNativelyFormattedTarget(float RenderScale=1.f,UObject ReturnValue) { return default; }
	public bool ReleaseRenderTarget(UObject AssignedTarget,bool ReturnValue) { return default; }
}
