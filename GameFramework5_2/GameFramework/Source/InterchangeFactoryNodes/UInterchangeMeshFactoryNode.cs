#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeMeshFactoryNode.h")]
///<summary>namespace Interchange</summary>
public partial class UInterchangeMeshFactoryNode : UInterchangeFactoryBaseNode {
// InterchangeMeshFactoryNode
	public int GetLodDataCount(int ReturnValue) { return default; }
	public void GetLodDataUniqueIds(TArray<sbyte> OutLodDataUniqueIds) {}
	public bool AddLodDataUniqueId(sbyte LodDataUniqueId,bool ReturnValue) { return default; }
	public bool RemoveLodDataUniqueId(sbyte LodDataUniqueId,bool ReturnValue) { return default; }
	public bool GetCustomVertexColorReplace(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomVertexColorReplace(bool AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomVertexColorIgnore(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomVertexColorIgnore(bool AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomVertexColorOverride(FColor AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomVertexColorOverride(FColor AttributeValue,bool ReturnValue) { return default; }
	public void GetSlotMaterialDependencies(TMap<sbyte,sbyte> OutMaterialDependencies) {}
	public bool GetSlotMaterialDependencyUid(sbyte SlotName,sbyte OutMaterialDependency,bool ReturnValue) { return default; }
	public bool SetSlotMaterialDependencyUid(sbyte SlotName,sbyte MaterialDependencyUid,bool ReturnValue) { return default; }
	public bool RemoveSlotMaterialDependencyUid(sbyte SlotName,bool ReturnValue) { return default; }
	public bool GetCustomRecomputeNormals(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomRecomputeNormals(bool AttributeValue,bool bAddApplyDelegate=true,bool ReturnValue) { return default; }
	public bool GetCustomRecomputeTangents(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomRecomputeTangents(bool AttributeValue,bool bAddApplyDelegate=true,bool ReturnValue) { return default; }
	public bool GetCustomUseMikkTSpace(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomUseMikkTSpace(bool AttributeValue,bool bAddApplyDelegate=true,bool ReturnValue) { return default; }
	public bool GetCustomComputeWeightedNormals(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomComputeWeightedNormals(bool AttributeValue,bool bAddApplyDelegate=true,bool ReturnValue) { return default; }
	public bool GetCustomUseHighPrecisionTangentBasis(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomUseHighPrecisionTangentBasis(bool AttributeValue,bool bAddApplyDelegate=true,bool ReturnValue) { return default; }
	public bool GetCustomUseFullPrecisionUVs(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomUseFullPrecisionUVs(bool AttributeValue,bool bAddApplyDelegate=true,bool ReturnValue) { return default; }
	public bool GetCustomUseBackwardsCompatibleF16TruncUVs(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomUseBackwardsCompatibleF16TruncUVs(bool AttributeValue,bool bAddApplyDelegate=true,bool ReturnValue) { return default; }
	public bool GetCustomRemoveDegenerates(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomRemoveDegenerates(bool AttributeValue,bool bAddApplyDelegate=true,bool ReturnValue) { return default; }
}
