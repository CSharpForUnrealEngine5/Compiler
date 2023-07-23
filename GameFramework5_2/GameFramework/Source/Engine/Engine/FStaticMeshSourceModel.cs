#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/StaticMeshSourceData.h")]
///<summary>Source model from which a renderable static mesh is built.</summary>
public partial struct FStaticMeshSourceModel {
// StaticMeshSourceModel
	public UStaticMeshDescriptionBulkData StaticMeshDescriptionBulkData;
	public FMeshBuildSettings BuildSettings;
	public FMeshReductionSettings ReductionSettings;
	public uint CacheMeshDescriptionTrianglesCount;
	public uint CacheMeshDescriptionVerticesCount;
	public float LODDistance_DEPRECATED;
	public FPerPlatformFloat ScreenSize;
	public sbyte SourceImportFilename;
	public bool bImportWithBaseMesh;
}
