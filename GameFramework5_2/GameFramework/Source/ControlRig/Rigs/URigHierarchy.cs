#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigHierarchy.h")]
public partial class URigHierarchy : UObject {
// RigHierarchy
	public void Reset() {}
	public void ResetToDefault() {}
	public void CopyHierarchy(UObject InHierarchy) {}
	public void CopyPose(UObject InHierarchy,bool bCurrent,bool bInitial,bool bWeights,bool bMatchPoseInGlobalIfNeeded=false) {}
	public void ResetPoseToInitial(ERigElementType InTypeFilter) {}
	public void ResetCurveValues() {}
	public int Num(int ReturnValue) { return default; }
	public bool IsValidIndex(int InElementIndex,bool ReturnValue) { return default; }
	public bool Contains_ForBlueprint(FRigElementKey InKey,bool ReturnValue) { return default; }
	public bool IsProcedural(FRigElementKey InKey,bool ReturnValue) { return default; }
	public int GetIndex_ForBlueprint(FRigElementKey InKey,int ReturnValue) { return default; }
	public int GetLocalIndex_ForBlueprint(FRigElementKey InKey,int ReturnValue) { return default; }
	public FRigElementKey GetKey(int InElementIndex,FRigElementKey ReturnValue) { return default; }
	public TArray<FRigElementKey> GetKeys(TArray<int> InElementIndices,TArray<FRigElementKey> ReturnValue) { return default; }
	public FRigBoneElement FindBone_ForBlueprintOnly(FRigElementKey InKey,FRigBoneElement ReturnValue) { return default; }
	public FRigControlElement FindControl_ForBlueprintOnly(FRigElementKey InKey,FRigControlElement ReturnValue) { return default; }
	public FRigNullElement FindNull_ForBlueprintOnly(FRigElementKey InKey,FRigNullElement ReturnValue) { return default; }
	public TArray<FRigElementKey> GetBoneKeys(bool bTraverse=true,TArray<FRigElementKey> ReturnValue) { return default; }
	public TArray<FRigElementKey> GetNullKeys(bool bTraverse=true,TArray<FRigElementKey> ReturnValue) { return default; }
	public TArray<FRigElementKey> GetControlKeys(bool bTraverse=true,TArray<FRigElementKey> ReturnValue) { return default; }
	public TArray<FRigElementKey> GetCurveKeys(TArray<FRigElementKey> ReturnValue) { return default; }
	public TArray<FRigElementKey> GetRigidBodyKeys(bool bTraverse=true,TArray<FRigElementKey> ReturnValue) { return default; }
	public TArray<FRigElementKey> GetReferenceKeys(bool bTraverse=true,TArray<FRigElementKey> ReturnValue) { return default; }
	public TArray<FRigElementKey> GetRootElementKeys(TArray<FRigElementKey> ReturnValue) { return default; }
	public TArray<sbyte> GetMetadataNames(FRigElementKey InItem,TArray<sbyte> ReturnValue) { return default; }
	public ERigMetadataType GetMetadataType(FRigElementKey InItem,sbyte InMetadataName,ERigMetadataType ReturnValue) { return default; }
	public bool RemoveMetadata(FRigElementKey InItem,sbyte InMetadataName,bool ReturnValue) { return default; }
	public bool RemoveAllMetadata(FRigElementKey InItem,bool ReturnValue) { return default; }
	public bool GetBoolMetadata(FRigElementKey InItem,sbyte InMetadataName,bool DefaultValue,bool ReturnValue) { return default; }
	public TArray<bool> GetBoolArrayMetadata(FRigElementKey InItem,sbyte InMetadataName,TArray<bool> ReturnValue) { return default; }
	public bool SetBoolMetadata(FRigElementKey InItem,sbyte InMetadataName,bool InValue,bool ReturnValue) { return default; }
	public bool SetBoolArrayMetadata(FRigElementKey InItem,sbyte InMetadataName,TArray<bool> InValue,bool ReturnValue) { return default; }
	public float GetFloatMetadata(FRigElementKey InItem,sbyte InMetadataName,float DefaultValue,float ReturnValue) { return default; }
	public TArray<float> GetFloatArrayMetadata(FRigElementKey InItem,sbyte InMetadataName,TArray<float> ReturnValue) { return default; }
	public bool SetFloatMetadata(FRigElementKey InItem,sbyte InMetadataName,float InValue,bool ReturnValue) { return default; }
	public bool SetFloatArrayMetadata(FRigElementKey InItem,sbyte InMetadataName,TArray<float> InValue,bool ReturnValue) { return default; }
	public int GetInt32Metadata(FRigElementKey InItem,sbyte InMetadataName,int DefaultValue,int ReturnValue) { return default; }
	public TArray<int> GetInt32ArrayMetadata(FRigElementKey InItem,sbyte InMetadataName,TArray<int> ReturnValue) { return default; }
	public bool SetInt32Metadata(FRigElementKey InItem,sbyte InMetadataName,int InValue,bool ReturnValue) { return default; }
	public bool SetInt32ArrayMetadata(FRigElementKey InItem,sbyte InMetadataName,TArray<int> InValue,bool ReturnValue) { return default; }
	public sbyte GetNameMetadata(FRigElementKey InItem,sbyte InMetadataName,sbyte DefaultValue,sbyte ReturnValue) { return default; }
	public TArray<sbyte> GetNameArrayMetadata(FRigElementKey InItem,sbyte InMetadataName,TArray<sbyte> ReturnValue) { return default; }
	public bool SetNameMetadata(FRigElementKey InItem,sbyte InMetadataName,sbyte InValue,bool ReturnValue) { return default; }
	public bool SetNameArrayMetadata(FRigElementKey InItem,sbyte InMetadataName,TArray<sbyte> InValue,bool ReturnValue) { return default; }
	public FVector GetVectorMetadata(FRigElementKey InItem,sbyte InMetadataName,FVector DefaultValue,FVector ReturnValue) { return default; }
	public TArray<FVector> GetVectorArrayMetadata(FRigElementKey InItem,sbyte InMetadataName,TArray<FVector> ReturnValue) { return default; }
	public bool SetVectorMetadata(FRigElementKey InItem,sbyte InMetadataName,FVector InValue,bool ReturnValue) { return default; }
	public bool SetVectorArrayMetadata(FRigElementKey InItem,sbyte InMetadataName,TArray<FVector> InValue,bool ReturnValue) { return default; }
	public FRotator GetRotatorMetadata(FRigElementKey InItem,sbyte InMetadataName,FRotator DefaultValue,FRotator ReturnValue) { return default; }
	public TArray<FRotator> GetRotatorArrayMetadata(FRigElementKey InItem,sbyte InMetadataName,TArray<FRotator> ReturnValue) { return default; }
	public bool SetRotatorMetadata(FRigElementKey InItem,sbyte InMetadataName,FRotator InValue,bool ReturnValue) { return default; }
	public bool SetRotatorArrayMetadata(FRigElementKey InItem,sbyte InMetadataName,TArray<FRotator> InValue,bool ReturnValue) { return default; }
	public FQuat GetQuatMetadata(FRigElementKey InItem,sbyte InMetadataName,FQuat DefaultValue,FQuat ReturnValue) { return default; }
	public TArray<FQuat> GetQuatArrayMetadata(FRigElementKey InItem,sbyte InMetadataName,TArray<FQuat> ReturnValue) { return default; }
	public bool SetQuatMetadata(FRigElementKey InItem,sbyte InMetadataName,FQuat InValue,bool ReturnValue) { return default; }
	public bool SetQuatArrayMetadata(FRigElementKey InItem,sbyte InMetadataName,TArray<FQuat> InValue,bool ReturnValue) { return default; }
	public FTransform GetTransformMetadata(FRigElementKey InItem,sbyte InMetadataName,FTransform DefaultValue,FTransform ReturnValue) { return default; }
	public TArray<FTransform> GetTransformArrayMetadata(FRigElementKey InItem,sbyte InMetadataName,TArray<FTransform> ReturnValue) { return default; }
	public bool SetTransformMetadata(FRigElementKey InItem,sbyte InMetadataName,FTransform InValue,bool ReturnValue) { return default; }
	public bool SetTransformArrayMetadata(FRigElementKey InItem,sbyte InMetadataName,TArray<FTransform> InValue,bool ReturnValue) { return default; }
	public FLinearColor GetLinearColorMetadata(FRigElementKey InItem,sbyte InMetadataName,FLinearColor DefaultValue,FLinearColor ReturnValue) { return default; }
	public TArray<FLinearColor> GetLinearColorArrayMetadata(FRigElementKey InItem,sbyte InMetadataName,TArray<FLinearColor> ReturnValue) { return default; }
	public bool SetLinearColorMetadata(FRigElementKey InItem,sbyte InMetadataName,FLinearColor InValue,bool ReturnValue) { return default; }
	public bool SetLinearColorArrayMetadata(FRigElementKey InItem,sbyte InMetadataName,TArray<FLinearColor> InValue,bool ReturnValue) { return default; }
	public FRigElementKey GetRigElementKeyMetadata(FRigElementKey InItem,sbyte InMetadataName,FRigElementKey DefaultValue,FRigElementKey ReturnValue) { return default; }
	public TArray<FRigElementKey> GetRigElementKeyArrayMetadata(FRigElementKey InItem,sbyte InMetadataName,TArray<FRigElementKey> ReturnValue) { return default; }
	public bool SetRigElementKeyMetadata(FRigElementKey InItem,sbyte InMetadataName,FRigElementKey InValue,bool ReturnValue) { return default; }
	public bool SetRigElementKeyArrayMetadata(FRigElementKey InItem,sbyte InMetadataName,TArray<FRigElementKey> InValue,bool ReturnValue) { return default; }
	public TArray<sbyte> GetTags(FRigElementKey InItem,TArray<sbyte> ReturnValue) { return default; }
	public bool HasTag(FRigElementKey InItem,sbyte InTag,bool ReturnValue) { return default; }
	public bool SetTag(FRigElementKey InItem,sbyte InTag,bool ReturnValue) { return default; }
	public TArray<FRigElementKey> GetSelectedKeys(ERigElementType InTypeFilter=ERigElementType,TArray<FRigElementKey> ReturnValue) { return default; }
	public bool IsSelected(FRigElementKey InKey,bool ReturnValue) { return default; }
	public bool IsSelectedByIndex(int InIndex,bool ReturnValue) { return default; }
	public TArray<FRigElementKey> SortKeys(TArray<FRigElementKey> InKeys,TArray<FRigElementKey> ReturnValue) { return default; }
	public FTransform GetLocalTransform(FRigElementKey InKey,bool bInitial=false,FTransform ReturnValue) { return default; }
	public FTransform GetLocalTransformByIndex(int InElementIndex,bool bInitial=false,FTransform ReturnValue) { return default; }
	public void SetLocalTransform(FRigElementKey InKey,FTransform InTransform,bool bInitial=false,bool bAffectChildren=true,bool bSetupUndo=false,bool bPrintPythonCommands=false) {}
	public void SetLocalTransformByIndex(int InElementIndex,FTransform InTransform,bool bInitial=false,bool bAffectChildren=true,bool bSetupUndo=false,bool bPrintPythonCommands=false) {}
	public FTransform GetGlobalTransform(FRigElementKey InKey,bool bInitial=false,FTransform ReturnValue) { return default; }
	public FTransform GetGlobalTransformByIndex(int InElementIndex,bool bInitial=false,FTransform ReturnValue) { return default; }
	public void SetGlobalTransform(FRigElementKey InKey,FTransform InTransform,bool bInitial=false,bool bAffectChildren=true,bool bSetupUndo=false,bool bPrintPythonCommand=false) {}
	public void SetGlobalTransformByIndex(int InElementIndex,FTransform InTransform,bool bInitial=false,bool bAffectChildren=true,bool bSetupUndo=false,bool bPrintPythonCommand=false) {}
	public FTransform GetGlobalControlOffsetTransform(FRigElementKey InKey,bool bInitial=false,FTransform ReturnValue) { return default; }
	public FTransform GetGlobalControlOffsetTransformByIndex(int InElementIndex,bool bInitial=false,FTransform ReturnValue) { return default; }
	public FTransform GetLocalControlShapeTransform(FRigElementKey InKey,bool bInitial=false,FTransform ReturnValue) { return default; }
	public FTransform GetLocalControlShapeTransformByIndex(int InElementIndex,bool bInitial=false,FTransform ReturnValue) { return default; }
	public FTransform GetGlobalControlShapeTransform(FRigElementKey InKey,bool bInitial=false,FTransform ReturnValue) { return default; }
	public FTransform GetGlobalControlShapeTransformByIndex(int InElementIndex,bool bInitial=false,FTransform ReturnValue) { return default; }
	public FRigControlValue GetControlValue(FRigElementKey InKey,ERigControlValueType InValueType=ERigControlValueType,FRigControlValue ReturnValue) { return default; }
	public FRigControlValue GetControlValueByIndex(int InElementIndex,ERigControlValueType InValueType=ERigControlValueType,FRigControlValue ReturnValue) { return default; }
	public FRotator GetControlPreferredRotator(FRigElementKey InKey,bool bInitial=false,FRotator ReturnValue) { return default; }
	public FRotator GetControlPreferredRotatorByIndex(int InElementIndex,bool bInitial=false,FRotator ReturnValue) { return default; }
	public void SetControlPreferredRotator(FRigElementKey InKey,FRotator InValue,bool bInitial=false,bool bFixEulerFlips=false) {}
	public void SetControlPreferredRotatorByIndex(int InElementIndex,FRotator InValue,bool bInitial=false,bool bFixEulerFlips=false) {}
	public void SetControlValue(FRigElementKey InKey,FRigControlValue InValue,ERigControlValueType InValueType=ERigControlValueType,bool bSetupUndo=false,bool bPrintPythonCommands=false) {}
	public void SetControlValueByIndex(int InElementIndex,FRigControlValue InValue,ERigControlValueType InValueType=ERigControlValueType,bool bSetupUndo=false,bool bPrintPythonCommands=false) {}
	public void SetControlVisibility(FRigElementKey InKey,bool bVisibility) {}
	public void SetControlVisibilityByIndex(int InElementIndex,bool bVisibility) {}
	public float GetCurveValue(FRigElementKey InKey,float ReturnValue) { return default; }
	public float GetCurveValueByIndex(int InElementIndex,float ReturnValue) { return default; }
	public bool IsCurveValueSet(FRigElementKey InKey,bool ReturnValue) { return default; }
	public bool IsCurveValueSetByIndex(int InElementIndex,bool ReturnValue) { return default; }
	public void SetCurveValue(FRigElementKey InKey,float InValue,bool bSetupUndo=false) {}
	public void SetCurveValueByIndex(int InElementIndex,float InValue,bool bSetupUndo=false) {}
	public void UnsetCurveValue(FRigElementKey InKey,bool bSetupUndo=false) {}
	public void UnsetCurveValueByIndex(int InElementIndex,bool bSetupUndo=false) {}
	public void SetControlOffsetTransform(FRigElementKey InKey,FTransform InTransform,bool bInitial=false,bool bAffectChildren=true,bool bSetupUndo=false,bool bPrintPythonCommands=false) {}
	public void SetControlOffsetTransformByIndex(int InElementIndex,FTransform InTransform,bool bInitial=false,bool bAffectChildren=true,bool bSetupUndo=false,bool bPrintPythonCommands=false) {}
	public void SetControlShapeTransform(FRigElementKey InKey,FTransform InTransform,bool bInitial=false,bool bSetupUndo=false) {}
	public void SetControlShapeTransformByIndex(int InElementIndex,FTransform InTransform,bool bInitial=false,bool bSetupUndo=false) {}
	public void SetControlSettings(FRigElementKey InKey,FRigControlSettings InSettings,bool bSetupUndo=false,bool bForce=false,bool bPrintPythonCommands=false) {}
	public void SetControlSettingsByIndex(int InElementIndex,FRigControlSettings InSettings,bool bSetupUndo=false,bool bForce=false,bool bPrintPythonCommands=false) {}
	public FTransform GetParentTransform(FRigElementKey InKey,bool bInitial=false,FTransform ReturnValue) { return default; }
	public FTransform GetParentTransformByIndex(int InElementIndex,bool bInitial=false,FTransform ReturnValue) { return default; }
	public TArray<FRigElementKey> GetChildren(FRigElementKey InKey,bool bRecursive=false,TArray<FRigElementKey> ReturnValue) { return default; }
	public TArray<FRigElementKey> GetParents(FRigElementKey InKey,bool bRecursive=false,TArray<FRigElementKey> ReturnValue) { return default; }
	public FRigElementKey GetDefaultParent(FRigElementKey InKey,FRigElementKey ReturnValue) { return default; }
	public FRigElementKey GetFirstParent(FRigElementKey InKey,FRigElementKey ReturnValue) { return default; }
	public int GetNumberOfParents(FRigElementKey InKey,int ReturnValue) { return default; }
	public FRigElementWeight GetParentWeight(FRigElementKey InChild,FRigElementKey InParent,bool bInitial=false,FRigElementWeight ReturnValue) { return default; }
	public TArray<FRigElementWeight> GetParentWeightArray(FRigElementKey InChild,bool bInitial=false,TArray<FRigElementWeight> ReturnValue) { return default; }
	public bool SetParentWeight(FRigElementKey InChild,FRigElementKey InParent,FRigElementWeight InWeight,bool bInitial=false,bool bAffectChildren=true,bool ReturnValue) { return default; }
	public bool SetParentWeightArray(FRigElementKey InChild,TArray<FRigElementWeight> InWeights,bool bInitial=false,bool bAffectChildren=true,bool ReturnValue) { return default; }
	public bool SwitchToParent(FRigElementKey InChild,FRigElementKey InParent,bool bInitial=false,bool bAffectChildren=true,bool ReturnValue) { return default; }
	public bool SwitchToDefaultParent(FRigElementKey InChild,bool bInitial=false,bool bAffectChildren=true,bool ReturnValue) { return default; }
	public bool SwitchToWorldSpace(FRigElementKey InChild,bool bInitial=false,bool bAffectChildren=true,bool ReturnValue) { return default; }
	public bool IsParentedTo(FRigElementKey InChild,FRigElementKey InParent,bool ReturnValue) { return default; }
	public TArray<FRigElementKey> GetAllKeys_ForBlueprint(bool bTraverse=true,TArray<FRigElementKey> ReturnValue) { return default; }
	public void SendAutoKeyEvent(FRigElementKey InElement,float InOffsetInSeconds=0.f,bool bAsynchronous=true) {}
	public bool IsControllerAvailable(bool ReturnValue) { return default; }
	public UObject GetController(bool bCreateIfNeeded=true,UObject ReturnValue) { return default; }
	public FRigPose GetPose(bool bInitial=false,FRigPose ReturnValue) { return default; }
	public void SetPose_ForBlueprint(FRigPose InPose) {}
	public FRigControlValue MakeControlValueFromBool(bool InValue,FRigControlValue ReturnValue) { return default; }
	public FRigControlValue MakeControlValueFromFloat(float InValue,FRigControlValue ReturnValue) { return default; }
	public float GetFloatFromControlValue(FRigControlValue InValue,float ReturnValue) { return default; }
	public FRigControlValue MakeControlValueFromInt(int InValue,FRigControlValue ReturnValue) { return default; }
	public int GetIntFromControlValue(FRigControlValue InValue,int ReturnValue) { return default; }
	public FRigControlValue MakeControlValueFromVector2D(FVector2D InValue,FRigControlValue ReturnValue) { return default; }
	public FVector2D GetVector2DFromControlValue(FRigControlValue InValue,FVector2D ReturnValue) { return default; }
	public FRigControlValue MakeControlValueFromVector(FVector InValue,FRigControlValue ReturnValue) { return default; }
	public FVector GetVectorFromControlValue(FRigControlValue InValue,FVector ReturnValue) { return default; }
	public FRigControlValue MakeControlValueFromRotator(FRotator InValue,FRigControlValue ReturnValue) { return default; }
	public FRotator GetRotatorFromControlValue(FRigControlValue InValue,FRotator ReturnValue) { return default; }
	public FRigControlValue MakeControlValueFromTransform(FTransform InValue,FRigControlValue ReturnValue) { return default; }
	public FTransform GetTransformFromControlValue(FRigControlValue InValue,FTransform ReturnValue) { return default; }
	public FRigControlValue MakeControlValueFromEulerTransform(FEulerTransform InValue,FRigControlValue ReturnValue) { return default; }
	public FEulerTransform GetEulerTransformFromControlValue(FRigControlValue InValue,FEulerTransform ReturnValue) { return default; }
	public FRigControlValue MakeControlValueFromTransformNoScale(FTransformNoScale InValue,FRigControlValue ReturnValue) { return default; }
	public FTransformNoScale GetTransformNoScaleFromControlValue(FRigControlValue InValue,FTransformNoScale ReturnValue) { return default; }
	public sbyte GetPreviousName(FRigElementKey InKey,sbyte ReturnValue) { return default; }
	public FRigElementKey GetPreviousParent(FRigElementKey InKey,FRigElementKey ReturnValue) { return default; }
	public ushort TopologyVersion;
	public ushort MetadataVersion;
	public ushort MetadataTagVersion;
	public bool bEnableDirtyPropagation;
	public int TransformStackIndex;
	public URigHierarchyController HierarchyController;
	public TMap<FRigElementKey,FRigElementKey> PreviousNameMap;
	public URigHierarchy HierarchyForCacheValidation;
}
