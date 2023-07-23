#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorSkeletalMeshLibrary.h")]
///<summary>Utility class to altering and analyzing a SkeletalMesh and use the common functionalities of the SkeletalMesh Editor.</summary>
public partial class UDEPRECATED_EditorSkeletalMeshLibrary : UBlueprintFunctionLibrary {
// EditorSkeletalMeshLibrary
	public bool RegenerateLOD(UObject SkeletalMesh,int NewLODCount=0,bool bRegenerateEvenIfImported=false,bool bGenerateBaseLOD=false,bool ReturnValue) { return default; }
	public int GetNumVerts(UObject SkeletalMesh,int LODIndex,int ReturnValue) { return default; }
	public bool RenameSocket(UObject SkeletalMesh,sbyte OldName,sbyte NewName,bool ReturnValue) { return default; }
	public int GetLODCount(UObject SkeletalMesh,int ReturnValue) { return default; }
	public int ImportLOD(UObject BaseMesh,int LODIndex,sbyte SourceFilename,int ReturnValue) { return default; }
	public bool ReimportAllCustomLODs(UObject SkeletalMesh,bool ReturnValue) { return default; }
	public void GetLodBuildSettings(UObject SkeletalMesh,int LodIndex,FSkeletalMeshBuildSettings OutBuildOptions) {}
	public void SetLodBuildSettings(UObject SkeletalMesh,int LodIndex,FSkeletalMeshBuildSettings BuildOptions) {}
	public bool RemoveLODs(UObject SkeletalMesh,TArray<int> ToRemoveLODs,bool ReturnValue) { return default; }
	public bool StripLODGeometry(UObject SkeletalMesh,int LODIndex,UObject TextureMask,float Threshold,bool ReturnValue) { return default; }
	public UObject CreatePhysicsAsset(UObject SkeletalMesh,UObject ReturnValue) { return default; }
}
