#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/StaticMeshImportTestFunctions.h")]
public partial class UStaticMeshImportTestFunctions : UImportTestFunctionsBase {
// StaticMeshImportTestFunctions
	public FInterchangeTestFunctionResult CheckImportedStaticMeshCount(TArray<UObject> Meshes,int ExpectedNumberOfImportedStaticMeshes,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckLodCount(UObject Mesh,int ExpectedNumberOfLods,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckSectionCount(UObject Mesh,int LodIndex,int ExpectedNumberOfSections,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckMaterialSlotCount(UObject Mesh,int ExpectedNumberOfMaterialSlots,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckImportedMaterialSlotName(UObject Mesh,int MaterialIndex,sbyte ExpectedImportedMaterialSlotName,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckPolygonGroupCount(UObject Mesh,int LodIndex,int ExpectedNumberOfPolygonGroups,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckPolygonGroupImportedMaterialSlotName(UObject Mesh,int LodIndex,int PolygonGroupIndex,sbyte ExpectedImportedMaterialSlotName,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckSectionMaterialIndex(UObject Mesh,int LodIndex,int SectionIndex,int ExpectedMaterialIndex,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckSectionMaterialName(UObject Mesh,int LodIndex,int SectionIndex,sbyte ExpectedMaterialName,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckSectionImportedMaterialSlotName(UObject Mesh,int LodIndex,int SectionIndex,sbyte ExpectedImportedMaterialSlotName,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckVertexCount(UObject Mesh,int LodIndex,int ExpectedNumberOfVertices,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckRenderVertexCount(UObject Mesh,int LodIndex,int ExpectedNumberOfRenderVertices,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckVertexIndexPosition(UObject Mesh,int LodIndex,int VertexIndex,FVector ExpectedVertexPosition,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckRenderVertexIndexNormal(UObject Mesh,int LodIndex,int VertexIndex,FVector4f ExpectedVertexNormal,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckRenderVertexIndexColor(UObject Mesh,int LodIndex,int VertexIndex,FColor ExpectedVertexColor,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckRenderHasVertexColors(UObject Mesh,int LodIndex,bool bExpectedHasVertexColors,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckTriangleCount(UObject Mesh,int LodIndex,int ExpectedTotalNumberOfTriangles,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckRenderTriangleCount(UObject Mesh,int LodIndex,int ExpectedTotalNumberOfTriangles,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckPolygonCount(UObject Mesh,int LodIndex,int ExpectedNumberOfPolygons,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckThatMeshHasQuadsOrNgons(UObject Mesh,int LodIndex,bool bMeshHasQuadsOrNgons,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckTriangleCountInPolygonGroup(UObject Mesh,int LodIndex,int PolygonGroupIndex,int ExpectedNumberOfTriangles,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckPolygonCountInPolygonGroup(UObject Mesh,int LodIndex,int PolygonGroupIndex,int ExpectedNumberOfPolygons,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckUVChannelCount(UObject Mesh,int LodIndex,int ExpectedNumberOfUVChannels,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckRenderUVChannelCount(UObject Mesh,int LodIndex,int ExpectedNumberOfUVChannels,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckSimpleCollisionPrimitiveCount(UObject Mesh,int ExpectedSphereElementCount,int ExpectedBoxElementCount,int ExpectedCapsuleElementCount,int ExpectedConvexElementCount,int ExpectedTaperedCapsuleElementCount,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckSocketCount(UObject Mesh,int ExpectedSocketCount,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckSocketName(UObject Mesh,int SocketIndex,sbyte ExpectedSocketName,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckSocketLocation(UObject Mesh,int SocketIndex,FVector ExpectedSocketLocation,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckAgainstGroundTruth(UObject Mesh,TSoftObjectPtr<UStaticMesh> MeshToCompare,bool bCheckVertexCountEqual=true,bool bCheckTriangleCountEqual=true,bool bCheckUVChannelCountEqual=true,bool bCheckCollisionPrimitiveCountEqual=true,bool bCheckVertexPositionsEqual=true,bool bCheckNormalsEqual=true,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckBuildSettings(UObject Mesh,int LodIndex,FMeshBuildSettings ExpectedBuildSettings,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckNaniteSettings(UObject Mesh,FMeshNaniteSettings ExpectedNaniteSettings,FInterchangeTestFunctionResult ReturnValue) { return default; }
}
