#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Hierarchies/ModifierHierarchyRules.h")]
///<summary>Defines a tree hierarchy. Each node is called a group.</summary>
public partial class UModifierHierarchyRules : UObject {
// ModifierHierarchyRules
	public sbyte GetRootNode(sbyte ReturnValue) { return default; }
	public bool GetParentNode(sbyte ChildNode,sbyte ParentNode,bool ReturnValue) { return default; }
	public TSet<sbyte> GetChildNodes(sbyte Node,TSet<sbyte> ReturnValue) { return default; }
	public UObject GetModifierInNode(UObject Component,sbyte NodeName,UObject ReturnValue) { return default; }
	public bool GetConnectionPointTargetForNode(sbyte GroupName,UObject Component,FVCamModifierConnectionBinding Connection,bool ReturnValue) { return default; }
	public TSet<sbyte> GetNodesContainingModifier(UObject Modifier,TSet<sbyte> ReturnValue) { return default; }
}
