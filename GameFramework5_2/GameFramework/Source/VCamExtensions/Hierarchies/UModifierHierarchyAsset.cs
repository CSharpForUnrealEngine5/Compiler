#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Hierarchies/ModifierHierarchyAsset.h")]
///<summary>An asset intended to be referenced by Slate widgets.</summary>
public partial class UModifierHierarchyAsset : UObject {
// ModifierHierarchyAsset
	public UModifierHierarchyRules Rules;
	public sbyte GetRootNode(sbyte ReturnValue) { return default; }
	public bool GetParentNode(sbyte ChildNode,sbyte ParentNode,bool ReturnValue) { return default; }
	public TSet<sbyte> GetChildNodes(sbyte ParentGroup,TSet<sbyte> ReturnValue) { return default; }
	public UObject GetModifierInNode(UObject Component,sbyte GroupName,UObject ReturnValue) { return default; }
	public bool GetConnectionPointTargetForNode(sbyte GroupName,UObject Component,FVCamModifierConnectionBinding Connection,bool ReturnValue) { return default; }
	public TSet<sbyte> GetGroupsContainingModifier(UObject Modifier,TSet<sbyte> ReturnValue) { return default; }
}
