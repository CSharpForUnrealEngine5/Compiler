#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDConversionBlueprintContext.h")]
///<summary>Wraps the UnrealToUsd component conversion functions from the USDUtilities module so that they can be used by</summary>
public partial class UUsdConversionBlueprintContext : UObject {
// UsdConversionBlueprintContext
	public void SetStageRootLayer(FFilePath StageRootLayerPath) {}
	public FFilePath GetStageRootLayer(FFilePath ReturnValue) { return default; }
	public void SetEditTarget(FFilePath EditTargetLayerPath) {}
	public FFilePath GetEditTarget(FFilePath ReturnValue) { return default; }
	public void Cleanup() {}
	public bool ConvertLightComponent(UObject Component,sbyte PrimPath,float TimeCode=3.402823466e+38F,bool ReturnValue) { return default; }
	public bool ConvertDirectionalLightComponent(UObject Component,sbyte PrimPath,float TimeCode=3.402823466e+38F,bool ReturnValue) { return default; }
	public bool ConvertRectLightComponent(UObject Component,sbyte PrimPath,float TimeCode=3.402823466e+38F,bool ReturnValue) { return default; }
	public bool ConvertPointLightComponent(UObject Component,sbyte PrimPath,float TimeCode=3.402823466e+38F,bool ReturnValue) { return default; }
	public bool ConvertSkyLightComponent(UObject Component,sbyte PrimPath,float TimeCode=3.402823466e+38F,bool ReturnValue) { return default; }
	public bool ConvertSpotLightComponent(UObject Component,sbyte PrimPath,float TimeCode=3.402823466e+38F,bool ReturnValue) { return default; }
	public bool ConvertSceneComponent(UObject Component,sbyte PrimPath,bool ReturnValue) { return default; }
	public bool ConvertHismComponent(UObject Component,sbyte PrimPath,float TimeCode=3.402823466e+38F,bool ReturnValue) { return default; }
	public bool ConvertMeshComponent(UObject Component,sbyte PrimPath,bool ReturnValue) { return default; }
	public bool ConvertCineCameraComponent(UObject Component,sbyte PrimPath,float TimeCode=3.402823466e+38F,bool ReturnValue) { return default; }
	public bool ConvertInstancedFoliageActor(UObject Actor,sbyte PrimPath,UObject InstancesLevel=nullptr,float TimeCode=3.402823466e+38F,bool ReturnValue) { return default; }
	public bool ConvertLandscapeProxyActorMesh(UObject Actor,sbyte PrimPath,int LowestLOD,int HighestLOD,float TimeCode=3.402823466e+38F,bool ReturnValue) { return default; }
	public bool ConvertLandscapeProxyActorMaterial(UObject Actor,sbyte PrimPath,TArray<FPropertyEntry> PropertiesToBake,FIntPoint DefaultTextureSize,FDirectoryPath TexturesDir,float TimeCode=3.402823466e+38F,bool ReturnValue) { return default; }
	public void ReplaceUnrealMaterialsWithBaked(FFilePath LayerToAuthorIn,TMap<sbyte,sbyte> BakedMaterials,bool bIsAssetLayer,bool bUsePayload,bool bRemoveUnrealMaterials=false) {}
	public bool RemoveUnrealSurfaceOutput(sbyte PrimPath,FFilePath LayerToAuthorIn,bool ReturnValue) { return default; }
	public int GetUsdStageNumFrames(int ReturnValue) { return default; }
	public void SetPrimAssetInfo(sbyte PrimPath,FUsdUnrealAssetInfo Info) {}
	public FUsdUnrealAssetInfo GetPrimAssetInfo(sbyte PrimPath,FUsdUnrealAssetInfo ReturnValue) { return default; }
}
