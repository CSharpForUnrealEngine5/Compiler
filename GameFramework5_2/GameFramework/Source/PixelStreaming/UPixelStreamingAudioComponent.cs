#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PixelStreamingAudioComponent.h")]
///<summary>Allows in-engine playback of incoming WebRTC audio from a particular Pixel Streaming player/peer using their mic in the browser.</summary>
public partial class UPixelStreamingAudioComponent : USynthComponent {
// PixelStreamingAudioComponent
	public sbyte StreamerToHear;
	public sbyte PlayerToHear;
	public bool bAutoFindPeer;
	public bool ListenTo(sbyte PlayerToListenTo,bool ReturnValue) { return default; }
	public bool StreamerListenTo(sbyte StreamerId,sbyte PlayerToListenTo,bool ReturnValue) { return default; }
	public bool IsListeningToPlayer(bool ReturnValue) { return default; }
	public void Reset() {}
}
