#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangePipelineMeshesUtilities.h")]
///<summary>* A mesh geometry is a description of a translated mesh asset node that define a geometry.</summary>
public partial struct FInterchangeMeshGeometry {
// InterchangeMeshGeometry
	public sbyte MeshUid;
	public UInterchangeMeshNode MeshNode;
	public TArray<sbyte> ReferencingMeshInstanceUids;
	public TArray<sbyte> AttachedSocketUids;
}
