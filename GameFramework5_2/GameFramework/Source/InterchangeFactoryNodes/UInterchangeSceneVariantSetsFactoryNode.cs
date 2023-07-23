#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeSceneVariantSetsFactoryNode.h")]
public partial class UInterchangeSceneVariantSetsFactoryNode : UInterchangeFactoryBaseNode {
// InterchangeSceneVariantSetsFactoryNode
	public UClass GetObjectClass(UClass ReturnValue) { return default; }
	public int GetCustomVariantSetUidCount(int ReturnValue) { return default; }
	public void GetCustomVariantSetUids(TArray<sbyte> OutVariantUids) {}
	public void GetCustomVariantSetUid(int Index,sbyte OutVariantUid) {}
	public bool AddCustomVariantSetUid(sbyte VariantUid,bool ReturnValue) { return default; }
	public bool RemoveCustomVariantSetUid(sbyte VariantUid,bool ReturnValue) { return default; }
}
