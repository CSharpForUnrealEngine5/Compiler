#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/GenerateStaticMeshLODAssetTool.h")]
///<summary>Standard properties</summary>
public partial class UGenerateStaticMeshLODAssetToolProperties : UInteractiveToolPropertySet {
// GenerateStaticMeshLODAssetToolProperties
	public FGenerateStaticMeshLODProcess_PreprocessSettings Preprocessing;
	public FGenerateStaticMeshLODProcessSettings MeshGeneration;
	public FGenerateStaticMeshLODProcess_SimplifySettings Simplification;
	public FGenerateStaticMeshLODProcess_NormalsSettings Normals;
	public FGenerateStaticMeshLODProcess_TextureSettings TextureBaking;
	public FGenerateStaticMeshLODProcess_UVSettings UVGeneration;
	public FGenerateStaticMeshLODProcess_CollisionSettings SimpleCollision;
	public sbyte CollisionGroupLayerName;
	public TArray<sbyte> GetGroupLayersFunc(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GroupLayersList;
}
