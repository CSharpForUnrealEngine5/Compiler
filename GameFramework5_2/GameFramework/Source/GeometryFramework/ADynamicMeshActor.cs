#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DynamicMeshActor.h")]
///<summary>ADynamicMeshActor is an Actor that has a USimpleDynamicMeshComponent as it's RootObject.</summary>
public partial class ADynamicMeshActor : AActor {
// DynamicMeshActor
	public UDynamicMeshComponent DynamicMeshComponent;
	public UObject GetDynamicMeshComponent(UObject ReturnValue) { return default; }
	public bool bEnableComputeMeshPool;
	public UDynamicMeshPool DynamicMeshPool;
	public UObject GetComputeMeshPool(UObject ReturnValue) { return default; }
	public UObject AllocateComputeMesh(UObject ReturnValue) { return default; }
	public bool ReleaseComputeMesh(UObject Mesh,bool ReturnValue) { return default; }
	public void ReleaseAllComputeMeshes() {}
	public void FreeAllComputeMeshes() {}
}
