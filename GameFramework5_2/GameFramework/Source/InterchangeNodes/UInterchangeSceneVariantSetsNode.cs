#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeVariantSetNode.h")]
///<summary>Class to represent a set of VariantSet nodes</summary>
public partial class UInterchangeSceneVariantSetsNode : UInterchangeBaseNode {
// InterchangeSceneVariantSetsNode
	public int GetCustomVariantSetUidCount(int ReturnValue) { return default; }
	public void GetCustomVariantSetUids(TArray<sbyte> OutVariantUids) {}
	public void GetCustomVariantSetUid(int Index,sbyte OutVariantUid) {}
	public bool AddCustomVariantSetUid(sbyte VariantUid,bool ReturnValue) { return default; }
	public bool RemoveCustomVariantSetUid(sbyte VariantUid,bool ReturnValue) { return default; }
}
