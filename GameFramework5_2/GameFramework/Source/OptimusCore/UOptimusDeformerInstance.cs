#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusDeformerInstance.h")]
///<summary>Class representing an instance of an Optimus Mesh Deformer.</summary>
public partial class UOptimusDeformerInstance : UMeshDeformerInstance {
// OptimusDeformerInstance
	public bool SetBoolVariable(sbyte InVariableName,bool InValue,bool ReturnValue) { return default; }
	public bool SetIntVariable(sbyte InVariableName,int InValue,bool ReturnValue) { return default; }
	public bool SetFloatVariable(sbyte InVariableName,double InValue,bool ReturnValue) { return default; }
	public bool SetVectorVariable(sbyte InVariableName,FVector InValue,bool ReturnValue) { return default; }
	public bool SetVector4Variable(sbyte InVariableName,FVector4 InValue,bool ReturnValue) { return default; }
	public bool SetTransformVariable(sbyte InVariableName,FTransform InValue,bool ReturnValue) { return default; }
	public TArray<UObject> GetVariables(TArray<UObject> ReturnValue) { return default; }
	public bool EnqueueTriggerGraph(sbyte InTriggerGraphName,bool ReturnValue) { return default; }
	public TWeakObjectPtr<UMeshComponent> MeshComponent;
	public TWeakObjectPtr<UOptimusDeformerInstanceSettings> InstanceSettings;
	public TArray<FOptimusDeformerInstanceExecInfo> ComputeGraphExecInfos;
	public UOptimusVariableContainer Variables;
}
