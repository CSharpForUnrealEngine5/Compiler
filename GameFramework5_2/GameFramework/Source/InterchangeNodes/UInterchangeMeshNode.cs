#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeMeshNode.h")]
///<summary>ns UE</summary>
public partial class UInterchangeMeshNode : UInterchangeBaseNode {
// InterchangeMeshNode
	public bool IsSkinnedMesh(bool ReturnValue) { return default; }
	public bool SetSkinnedMesh(bool bIsSkinnedMesh,bool ReturnValue) { return default; }
	public bool IsMorphTarget(bool ReturnValue) { return default; }
	public bool SetMorphTarget(bool bIsMorphTarget,bool ReturnValue) { return default; }
	public bool GetMorphTargetName(sbyte OutMorphTargetName,bool ReturnValue) { return default; }
	public bool SetMorphTargetName(sbyte MorphTargetName,bool ReturnValue) { return default; }
	public void SetPayLoadKey(sbyte PayloadKey) {}
	public void SetAnimationCurvePayLoadKey(sbyte PayloadKey) {}
	public bool GetCustomVertexCount(int AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomVertexCount(int AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomPolygonCount(int AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomPolygonCount(int AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomBoundingBox(FBox AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomBoundingBox(FBox AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomHasVertexNormal(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomHasVertexNormal(bool AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomHasVertexBinormal(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomHasVertexBinormal(bool AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomHasVertexTangent(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomHasVertexTangent(bool AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomHasSmoothGroup(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomHasSmoothGroup(bool AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomHasVertexColor(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomHasVertexColor(bool AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomUVCount(int AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomUVCount(int AttributeValue,bool ReturnValue) { return default; }
	public int GetSkeletonDependeciesCount(int ReturnValue) { return default; }
	public void GetSkeletonDependencies(TArray<sbyte> OutDependencies) {}
	public void GetSkeletonDependency(int Index,sbyte OutDependency) {}
	public bool SetSkeletonDependencyUid(sbyte DependencyUid,bool ReturnValue) { return default; }
	public bool RemoveSkeletonDependencyUid(sbyte DependencyUid,bool ReturnValue) { return default; }
	public int GetMorphTargetDependeciesCount(int ReturnValue) { return default; }
	public void GetMorphTargetDependencies(TArray<sbyte> OutDependencies) {}
	public void GetMorphTargetDependency(int Index,sbyte OutDependency) {}
	public bool SetMorphTargetDependencyUid(sbyte DependencyUid,bool ReturnValue) { return default; }
	public bool RemoveMorphTargetDependencyUid(sbyte DependencyUid,bool ReturnValue) { return default; }
	public int GetSceneInstanceUidsCount(int ReturnValue) { return default; }
	public void GetSceneInstanceUids(TArray<sbyte> OutDependencies) {}
	public void GetSceneInstanceUid(int Index,sbyte OutDependency) {}
	public bool SetSceneInstanceUid(sbyte DependencyUid,bool ReturnValue) { return default; }
	public bool RemoveSceneInstanceUid(sbyte DependencyUid,bool ReturnValue) { return default; }
	public void GetSlotMaterialDependencies(TMap<sbyte,sbyte> OutMaterialDependencies) {}
	public bool GetSlotMaterialDependencyUid(sbyte SlotName,sbyte OutMaterialDependency,bool ReturnValue) { return default; }
	public bool SetSlotMaterialDependencyUid(sbyte SlotName,sbyte MaterialDependencyUid,bool ReturnValue) { return default; }
	public bool RemoveSlotMaterialDependencyUid(sbyte SlotName,bool ReturnValue) { return default; }
}
