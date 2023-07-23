#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeConvert.h")]
///<summary>Helper struct that stores a connection between two sockets.</summary>
public partial struct FNiagaraConvertConnection {
// NiagaraConvertConnection
	public FGuid SourcePinId;
	public TArray<sbyte> SourcePath;
	public FGuid DestinationPinId;
	public TArray<sbyte> DestinationPath;
	public FGuid SourcePropertyId;
	public FGuid DestinationPropertyId;
}
