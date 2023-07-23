#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimToTextureBPLibrary.h")]
///<summary>* TODO:</summary>
public partial class UAnimToTextureBPLibrary : UBlueprintFunctionLibrary {
// AnimToTextureBPLibrary
	public void AnimationToTexture(UObject DataAsset,FTransform RootTransform,bool bSuccess) {}
	public UObject ConvertSkeletalMeshToStaticMesh(UObject SkeletalMesh,sbyte PackageName,int LODIndex=-1,UObject ReturnValue) { return default; }
	public bool SetLightMapIndex(UObject StaticMesh,int LODIndex,int LightmapIndex=1,bool bGenerateLightmapUVs=true,bool ReturnValue) { return default; }
	public void UpdateMaterialInstanceFromDataAsset(UObject DataAsset,UObject MaterialInstance,bool bAnimate=false,EAnimToTextureNumBoneInfluences NumBoneInfluences=EAnimToTextureNumBoneInfluences,EMaterialParameterAssociation MaterialParameterAssociation=EMaterialParameterAssociation) {}
}
