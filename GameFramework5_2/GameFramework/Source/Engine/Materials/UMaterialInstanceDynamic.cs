#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialInstanceDynamic.h")]
public partial class UMaterialInstanceDynamic : UMaterialInstance {
// MaterialInstanceDynamic
	public void SetScalarParameterValue(sbyte ParameterName,float Value) {}
	public void SetScalarParameterValueByInfo(FMaterialParameterInfo ParameterInfo,float Value) {}
	public bool InitializeScalarParameterAndGetIndex(sbyte ParameterName,float Value,int OutParameterIndex,bool ReturnValue) { return default; }
	public bool SetScalarParameterByIndex(int ParameterIndex,float Value,bool ReturnValue) { return default; }
	public float K2_GetScalarParameterValue(sbyte ParameterName,float ReturnValue) { return default; }
	public float K2_GetScalarParameterValueByInfo(FMaterialParameterInfo ParameterInfo,float ReturnValue) { return default; }
	public void SetTextureParameterValue(sbyte ParameterName,UObject Value) {}
	public void SetTextureParameterValueByInfo(FMaterialParameterInfo ParameterInfo,UObject Value) {}
	public void SetRuntimeVirtualTextureParameterValue(sbyte ParameterName,UObject Value) {}
	public void SetRuntimeVirtualTextureParameterValueByInfo(FMaterialParameterInfo ParameterInfo,UObject Value) {}
	public void SetSparseVolumeTextureParameterValue(sbyte ParameterName,UObject Value) {}
	public UObject K2_GetTextureParameterValue(sbyte ParameterName,UObject ReturnValue) { return default; }
	public UObject K2_GetTextureParameterValueByInfo(FMaterialParameterInfo ParameterInfo,UObject ReturnValue) { return default; }
	public void SetVectorParameterValue(sbyte ParameterName,FLinearColor Value) {}
	public void SetDoubleVectorParameterValue(sbyte ParameterName,FVector4 Value) {}
	public void SetVectorParameterValueByInfo(FMaterialParameterInfo ParameterInfo,FLinearColor Value) {}
	public FLinearColor K2_GetVectorParameterValue(sbyte ParameterName,FLinearColor ReturnValue) { return default; }
	public FLinearColor K2_GetVectorParameterValueByInfo(FMaterialParameterInfo ParameterInfo,FLinearColor ReturnValue) { return default; }
	public void K2_InterpolateMaterialInstanceParams(UObject SourceA,UObject SourceB,float Alpha) {}
	public void K2_CopyMaterialInstanceParameters(UObject Source,bool bQuickParametersOnly=false) {}
	public void CopyInterpParameters(UObject Source) {}
	public void CopyParameterOverrides(UObject MaterialInstance) {}
}
