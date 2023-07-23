#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataChannelHandler.h")]
public partial class UNiagaraDataChannelHandler : UObject {
// NiagaraDataChannelHandler
	public UObject GetDataChannelWriter(UObject ReturnValue) { return default; }
	public UObject GetDataChannelReader(UObject ReturnValue) { return default; }
	public UNiagaraDataChannel DataChannel;
	public UNiagaraDataChannelWriter Writer;
	public UNiagaraDataChannelReader Reader;
}
