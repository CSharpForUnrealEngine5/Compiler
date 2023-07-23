#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeVariantSetNode.h")]
///<summary>Class to represent a set of variants</summary>
public partial class UInterchangeVariantSetNode : UInterchangeBaseNode {
// InterchangeVariantSetNode
	public bool GetCustomDisplayText(sbyte AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomDisplayText(sbyte AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomVariantsPayloadKey(sbyte PayloadKey,bool ReturnValue) { return default; }
	public bool SetCustomVariantsPayloadKey(sbyte PayloadKey,bool ReturnValue) { return default; }
	public int GetCustomDependencyUidCount(int ReturnValue) { return default; }
	public void GetCustomDependencyUids(TArray<sbyte> OutDependencyUids) {}
	public void GetCustomDependencyUid(int Index,sbyte OutDependencyUid) {}
	public bool AddCustomDependencyUid(sbyte DependencyUid,bool ReturnValue) { return default; }
	public bool RemoveCustomDependencyUid(sbyte DependencyUid,bool ReturnValue) { return default; }
}
