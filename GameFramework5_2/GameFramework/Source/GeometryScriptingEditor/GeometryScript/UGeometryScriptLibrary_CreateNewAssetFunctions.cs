#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/CreateNewAssetUtilityFunctions.h")]
public partial class UGeometryScriptLibrary_CreateNewAssetFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_CreateNewAssetFunctions
	public void CreateUniqueNewAssetPathName(sbyte AssetFolderPath,sbyte BaseAssetName,sbyte UniqueAssetPathAndName,sbyte UniqueAssetName,FGeometryScriptUniqueAssetNameOptions Options,EGeometryScriptOutcomePins Outcome,UObject Debug=nullptr) {}
	public UObject CreateNewVolumeFromMesh(UObject FromDynamicMesh,UObject CreateInWorld,FTransform ActorTransform,sbyte BaseActorName,FGeometryScriptCreateNewVolumeFromMeshOptions Options,EGeometryScriptOutcomePins Outcome,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject CreateNewStaticMeshAssetFromMesh(UObject FromDynamicMesh,sbyte AssetPathAndName,FGeometryScriptCreateNewStaticMeshAssetOptions Options,EGeometryScriptOutcomePins Outcome,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject CreateNewSkeletalMeshAssetFromMesh(UObject FromDynamicMesh,UObject InSkeleton,sbyte AssetPathAndName,FGeometryScriptCreateNewSkeletalMeshAssetOptions Options,EGeometryScriptOutcomePins Outcome,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject CreateNewTexture2DAsset(UObject FromTexture,sbyte AssetPathAndName,FGeometryScriptCreateNewTexture2DAssetOptions Options,EGeometryScriptOutcomePins Outcome,UObject Debug=nullptr,UObject ReturnValue) { return default; }
}
