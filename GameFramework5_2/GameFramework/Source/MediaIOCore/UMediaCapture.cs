#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaCapture.h")]
///<summary>Abstract base class for media capture.</summary>
public partial class UMediaCapture : UObject {
// MediaCapture
	public bool CaptureActiveSceneViewport(FMediaCaptureOptions CaptureOptions,bool ReturnValue) { return default; }
	public bool CaptureTextureRenderTarget2D(UObject RenderTarget,FMediaCaptureOptions CaptureOptions,bool ReturnValue) { return default; }
	public bool UpdateTextureRenderTarget2D(UObject RenderTarget,bool ReturnValue) { return default; }
	public void StopCapture(bool bAllowPendingFrameToBeProcess) {}
	public EMediaCaptureState GetState(EMediaCaptureState ReturnValue) { return default; }
	public void SetMediaOutput(UObject InMediaOutput) {}
	public FIntPoint GetDesiredSize(FIntPoint ReturnValue) { return default; }
	public EPixelFormat GetDesiredPixelFormat(EPixelFormat ReturnValue) { return default; }
	public FMediaCaptureStateChangedSignature OnStateChanged;
	public UMediaOutput MediaOutput;
}
