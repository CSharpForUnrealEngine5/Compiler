#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HttpBlueprintFunctionLibrary.h")]
public partial class UHttpBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// HttpBlueprintFunctionLibrary
	public void MakeRequestHeader(TMap<sbyte,sbyte> Headers,FHttpHeader OutHeader) {}
	public bool GetHeaderValue(FHttpHeader HeaderObject,sbyte HeaderName,sbyte OutHeaderValue,bool ReturnValue) { return default; }
	public TArray<sbyte> GetAllHeaders(FHttpHeader HeaderObject,TArray<sbyte> ReturnValue) { return default; }
	public TMap<sbyte,sbyte> GetAllHeaders_Map(FHttpHeader HeaderObject,TMap<sbyte,sbyte> ReturnValue) { return default; }
	public void AddHeader(FHttpHeader HeaderObject,sbyte NewHeader,sbyte NewHeaderValue) {}
	public bool RemoveHeader(FHttpHeader HeaderObject,sbyte HeaderToRemove,bool ReturnValue) { return default; }
}
