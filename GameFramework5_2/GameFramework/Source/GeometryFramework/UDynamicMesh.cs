#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UDynamicMesh.h")]
///<summary>UDynamicMesh is a UObject container for a FDynamicMesh3.</summary>
public partial class UDynamicMesh : UObject {
// DynamicMesh
	public UObject Reset(UObject ReturnValue) { return default; }
	public UObject ResetToCube(UObject ReturnValue) { return default; }
	public bool IsEmpty(bool ReturnValue) { return default; }
	public int GetTriangleCount(int ReturnValue) { return default; }
	public FOnDynamicMeshModifiedBP MeshModifiedBPEvent;
	public UDynamicMeshGenerator MeshGenerator;
	public bool bEnableMeshGenerator;
}
