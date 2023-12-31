#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusDeformer.h")]
///<summary>A Deformer Graph is an asset that is used to create and control custom deformations on</summary>
public partial class UOptimusDeformer : UMeshDeformer {
// OptimusDeformer
	public TArray<UObject> GetVariables() { return default; }
	public TArray<UObject> GetResources() { return default; }
	public TArray<UObject> GetComponentBindings() { return default; }
	public USkeletalMesh Mesh;
	public TArray<FOptimusComputeGraphInfo> ComputeGraphs;
	public UOptimusActionStack ActionStack;
	public TArray<UOptimusNodeGraph> Graphs;
	public UOptimusComponentSourceBindingContainer Bindings;
	public UOptimusVariableContainer Variables;
	public UOptimusResourceContainer Resources;
}
