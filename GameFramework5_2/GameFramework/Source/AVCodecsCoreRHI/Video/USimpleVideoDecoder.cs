#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Video/Decoders/SimpleVideoDecoder.h")]
public partial class USimpleVideoDecoder : UObject {
// SimpleVideoDecoder
	public bool IsAsync(bool ReturnValue) { return default; }
	public bool IsOpen(bool ReturnValue) { return default; }
	public bool Open(ESimpleVideoCodec Codec,bool bAsynchronous,bool ReturnValue) { return default; }
	public void Close() {}
	public bool SendPacket(FSimpleVideoPacket Packet,bool ReturnValue) { return default; }
	public bool ReceiveFrame(UObject Resource,bool ReturnValue) { return default; }
	public ESimpleVideoCodec GetCodec(ESimpleVideoCodec ReturnValue) { return default; }
}
