#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingMaterialPass.h")]
///<summary>FCompositingParamPayload</summary>
public partial struct FCompositingParamPayload {
// CompositingParamPayload
	public TMap<sbyte,float> ScalarParamOverrides;
	public TMap<sbyte,FLinearColor> VectorParamOverrides;
	public TMap<sbyte,UTexture> TextureParamOverrides;
}
