#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Protocols/UserDefinedCaptureProtocol.h")]
///<summary>A blueprintable capture protocol that defines how to capture frames from the engine</summary>
public partial class UUserDefinedCaptureProtocol : UMovieSceneImageCaptureProtocolBase {
// UserDefinedCaptureProtocol
	public void OnPreTick() {}
	public void OnTick() {}
	public bool OnSetup(bool ReturnValue) { return default; }
	public void OnWarmUp() {}
	public void OnStartCapture() {}
	public void OnCaptureFrame() {}
	public void OnPauseCapture() {}
	public void OnBeginFinalize() {}
	public bool OnCanFinalize(bool ReturnValue) { return default; }
	public void OnFinalize() {}
	public void OnPixelsReceived(FCapturedPixels Pixels,FCapturedPixelsID ID,FFrameMetrics FrameMetrics) {}
	public void ResolveBuffer(UObject Buffer,FCapturedPixelsID BufferID) {}
	public void StartCapturingFinalPixels(FCapturedPixelsID StreamID) {}
	public void StopCapturingFinalPixels() {}
	public sbyte GenerateFilename(FFrameMetrics InFrameMetrics,sbyte ReturnValue) { return default; }
	public FFrameMetrics GetCurrentFrameMetrics(FFrameMetrics ReturnValue) { return default; }
	public UWorld World;
}
