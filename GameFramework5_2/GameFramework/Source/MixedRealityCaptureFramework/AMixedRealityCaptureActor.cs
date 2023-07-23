#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MixedRealityCaptureActor.h")]
public partial class AMixedRealityCaptureActor : AActor {
// MixedRealityCaptureActor
	public UMixedRealityCaptureComponent CaptureComponent;
	public bool bAutoAttachToVRPlayer;
	public bool bAutoHidePlayer;
	public bool bHideAttachmentsWithPlayer;
	public bool bAutoBroadcast;
	public void SetAutoBroadcast(bool bNewValue) {}
	public bool IsBroadcasting(bool ReturnValue) { return default; }
	public UObject GetCaptureTexture(UObject ReturnValue) { return default; }
	public void OnTargetDestroyed(UObject DestroyedActor) {}
	public UStaticMesh DebugVisualizerMesh;
}
