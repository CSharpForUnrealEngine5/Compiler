#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintMaterialTextureNodesBPLibrary.h")]
///<summary>*      Function library class.</summary>
public partial class UBlueprintMaterialTextureNodesBPLibrary : UBlueprintFunctionLibrary {
// BlueprintMaterialTextureNodesBPLibrary
	public FLinearColor Texture2D_SampleUV_EditorOnly(UObject Texture,FVector2D UV,FLinearColor ReturnValue) { return default; }
	public TArray<FLinearColor> RenderTarget_SampleRectangle_EditorOnly(UObject InRenderTarget,FLinearColor InRect,TArray<FLinearColor> ReturnValue) { return default; }
	public FLinearColor RenderTarget_SampleUV_EditorOnly(UObject InRenderTarget,FVector2D UV,FLinearColor ReturnValue) { return default; }
	public UObject CreateMIC_EditorOnly(UObject Material,sbyte Name="MIC_",UObject ReturnValue) { return default; }
	public void UpdateMIC(UObject MIC) {}
	public bool SetMICScalarParam_EditorOnly(UObject Material,sbyte ParamName="test",float Value=0.0f,bool ReturnValue) { return default; }
	public bool SetMICVectorParam_EditorOnly(UObject Material,sbyte ParamName,FLinearColor Value=FLinearColor,bool ReturnValue) { return default; }
	public bool SetMICTextureParam_EditorOnly(UObject Material,sbyte ParamName,UObject Texture=nullptr,bool ReturnValue) { return default; }
	public bool SetMICShadingModel_EditorOnly(UObject Material,byte ShadingModel=MSM_DefaultLit,bool ReturnValue) { return default; }
	public bool SetMICBlendMode_EditorOnly(UObject Material,byte BlendMode=BLEND_Opaque,bool ReturnValue) { return default; }
	public bool SetMICTwoSided_EditorOnly(UObject Material,bool TwoSided=false,bool ReturnValue) { return default; }
	public bool SetMICIsThinSurface_EditorOnly(UObject Material,bool bIsThinSurface=false,bool ReturnValue) { return default; }
	public bool SetMICDitheredLODTransition_EditorOnly(UObject Material,bool DitheredLODTransition=false,bool ReturnValue) { return default; }
}
