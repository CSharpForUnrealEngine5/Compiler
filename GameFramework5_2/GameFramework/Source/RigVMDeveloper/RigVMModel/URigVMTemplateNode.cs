#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/Nodes/RigVMTemplateNode.h")]
///<summary>The Template Node represents an unresolved function.</summary>
public partial class URigVMTemplateNode : URigVMNode {
// RigVMTemplateNode
	public UObject GetScriptStruct(UObject ReturnValue) { return default; }
	public sbyte GetNotation(sbyte ReturnValue) { return default; }
	public bool IsSingleton(bool ReturnValue) { return default; }
	public bool IsResolved(bool ReturnValue) { return default; }
	public bool IsFullyUnresolved(bool ReturnValue) { return default; }
	public sbyte TemplateNotation;
	public sbyte ResolvedFunctionName;
	public TArray<sbyte> PreferredPermutationTypes_DEPRECATED;
	public TArray<FRigVMTemplatePreferredType> PreferredPermutationPairs;
}
