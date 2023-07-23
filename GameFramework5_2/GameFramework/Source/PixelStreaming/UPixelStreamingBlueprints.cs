#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PixelStreamingBlueprints.h")]
public partial class UPixelStreamingBlueprints : UBlueprintFunctionLibrary {
// PixelStreamingBlueprints
	public void SendFileAsByteArray(TArray<byte> ByteArray,sbyte MimeType,sbyte FileExtension) {}
	public void StreamerSendFileAsByteArray(sbyte StreamerId,TArray<byte> ByteArray,sbyte MimeType,sbyte FileExtension) {}
	public void SendFile(sbyte Filepath,sbyte MimeType,sbyte FileExtension) {}
	public void StreamerSendFile(sbyte StreamerId,sbyte Filepath,sbyte MimeType,sbyte FileExtension) {}
	public void ForceKeyFrame() {}
	public void FreezeFrame(UObject Texture) {}
	public void UnfreezeFrame() {}
	public void StreamerFreezeStream(sbyte StreamerId,UObject Texture) {}
	public void StreamerUnfreezeStream(sbyte StreamerId) {}
	public void KickPlayer(sbyte PlayerId) {}
	public void StreamerKickPlayer(sbyte StreamerId,sbyte PlayerId) {}
	public sbyte GetDefaultStreamerID(sbyte ReturnValue) { return default; }
	public UObject GetPixelStreamingDelegates(UObject ReturnValue) { return default; }
}
