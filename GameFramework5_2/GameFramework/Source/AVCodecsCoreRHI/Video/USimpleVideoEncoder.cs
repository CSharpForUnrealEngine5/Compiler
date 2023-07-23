#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Video/Encoders/SimpleVideoEncoder.h")]
public partial class USimpleVideoEncoder : UObject {
// SimpleVideoEncoder
	public bool IsAsync(bool ReturnValue) { return default; }
	public bool IsOpen(bool ReturnValue) { return default; }
	public bool Open(ESimpleVideoCodec Codec,FSimpleVideoEncoderConfig Config,bool bAsynchronous,bool ReturnValue) { return default; }
	public void Close() {}
	public bool SendFrameRenderTarget(UObject Resource,double Timestamp,bool bForceKeyframe=false,bool ReturnValue) { return default; }
	public bool SendFrameTexture(UObject Resource,double Timestamp,bool bForceKeyframe=false,bool ReturnValue) { return default; }
	public bool ReceivePacket(FSimpleVideoPacket OutPacket,bool ReturnValue) { return default; }
	public void ReceivePackets(TArray<FSimpleVideoPacket> OutPackets) {}
	public ESimpleVideoCodec GetCodec(ESimpleVideoCodec ReturnValue) { return default; }
	public FSimpleVideoEncoderConfig GetConfig(FSimpleVideoEncoderConfig ReturnValue) { return default; }
	public void SetConfig(FSimpleVideoEncoderConfig NewConfig) {}
}
