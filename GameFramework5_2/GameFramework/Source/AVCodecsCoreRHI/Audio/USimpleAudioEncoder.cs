#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Audio/Encoders/SimpleAudioEncoder.h")]
public partial class USimpleAudioEncoder : UObject {
// SimpleAudioEncoder
	public bool IsAsync(bool ReturnValue) { return default; }
	public bool IsOpen(bool ReturnValue) { return default; }
	public bool Open(ESimpleAudioCodec Codec,FSimpleAudioEncoderConfig Config,bool bAsynchronous,bool ReturnValue) { return default; }
	public void Close() {}
	public bool SendFrameFloat(TArray<float> Resource,double Timestamp,int NumSamples,float SampleDuration,bool ReturnValue) { return default; }
	public bool ReceivePacket(FSimpleAudioPacket OutPacket,bool ReturnValue) { return default; }
	public void ReceivePackets(TArray<FSimpleAudioPacket> OutPackets) {}
	public ESimpleAudioCodec GetCodec(ESimpleAudioCodec ReturnValue) { return default; }
	public FSimpleAudioEncoderConfig GetConfig(FSimpleAudioEncoderConfig ReturnValue) { return default; }
	public void SetConfig(FSimpleAudioEncoderConfig NewConfig) {}
}
