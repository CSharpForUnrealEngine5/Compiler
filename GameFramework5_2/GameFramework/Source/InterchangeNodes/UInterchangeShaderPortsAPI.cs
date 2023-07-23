#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeShaderGraphNode.h")]
///<summary>The Shader Ports API manages a set of inputs and outputs attributes.</summary>
public partial class UInterchangeShaderPortsAPI : UObject {
// InterchangeShaderPortsAPI
	public sbyte MakeInputConnectionKey(sbyte InputName,sbyte ReturnValue) { return default; }
	public sbyte MakeInputValueKey(sbyte InputName,sbyte ReturnValue) { return default; }
	public sbyte MakeInputName(sbyte InputKey,sbyte ReturnValue) { return default; }
	public bool IsAnInput(sbyte AttributeKey,bool ReturnValue) { return default; }
	public bool HasInput(UObject InterchangeNode,sbyte InInputName,bool ReturnValue) { return default; }
	public void GatherInputs(UObject InterchangeNode,TArray<sbyte> OutInputNames) {}
	public bool ConnectDefaultOuputToInput(UObject InterchangeNode,sbyte InputName,sbyte ExpressionUid,bool ReturnValue) { return default; }
	public bool ConnectOuputToInput(UObject InterchangeNode,sbyte InputName,sbyte ExpressionUid,sbyte OutputName,bool ReturnValue) { return default; }
	public bool GetInputConnection(UObject InterchangeNode,sbyte InputName,sbyte OutExpressionUid,sbyte OutputName,bool ReturnValue) { return default; }
}
