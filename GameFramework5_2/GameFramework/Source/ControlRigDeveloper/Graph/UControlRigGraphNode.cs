#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graph/ControlRigGraphNode.h")]
///<summary>Base class for animation ControlRig-related nodes</summary>
public partial class UControlRigGraphNode : UEdGraphNode {
// ControlRigGraphNode
	public sbyte ModelNodePath;
	public TWeakObjectPtr<URigVMNode> CachedModelNode;
	public TMap<sbyte,TWeakObjectPtr<URigVMPin>> PinPathToModelPin;
	public sbyte PropertyName_DEPRECATED;
	public sbyte StructPath_DEPRECATED;
	public FEdGraphPinType PinType_DEPRECATED;
	public int ParameterType_DEPRECATED;
	public TArray<sbyte> ExpandedPins_DEPRECATED;
}
