#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PixelStreamingPeerComponent.h")]
///<summary>A blueprint representation of a Pixel Streaming Peer Connection. Should communicate with a Pixel Streaming Signalling Connection</summary>
public partial class UPixelStreamingPeerComponent : UActorComponent {
// PixelStreamingPeerComponent
	public void SetConfig(FPixelStreamingRTCConfigWrapper Config) {}
	public FPixelStreamingSessionDescriptionWrapper CreateOffer(FPixelStreamingSessionDescriptionWrapper ReturnValue) { return default; }
	public FPixelStreamingSessionDescriptionWrapper CreateAnswer(sbyte Offer,FPixelStreamingSessionDescriptionWrapper ReturnValue) { return default; }
	public void ReceiveAnswer(sbyte Offer) {}
	public void ReceiveIceCandidate(FPixelStreamingIceCandidateWrapper Candidate) {}
	public FPixelStreamingOnIceCandidate OnIceCandidate;
	public FPixelStreamingOnIceConnection OnIceConnection;
	public FPixelStreamingOnIceDisconnection OnIceDisconnection;
	public UMediaPlayer VideoSinkPlayer;
}
