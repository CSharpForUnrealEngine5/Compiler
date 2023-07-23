#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/SkeletalMeshImportTestFunctions.h")]
public partial class USkeletalMeshImportTestFunctions : UImportTestFunctionsBase {
// SkeletalMeshImportTestFunctions
	public FInterchangeTestFunctionResult CheckImportedSkeletalMeshCount(TArray<UObject> Meshes,int ExpectedNumberOfImportedSkeletalMeshes,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckRenderVertexCount(UObject Mesh,int LodIndex,int ExpectedNumberOfRenderVertices,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckRenderTriangleCount(UObject Mesh,int LodIndex,int ExpectedNumberOfRenderTriangles,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckLodCount(UObject Mesh,int ExpectedNumberOfLods,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckMaterialSlotCount(UObject Mesh,int ExpectedNumberOfMaterialSlots,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckSectionCount(UObject Mesh,int LodIndex,int ExpectedNumberOfSections,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckTriangleCountInSection(UObject Mesh,int LodIndex,int SectionIndex,int ExpectedNumberOfTriangles,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckUVChannelCount(UObject Mesh,int LodIndex,int ExpectedNumberOfUVChannels,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckSectionMaterialName(UObject Mesh,int LodIndex,int SectionIndex,sbyte ExpectedMaterialName,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckSectionImportedMaterialSlotName(UObject Mesh,int LodIndex,int SectionIndex,sbyte ExpectedImportedMaterialSlotName,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckVertexIndexPosition(UObject Mesh,int LodIndex,int VertexIndex,FVector ExpectedVertexPosition,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckVertexIndexNormal(UObject Mesh,int LodIndex,int VertexIndex,FVector ExpectedVertexNormal,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckBoneCount(UObject Mesh,int ExpectedNumberOfBones,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckBonePosition(UObject Mesh,int BoneIndex,FVector ExpectedBonePosition,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckSkinnedVertexCountForBone(UObject Mesh,sbyte BoneName,bool bTestFirstAlternateProfile,int ExpectedSkinnedVertexCount,FInterchangeTestFunctionResult ReturnValue) { return default; }
}
