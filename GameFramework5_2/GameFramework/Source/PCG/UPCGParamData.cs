#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGParamData.h")]
///<summary>Class to hold execution parameters that will be consumed in nodes of the graph</summary>
public partial class UPCGParamData : UPCGData {
// PCGParamData
	public UObject ConstMetadata(UObject ReturnValue) { return default; }
	public UObject MutableMetadata(UObject ReturnValue) { return default; }
	public long FindMetadataKey(sbyte InName,long ReturnValue) { return default; }
	public long FindOrAddMetadataKey(sbyte InName,long ReturnValue) { return default; }
	public UObject FilterParamsByName(sbyte InName,UObject ReturnValue) { return default; }
	public UObject FilterParamsByKey(long InKey,UObject ReturnValue) { return default; }
	public UPCGMetadata Metadata;
	public TMap<sbyte,long> NameMap;
}
