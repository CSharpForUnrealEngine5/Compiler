#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialEditingLibrary.h")]
///<summary>Blueprint library for creating/editing Materials</summary>
public partial class UMaterialEditingLibrary : UBlueprintFunctionLibrary {
// MaterialEditingLibrary
	public int GetNumMaterialExpressions(UObject Material,int ReturnValue) { return default; }
	public void DeleteAllMaterialExpressions(UObject Material) {}
	public void DeleteMaterialExpression(UObject Material,UObject Expression) {}
	public UObject CreateMaterialExpression(UObject Material,UClass ExpressionClass,int NodePosX=0,int NodePosY=0,UObject ReturnValue) { return default; }
	public UObject DuplicateMaterialExpression(UObject Material,UObject MaterialFunction,UObject Expression,UObject ReturnValue) { return default; }
	public bool SetMaterialUsage(UObject Material,EMaterialUsage Usage,bool bNeedsRecompile,bool ReturnValue) { return default; }
	public bool HasMaterialUsage(UObject Material,EMaterialUsage Usage,bool ReturnValue) { return default; }
	public bool ConnectMaterialProperty(UObject FromExpression,sbyte FromOutputName,EMaterialProperty Property,bool ReturnValue) { return default; }
	public bool ConnectMaterialExpressions(UObject FromExpression,sbyte FromOutputName,UObject ToExpression,sbyte ToInputName,bool ReturnValue) { return default; }
	public void RecompileMaterial(UObject Material) {}
	public void LayoutMaterialExpressions(UObject Material) {}
	public float GetMaterialDefaultScalarParameterValue(UObject Material,sbyte ParameterName,float ReturnValue) { return default; }
	public UObject GetMaterialDefaultTextureParameterValue(UObject Material,sbyte ParameterName,UObject ReturnValue) { return default; }
	public FLinearColor GetMaterialDefaultVectorParameterValue(UObject Material,sbyte ParameterName,FLinearColor ReturnValue) { return default; }
	public bool GetMaterialDefaultStaticSwitchParameterValue(UObject Material,sbyte ParameterName,bool ReturnValue) { return default; }
	public TSet<UObject> GetMaterialSelectedNodes(UObject Material,TSet<UObject> ReturnValue) { return default; }
	public UObject GetMaterialPropertyInputNode(UObject Material,EMaterialProperty Property,UObject ReturnValue) { return default; }
	public sbyte GetMaterialPropertyInputNodeOutputName(UObject Material,EMaterialProperty Property,sbyte ReturnValue) { return default; }
	public TArray<UObject> GetInputsForMaterialExpression(UObject Material,UObject MaterialExpression,TArray<UObject> ReturnValue) { return default; }
	public bool GetInputNodeOutputNameForMaterialExpression(UObject MaterialExpression,UObject InputNode,sbyte OutputName,bool ReturnValue) { return default; }
	public void GetMaterialExpressionNodePosition(UObject MaterialExpression,int NodePosX,int NodePosY) {}
	public TArray<UObject> GetUsedTextures(UObject Material,TArray<UObject> ReturnValue) { return default; }
	public int GetNumMaterialExpressionsInFunction(UObject MaterialFunction,int ReturnValue) { return default; }
	public UObject CreateMaterialExpressionInFunction(UObject MaterialFunction,UClass ExpressionClass,int NodePosX=0,int NodePosY=0,UObject ReturnValue) { return default; }
	public void DeleteAllMaterialExpressionsInFunction(UObject MaterialFunction) {}
	public void DeleteMaterialExpressionInFunction(UObject MaterialFunction,UObject Expression) {}
	public void UpdateMaterialFunction(UObject MaterialFunction,UObject PreviewMaterial=nullptr) {}
	public void LayoutMaterialFunctionExpressions(UObject MaterialFunction) {}
	public void SetMaterialInstanceParent(UObject Instance,UObject NewParent) {}
	public void ClearAllMaterialInstanceParameters(UObject Instance) {}
	public float GetMaterialInstanceScalarParameterValue(UObject Instance,sbyte ParameterName,EMaterialParameterAssociation Association=EMaterialParameterAssociation,float ReturnValue) { return default; }
	public bool SetMaterialInstanceScalarParameterValue(UObject Instance,sbyte ParameterName,float Value,EMaterialParameterAssociation Association=EMaterialParameterAssociation,bool ReturnValue) { return default; }
	public UObject GetMaterialInstanceTextureParameterValue(UObject Instance,sbyte ParameterName,EMaterialParameterAssociation Association=EMaterialParameterAssociation,UObject ReturnValue) { return default; }
	public bool SetMaterialInstanceTextureParameterValue(UObject Instance,sbyte ParameterName,UObject Value,EMaterialParameterAssociation Association=EMaterialParameterAssociation,bool ReturnValue) { return default; }
	public UObject GetMaterialInstanceRuntimeVirtualTextureParameterValue(UObject Instance,sbyte ParameterName,EMaterialParameterAssociation Association=EMaterialParameterAssociation,UObject ReturnValue) { return default; }
	public bool SetMaterialInstanceRuntimeVirtualTextureParameterValue(UObject Instance,sbyte ParameterName,UObject Value,EMaterialParameterAssociation Association=EMaterialParameterAssociation,bool ReturnValue) { return default; }
	public UObject GetMaterialInstanceSparseVolumeTextureParameterValue(UObject Instance,sbyte ParameterName,EMaterialParameterAssociation Association=EMaterialParameterAssociation,UObject ReturnValue) { return default; }
	public bool SetMaterialInstanceSparseVolumeTextureParameterValue(UObject Instance,sbyte ParameterName,UObject Value,EMaterialParameterAssociation Association=EMaterialParameterAssociation,bool ReturnValue) { return default; }
	public FLinearColor GetMaterialInstanceVectorParameterValue(UObject Instance,sbyte ParameterName,EMaterialParameterAssociation Association=EMaterialParameterAssociation,FLinearColor ReturnValue) { return default; }
	public bool SetMaterialInstanceVectorParameterValue(UObject Instance,sbyte ParameterName,FLinearColor Value,EMaterialParameterAssociation Association=EMaterialParameterAssociation,bool ReturnValue) { return default; }
	public bool GetMaterialInstanceStaticSwitchParameterValue(UObject Instance,sbyte ParameterName,EMaterialParameterAssociation Association=EMaterialParameterAssociation,bool ReturnValue) { return default; }
	public bool SetMaterialInstanceStaticSwitchParameterValue(UObject Instance,sbyte ParameterName,bool Value,EMaterialParameterAssociation Association=EMaterialParameterAssociation,bool ReturnValue) { return default; }
	public void UpdateMaterialInstance(UObject Instance) {}
	public void GetChildInstances(UObject Parent,TArray<FAssetData> ChildInstances) {}
	public void GetScalarParameterNames(UObject Material,TArray<sbyte> ParameterNames) {}
	public void GetVectorParameterNames(UObject Material,TArray<sbyte> ParameterNames) {}
	public void GetTextureParameterNames(UObject Material,TArray<sbyte> ParameterNames) {}
	public void GetStaticSwitchParameterNames(UObject Material,TArray<sbyte> ParameterNames) {}
	public bool GetScalarParameterSource(UObject Material,sbyte ParameterName,FSoftObjectPath ParameterSource,bool ReturnValue) { return default; }
	public bool GetVectorParameterSource(UObject Material,sbyte ParameterName,FSoftObjectPath ParameterSource,bool ReturnValue) { return default; }
	public bool GetTextureParameterSource(UObject Material,sbyte ParameterName,FSoftObjectPath ParameterSource,bool ReturnValue) { return default; }
	public bool GetStaticSwitchParameterSource(UObject Material,sbyte ParameterName,FSoftObjectPath ParameterSource,bool ReturnValue) { return default; }
	public FMaterialStatistics GetStatistics(UObject Material,FMaterialStatistics ReturnValue) { return default; }
}
