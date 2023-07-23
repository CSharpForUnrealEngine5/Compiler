#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObjectInstance.h")]
public partial class UCustomizableObjectInstance : UObject {
// CustomizableObjectInstance
	public FBeginUpdateDelegate BeginUpdateDelegate;
	public FObjectInstanceUpdatedDelegate UpdatedDelegate;
	public FBeginDestroyDelegate BeginDestroyDelegate;
	public TArray<USkeletalMesh> SkeletalMeshes;
	public sbyte SkeletalMeshStatus;
	public void SetObject(UObject InObject) {}
	public UObject GetCustomizableObject(UObject ReturnValue) { return default; }
	public bool GetBuildParameterDecorations(bool ReturnValue) { return default; }
	public void SetBuildParameterDecorations(bool Value) {}
	public sbyte GetCurrentState(sbyte ReturnValue) { return default; }
	public void SetCurrentState(sbyte StateName) {}
	public UObject GetSkeletalMesh(int ComponentIndex=0,UObject ReturnValue) { return default; }
	public bool HasAnySkeletalMesh(bool ReturnValue) { return default; }
	public TArray<FCustomizableObjectBoolParameterValue> GetBoolParameters(TArray<FCustomizableObjectBoolParameterValue> ReturnValue) { return default; }
	public TArray<FCustomizableObjectIntParameterValue> GetIntParameters(TArray<FCustomizableObjectIntParameterValue> ReturnValue) { return default; }
	public TArray<FCustomizableObjectFloatParameterValue> GetFloatParameters(TArray<FCustomizableObjectFloatParameterValue> ReturnValue) { return default; }
	public TArray<FCustomizableObjectTextureParameterValue> GetTextureParameters(TArray<FCustomizableObjectTextureParameterValue> ReturnValue) { return default; }
	public TArray<FCustomizableObjectVectorParameterValue> GetVectorParameters(TArray<FCustomizableObjectVectorParameterValue> ReturnValue) { return default; }
	public TArray<FCustomizableObjectProjectorParameterValue> GetProjectorParameters(TArray<FCustomizableObjectProjectorParameterValue> ReturnValue) { return default; }
	public bool HasAnyParameters(bool ReturnValue) { return default; }
	public void SetRandomValues() {}
	public void UpdateSkeletalMeshAsync(bool bIgnoreCloseDist=false,bool bForceHighPriority=false) {}
	public UObject Clone(UObject ReturnValue) { return default; }
	public UObject CloneStatic(UObject Outer,UObject ReturnValue) { return default; }
	public UObject GetParameterDescription(sbyte ParamName,int DescIndex,UObject ReturnValue) { return default; }
	public bool IsParameterRelevant(sbyte ParamName,bool ReturnValue) { return default; }
	public bool IsParamMultidimensional(sbyte ParamName,bool ReturnValue) { return default; }
	public int GetProjectorValueRange(sbyte ParamName,int ReturnValue) { return default; }
	public sbyte GetIntParameterSelectedOption(sbyte ParamName,int RangeIndex=-1,sbyte ReturnValue) { return default; }
	public void SetIntParameterSelectedOption(sbyte ParamName,sbyte SelectedOptionName,int RangeIndex=-1) {}
	public float GetFloatParameterSelectedOption(sbyte FloatParamName,int RangeIndex=-1,float ReturnValue) { return default; }
	public void SetFloatParameterSelectedOption(sbyte FloatParamName,float FloatValue,int RangeIndex=-1) {}
	public UObject GetTextureParameterSelectedOptionT(sbyte TextureParamName,int RangeIndex=-1,UObject ReturnValue) { return default; }
	public void SetTextureParameterSelectedOptionT(sbyte TextureParamName,UObject TextureValue,int RangeIndex=-1) {}
	public FLinearColor GetColorParameterSelectedOption(sbyte ColorParamName,FLinearColor ReturnValue) { return default; }
	public void SetColorParameterSelectedOption(sbyte ColorParamName,FLinearColor ColorValue) {}
	public bool GetBoolParameterSelectedOption(sbyte BoolParamName,bool ReturnValue) { return default; }
	public void SetBoolParameterSelectedOption(sbyte BoolParamName,bool BoolValue) {}
	public void SetVectorParameterSelectedOption(sbyte VectorParamName,FLinearColor VectorValue) {}
	public void SetProjectorValue(sbyte ProjectorParamName,FVector OutPos,FVector OutDirection,FVector OutUp,FVector OutScale,float OutAngle,int RangeIndex=-1) {}
	public void GetProjectorValue(sbyte ProjectorParamName,FVector OutPos,FVector OutDirection,FVector OutUp,FVector OutScale,float OutAngle,ECustomizableObjectProjectorType OutType,int RangeIndex=-1) {}
	public FVector GetProjectorPosition(sbyte ParamName,int RangeIndex=-1,FVector ReturnValue) { return default; }
	public FVector GetProjectorDirection(sbyte ParamName,int RangeIndex=-1,FVector ReturnValue) { return default; }
	public FVector GetProjectorUp(sbyte ParamName,int RangeIndex=-1,FVector ReturnValue) { return default; }
	public FVector GetProjectorScale(sbyte ParamName,int RangeIndex=-1,FVector ReturnValue) { return default; }
	public float GetProjectorAngle(sbyte ParamName,int RangeIndex=-1,float ReturnValue) { return default; }
	public ECustomizableObjectProjectorType GetProjectorParameterType(sbyte ParamName,int RangeIndex=-1,ECustomizableObjectProjectorType ReturnValue) { return default; }
	public int FindIntParameterNameIndex(sbyte ParamName,int ReturnValue) { return default; }
	public int FindFloatParameterNameIndex(sbyte ParamName,int ReturnValue) { return default; }
	public int FindBoolParameterNameIndex(sbyte ParamName,int ReturnValue) { return default; }
	public int FindVectorParameterNameIndex(sbyte ParamName,int ReturnValue) { return default; }
	public int FindProjectorParameterNameIndex(sbyte ParamName,int ReturnValue) { return default; }
	public int AddValueToIntRange(sbyte ParamName,int ReturnValue) { return default; }
	public int AddValueToFloatRange(sbyte ParamName,int ReturnValue) { return default; }
	public int AddValueToProjectorRange(sbyte ParamName,int ReturnValue) { return default; }
	public int RemoveValueFromIntRange(sbyte ParamName,int ReturnValue) { return default; }
	public int RemoveValueFromFloatRange(sbyte ParamName,int ReturnValue) { return default; }
	public int RemoveValueFromProjectorRange(sbyte ParamName,int ReturnValue) { return default; }
	public bool CreateMultiLayerProjector(sbyte ProjectorParamName,bool ReturnValue) { return default; }
	public void RemoveMultilayerProjector(sbyte ProjectorParamName) {}
	public int MultilayerProjectorNumLayers(sbyte ProjectorParamName,int ReturnValue) { return default; }
	public void MultilayerProjectorCreateLayer(sbyte ProjectorParamName,int Index) {}
	public void MultilayerProjectorRemoveLayerAt(sbyte ProjectorParamName,int Index) {}
	public FMultilayerProjectorLayer MultilayerProjectorGetLayer(sbyte ProjectorParamName,int Index,FMultilayerProjectorLayer ReturnValue) { return default; }
	public void MultilayerProjectorUpdateLayer(sbyte ProjectorParamName,int Index,FMultilayerProjectorLayer Layer) {}
	public TArray<sbyte> MultilayerProjectorGetVirtualLayers(sbyte ProjectorParamName,TArray<sbyte> ReturnValue) { return default; }
	public void MultilayerProjectorCreateVirtualLayer(sbyte ProjectorParamName,sbyte Id) {}
	public FMultilayerProjectorVirtualLayer MultilayerProjectorFindOrCreateVirtualLayer(sbyte ProjectorParamName,sbyte Id,FMultilayerProjectorVirtualLayer ReturnValue) { return default; }
	public void MultilayerProjectorRemoveVirtualLayer(sbyte ProjectorParamName,sbyte Id) {}
	public FMultilayerProjectorVirtualLayer MultilayerProjectorGetVirtualLayer(sbyte ProjectorParamName,sbyte Id,FMultilayerProjectorVirtualLayer ReturnValue) { return default; }
	public void MultilayerProjectorUpdateVirtualLayer(sbyte ProjectorParamName,sbyte Id,FMultilayerProjectorVirtualLayer Layer) {}
	public UClass GetAnimBP(int ComponentIndex,int SlotIndex,UClass ReturnValue) { return default; }
	public FGameplayTagContainer GetAnimationGameplayTags(FGameplayTagContainer ReturnValue) { return default; }
	public void ForEachAnimInstance(int ComponentIndex,FEachComponentAnimInstanceClassDelegate Delegate) {}
	public void SetReplacePhysicsAssets(bool bReplaceEnabled) {}
	public FCustomizableObjectInstanceDescriptor Descriptor;
	public UCustomizableInstancePrivateData PrivateData;
	public TArray<UTexture2D> TextureParameterDeclarations;
	public UCustomizableObject CustomizableObject_DEPRECATED;
	public TArray<FCustomizableObjectBoolParameterValue> BoolParameters_DEPRECATED;
	public TArray<FCustomizableObjectIntParameterValue> IntParameters_DEPRECATED;
	public TArray<FCustomizableObjectFloatParameterValue> FloatParameters_DEPRECATED;
	public TArray<FCustomizableObjectTextureParameterValue> TextureParameters_DEPRECATED;
	public TArray<FCustomizableObjectVectorParameterValue> VectorParameters_DEPRECATED;
	public TArray<FCustomizableObjectProjectorParameterValue> ProjectorParameters_DEPRECATED;
	public TMap<sbyte,FMultilayerProjector> MultilayerProjectors_DEPRECATED;
	public bool bBuildParameterDecorations_DEPRECATED;
}
