#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGGraph.h")]
public partial class UPCGGraph : UPCGGraphInterface {
// PCGGraph
	public bool bExposeToLibrary;
	public sbyte Category;
	public sbyte Description;
	public bool bLandscapeUsesMetadata;
	public UObject AddNodeOfType(UClass InSettingsClass,UObject DefaultNodeSettings,UObject ReturnValue) { return default; }
	public UObject AddNodeInstance(UObject InSettings,UObject ReturnValue) { return default; }
	public UObject AddNodeCopy(UObject InSettings,UObject DefaultNodeSettings,UObject ReturnValue) { return default; }
	public void RemoveNode(UObject InNode) {}
	public UObject AddEdge(UObject From,sbyte FromPinLabel,UObject To,sbyte ToPinLabel,UObject ReturnValue) { return default; }
	public bool RemoveEdge(UObject From,sbyte FromLabel,UObject To,sbyte ToLabel,bool ReturnValue) { return default; }
	public UObject GetInputNode(UObject ReturnValue) { return default; }
	public UObject GetOutputNode(UObject ReturnValue) { return default; }
	public void ForceNotificationForEditor() {}
	public TArray<UPCGNode> Nodes;
	public UPCGNode InputNode;
	public UPCGNode OutputNode;
	public TArray<UObject> ExtraEditorNodes;
	public FInstancedPropertyBag UserParameters;
}
