#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectElements/DatasmithUSceneElement.h")]
public partial class UDatasmithSceneElementBase : UObject {
// DatasmithSceneElementBase
	public sbyte GetHost(sbyte ReturnValue) { return default; }
	public sbyte GetExporterVersion(sbyte ReturnValue) { return default; }
	public sbyte GetVendor(sbyte ReturnValue) { return default; }
	public sbyte GetProductName(sbyte ReturnValue) { return default; }
	public sbyte GetProductVersion(sbyte ReturnValue) { return default; }
	public sbyte GetUserID(sbyte ReturnValue) { return default; }
	public sbyte GetUserOS(sbyte ReturnValue) { return default; }
	public int GetExportDuration(int ReturnValue) { return default; }
	public bool GetUsePhysicalSky(bool ReturnValue) { return default; }
	public UObject CreateMesh(sbyte InElementName,UObject ReturnValue) { return default; }
	public TArray<UObject> GetMeshes(TArray<UObject> ReturnValue) { return default; }
	public UObject GetMeshByPathName(sbyte MeshPathName,UObject ReturnValue) { return default; }
	public void RemoveMesh(UObject InMesh) {}
	public UObject CreateMeshActor(sbyte InElementName,UObject ReturnValue) { return default; }
	public TArray<UObject> GetMeshActors(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetAllMeshActors(TArray<UObject> ReturnValue) { return default; }
	public void RemoveMeshActor(UObject InMeshActor,EDatasmithActorRemovalRule RemoveRule=EDatasmithActorRemovalRule) {}
	public TArray<UObject> GetLightActors(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetAllLightActors(TArray<UObject> ReturnValue) { return default; }
	public void RemoveLightActor(UObject InLightActor,EDatasmithActorRemovalRule RemoveRule=EDatasmithActorRemovalRule) {}
	public UObject CreateCameraActor(sbyte InElementName,UObject ReturnValue) { return default; }
	public TArray<UObject> GetCameraActors(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetAllCameraActors(TArray<UObject> ReturnValue) { return default; }
	public void RemoveCameraActor(UObject InMeshActor,EDatasmithActorRemovalRule RemoveRule=EDatasmithActorRemovalRule) {}
	public TArray<UObject> GetCustomActors(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetAllCustomActors(TArray<UObject> ReturnValue) { return default; }
	public void RemoveCustomActor(UObject InCustomActor,EDatasmithActorRemovalRule RemoveRule=EDatasmithActorRemovalRule) {}
	public UObject CreateTexture(sbyte InElementName,UObject ReturnValue) { return default; }
	public TArray<UObject> GetTextures(TArray<UObject> ReturnValue) { return default; }
	public void RemoveTexture(UObject InElement) {}
	public TArray<UObject> GetAllMaterials(TArray<UObject> ReturnValue) { return default; }
	public void RemoveMaterial(UObject InElement) {}
	public UObject GetPostProcess(UObject ReturnValue) { return default; }
	public UObject GetMetaDataForObject(UObject Object,UObject ReturnValue) { return default; }
	public sbyte GetMetaDataValueForKey(UObject Object,sbyte Key,sbyte ReturnValue) { return default; }
	public void GetMetaDataKeysAndValuesForValue(UObject Object,sbyte StringToMatch,TArray<sbyte> OutKeys,TArray<sbyte> OutValues) {}
	public void GetAllMetaData(UClass ObjectClass,TArray<UObject> OutMetadatas) {}
	public void GetAllObjectsAndValuesForKey(sbyte Key,UClass ObjectClass,TArray<UObject> OutObjects,TArray<sbyte> OutValues) {}
	public UObject CreateLevelVariantSets(sbyte InElementName,UObject ReturnValue) { return default; }
	public TArray<UObject> GetAllLevelVariantSets(TArray<UObject> ReturnValue) { return default; }
	public void RemoveLevelVariantSets(UObject InElement) {}
	public void AttachActor(UObject NewParent,UObject Child,EDatasmithActorAttachmentRule AttachmentRule) {}
	public void AttachActorToSceneRoot(UObject NewParent,EDatasmithActorAttachmentRule AttachmentRule) {}
}
