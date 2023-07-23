#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
public partial struct FNiagaraScriptDataInterfaceCompileInfo {
// NiagaraScriptDataInterfaceCompileInfo
	public sbyte Name;
	public int UserPtrIdx;
	public FNiagaraTypeDefinition Type;
	public TArray<FNiagaraFunctionSignature> RegisteredFunctions;
	public sbyte RegisteredParameterMapRead;
	public sbyte RegisteredParameterMapWrite;
	public bool bIsPlaceholder;
}
