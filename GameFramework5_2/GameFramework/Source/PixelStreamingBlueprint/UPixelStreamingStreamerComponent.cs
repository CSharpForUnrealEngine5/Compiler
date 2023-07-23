#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PixelStreamingStreamerComponent.h")]
public partial class UPixelStreamingStreamerComponent : UActorComponent {
// PixelStreamingStreamerComponent
	public sbyte GetId(sbyte ReturnValue) { return default; }
	public bool IsSignallingConnected(bool ReturnValue) { return default; }
	public void StartStreaming() {}
	public void StopStreaming() {}
	public bool IsStreaming(bool ReturnValue) { return default; }
	public void ForceKeyFrame() {}
	public void FreezeStream(UObject Texture) {}
	public void UnfreezeStream() {}
	public void SendPlayerMessage(byte Type,sbyte Descriptor) {}
	public sbyte StreamerId;
	public sbyte SignallingServerURL;
	public int StreamFPS;
	public bool CoupleFramerate;
	public UPixelStreamingStreamerVideoInput VideoInput;
}
