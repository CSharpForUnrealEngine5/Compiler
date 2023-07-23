#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SkeletalMeshEditorSubsystem.h")]
///<summary>USkeletalMeshEditorSubsystem</summary>
public partial class USkeletalMeshEditorSubsystem : UEditorSubsystem {
// SkeletalMeshEditorSubsystem
	public bool RegenerateLOD(UObject SkeletalMesh,int NewLODCount=0,bool bRegenerateEvenIfImported=false,bool bGenerateBaseLOD=false,bool ReturnValue) { return default; }
	public int GetNumVerts(UObject SkeletalMesh,int LODIndex,int ReturnValue) { return default; }
	public int GetNumSections(UObject SkeletalMesh,int LODIndex,int ReturnValue) { return default; }
	public bool GetSectionRecomputeTangent(UObject SkeletalMesh,int LODIndex,int SectionIndex,bool bOutRecomputeTangent,bool ReturnValue) { return default; }
	public bool SetSectionRecomputeTangent(UObject SkeletalMesh,int LODIndex,int SectionIndex,bool bRecomputeTangent,bool ReturnValue) { return default; }
	public bool GetSectionRecomputeTangentsVertexMaskChannel(UObject SkeletalMesh,int LODIndex,int SectionIndex,byte OutRecomputeTangentsVertexMaskChannel,bool ReturnValue) { return default; }
	public bool SetSectionRecomputeTangentsVertexMaskChannel(UObject SkeletalMesh,int LODIndex,int SectionIndex,byte RecomputeTangentsVertexMaskChannel,bool ReturnValue) { return default; }
	public bool GetSectionCastShadow(UObject SkeletalMesh,int LODIndex,int SectionIndex,bool bOutCastShadow,bool ReturnValue) { return default; }
	public bool SetSectionCastShadow(UObject SkeletalMesh,int LODIndex,int SectionIndex,bool bCastShadow,bool ReturnValue) { return default; }
	public bool GetSectionVisibleInRayTracing(UObject SkeletalMesh,int LODIndex,int SectionIndex,bool bOutVisibleInRayTracing,bool ReturnValue) { return default; }
	public bool SetSectionVisibleInRayTracing(UObject SkeletalMesh,int LODIndex,int SectionIndex,bool bVisibleInRayTracing,bool ReturnValue) { return default; }
	public int GetLODMaterialSlot(UObject SkeletalMesh,int LODIndex,int SectionIndex,int ReturnValue) { return default; }
	public bool RenameSocket(UObject SkeletalMesh,sbyte OldName,sbyte NewName,bool ReturnValue) { return default; }
	public int GetLODCount(UObject SkeletalMesh,int ReturnValue) { return default; }
	public int ImportLOD(UObject BaseMesh,int LODIndex,sbyte SourceFilename,int ReturnValue) { return default; }
	public bool ReimportAllCustomLODs(UObject SkeletalMesh,bool ReturnValue) { return default; }
	public void GetLodBuildSettings(UObject SkeletalMesh,int LodIndex,FSkeletalMeshBuildSettings OutBuildOptions) {}
	public void SetLodBuildSettings(UObject SkeletalMesh,int LodIndex,FSkeletalMeshBuildSettings BuildOptions) {}
	public UObject CreatePhysicsAsset(UObject SkeletalMesh,UObject ReturnValue) { return default; }
}
