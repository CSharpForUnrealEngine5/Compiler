#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraSubsystem.h")]
public partial class UVirtualCameraSubsystem : UEngineSubsystem {
// VirtualCameraSubsystem
	public bool StartStreaming(bool ReturnValue) { return default; }
	public bool StopStreaming(bool ReturnValue) { return default; }
	public bool IsStreaming(bool ReturnValue) { return default; }
	public void HandleSelectionChangedEvent(UObject SelectedObject) {}
	public void HandleSelectObjectEvent(UObject SelectedObject) {}
	public object /*ReturnValue*/ GetVirtualCameraController(object /*ReturnValue*/ ReturnValue) { return default; }
	public void SetVirtualCameraController(object /*VirtualCamera*/ VirtualCamera) {}
	public ULevelSequencePlaybackController SequencePlaybackController;
	public FOnStreamStarted OnStreamStartedDelegate;
	public FOnStreamStopped OnStreamStoppedDelegate;
	public FOnSelectedAnyActor OnSelectedAnyActorDelegate;
	public FOnSelectedViewportActor OnSelectedActorInViewportDelegate;
	public object /*ActiveCameraController*/ ActiveCameraController;
}
