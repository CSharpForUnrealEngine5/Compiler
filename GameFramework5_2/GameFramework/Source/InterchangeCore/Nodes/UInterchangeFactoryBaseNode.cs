#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/InterchangeFactoryBaseNode.h")]
///<summary>This struct is used to store and retrieve key value attributes. The attributes are store in a generic FAttributeStorage which serialize the value in a TArray64<uint8></summary>
public partial class UInterchangeFactoryBaseNode : UInterchangeBaseNode {
// InterchangeFactoryBaseNode
	public EReimportStrategyFlags GetReimportStrategyFlags(EReimportStrategyFlags ReturnValue) { return default; }
	public bool SetReimportStrategyFlags(EReimportStrategyFlags ReimportStrategyFlags,bool ReturnValue) { return default; }
	public bool GetCustomSubPath(sbyte AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomSubPath(sbyte AttributeValue,bool ReturnValue) { return default; }
	public int GetFactoryDependenciesCount(int ReturnValue) { return default; }
	public void GetFactoryDependencies(TArray<sbyte> OutDependencies) {}
	public void GetFactoryDependency(int Index,sbyte OutDependency) {}
	public bool AddFactoryDependencyUid(sbyte DependencyUid,bool ReturnValue) { return default; }
	public bool RemoveFactoryDependencyUid(sbyte DependencyUid,bool ReturnValue) { return default; }
	public bool GetCustomReferenceObject(FSoftObjectPath AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomReferenceObject(FSoftObjectPath AttributeValue,bool ReturnValue) { return default; }
}
