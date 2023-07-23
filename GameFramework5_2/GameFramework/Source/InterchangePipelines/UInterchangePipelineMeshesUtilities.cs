#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangePipelineMeshesUtilities.h")]
public partial class UInterchangePipelineMeshesUtilities : UObject {
// InterchangePipelineMeshesUtilities
	public UObject CreateInterchangePipelineMeshesUtilities(UObject BaseNodeContainer,UObject ReturnValue) { return default; }
	public void GetAllMeshInstanceUids(TArray<sbyte> MeshInstanceUids) {}
	public void GetAllSkinnedMeshInstance(TArray<sbyte> MeshInstanceUids,bool bConvertStaticMeshToSkeletalMesh) {}
	public void GetAllStaticMeshInstance(TArray<sbyte> MeshInstanceUids,bool bConvertSkeletalMeshToStaticMesh) {}
	public void GetAllMeshGeometry(TArray<sbyte> MeshGeometryUids) {}
	public void GetAllSkinnedMeshGeometry(TArray<sbyte> MeshGeometryUids) {}
	public void GetAllStaticMeshGeometry(TArray<sbyte> MeshGeometryUids,bool bConvertSkeletalMeshToStaticMesh) {}
	public void GetAllMeshGeometryNotInstanced(TArray<sbyte> MeshGeometryUids) {}
	public bool IsValidMeshInstanceUid(sbyte MeshInstanceUid,bool ReturnValue) { return default; }
	public FInterchangeMeshInstance GetMeshInstanceByUid(sbyte MeshInstanceUid,FInterchangeMeshInstance ReturnValue) { return default; }
	public bool IsValidMeshGeometryUid(sbyte MeshGeometryUid,bool ReturnValue) { return default; }
	public FInterchangeMeshGeometry GetMeshGeometryByUid(sbyte MeshGeometryUid,FInterchangeMeshGeometry ReturnValue) { return default; }
	public void GetAllMeshInstanceUidsUsingMeshGeometryUid(sbyte MeshGeometryUid,TArray<sbyte> MeshInstanceUids) {}
	public sbyte GetMeshInstanceSkeletonRootUid(sbyte MeshInstanceUid,sbyte ReturnValue) { return default; }
	public sbyte GetMeshGeometrySkeletonRootUid(sbyte MeshGeometryUid,sbyte ReturnValue) { return default; }
}
