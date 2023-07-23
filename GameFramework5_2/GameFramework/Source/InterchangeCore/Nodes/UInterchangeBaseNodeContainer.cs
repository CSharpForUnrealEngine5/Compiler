#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/InterchangeBaseNodeContainer.h")]
///<summary>Interchange UInterchangeBaseNode graph is a format used to feed asset/scene import/reimport/export factories/writer.</summary>
public partial class UInterchangeBaseNodeContainer : UObject {
// InterchangeBaseNodeContainer
	public sbyte AddNode(UObject Node,sbyte ReturnValue) { return default; }
	public bool IsNodeUidValid(sbyte NodeUniqueID,bool ReturnValue) { return default; }
	public void GetRoots(TArray<sbyte> RootNodes) {}
	public void GetNodes(UClass ClassNode,TArray<sbyte> OutNodes) {}
	public UObject GetNode(sbyte NodeUniqueID,UObject ReturnValue) { return default; }
	public UObject GetFactoryNode(sbyte NodeUniqueID,UObject ReturnValue) { return default; }
	public bool SetNodeParentUid(sbyte NodeUniqueID,sbyte NewParentNodeUid,bool ReturnValue) { return default; }
	public int GetNodeChildrenCount(sbyte NodeUniqueID,int ReturnValue) { return default; }
	public TArray<sbyte> GetNodeChildrenUids(sbyte NodeUniqueID,TArray<sbyte> ReturnValue) { return default; }
	public UObject GetNodeChildren(sbyte NodeUniqueID,int ChildIndex,UObject ReturnValue) { return default; }
	public void SaveToFile(sbyte Filename) {}
	public void LoadFromFile(sbyte Filename) {}
	public void ComputeChildrenCache() {}
	public void ResetChildrenCache() {}
	public TMap<sbyte,UInterchangeBaseNode> Nodes;
}
