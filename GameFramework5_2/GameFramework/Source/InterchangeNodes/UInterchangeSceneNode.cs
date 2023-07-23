#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeSceneNode.h")]
///<summary>The scene node represent a transform node in the scene</summary>
public partial class UInterchangeSceneNode : UInterchangeBaseNode {
// InterchangeSceneNode
	public bool IsSpecializedTypeContains(sbyte SpecializedType,bool ReturnValue) { return default; }
	public int GetSpecializedTypeCount(int ReturnValue) { return default; }
	public void GetSpecializedType(int Index,sbyte OutSpecializedType) {}
	public void GetSpecializedTypes(TArray<sbyte> OutSpecializedTypes) {}
	public bool AddSpecializedType(sbyte SpecializedType,bool ReturnValue) { return default; }
	public bool RemoveSpecializedType(sbyte SpecializedType,bool ReturnValue) { return default; }
	public bool GetCustomAssetInstanceUid(sbyte AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomAssetInstanceUid(sbyte AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomLocalTransform(FTransform AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomLocalTransform(UObject BaseNodeContainer,FTransform AttributeValue,bool bResetCache=true,bool ReturnValue) { return default; }
	public bool GetCustomGlobalTransform(UObject BaseNodeContainer,FTransform GlobalOffsetTransform,FTransform AttributeValue,bool bForceRecache=false,bool ReturnValue) { return default; }
	public bool GetCustomGeometricTransform(FTransform AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomGeometricTransform(FTransform AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomBindPoseLocalTransform(FTransform AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomBindPoseLocalTransform(UObject BaseNodeContainer,FTransform AttributeValue,bool bResetCache=true,bool ReturnValue) { return default; }
	public bool GetCustomBindPoseGlobalTransform(UObject BaseNodeContainer,FTransform GlobalOffsetTransform,FTransform AttributeValue,bool bForceRecache=false,bool ReturnValue) { return default; }
	public bool GetCustomTimeZeroLocalTransform(FTransform AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomTimeZeroLocalTransform(UObject BaseNodeContainer,FTransform AttributeValue,bool bResetCache=true,bool ReturnValue) { return default; }
	public bool GetCustomTimeZeroGlobalTransform(UObject BaseNodeContainer,FTransform GlobalOffsetTransform,FTransform AttributeValue,bool bForceRecache=false,bool ReturnValue) { return default; }
	public void GetSlotMaterialDependencies(TMap<sbyte,sbyte> OutMaterialDependencies) {}
	public bool GetSlotMaterialDependencyUid(sbyte SlotName,sbyte OutMaterialDependency,bool ReturnValue) { return default; }
	public bool SetSlotMaterialDependencyUid(sbyte SlotName,sbyte MaterialDependencyUid,bool ReturnValue) { return default; }
	public bool RemoveSlotMaterialDependencyUid(sbyte SlotName,bool ReturnValue) { return default; }
}
