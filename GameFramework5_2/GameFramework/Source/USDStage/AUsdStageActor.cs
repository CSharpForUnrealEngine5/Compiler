#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDStageActor.h")]
public partial class AUsdStageActor : AActor {
// UsdStageActor
	public FFilePath RootLayer;
	public UUsdAssetCache2 UsdAssetCache;
	public EUsdInitialLoadSet InitialLoadSet;
	public EUsdInterpolationType InterpolationType;
	public int KindsToCollapse;
	public bool bMergeIdenticalMaterialSlots;
	public bool bCollapseTopLevelPointInstancers;
	public int PurposesToLoad;
	public int NaniteTriangleThreshold;
	public sbyte RenderContext;
	public sbyte MaterialPurpose;
	public EUsdRootMotionHandling RootMotionHandling;
	public void SetRootLayer(sbyte RootFilePath) {}
	public void SetAssetCache(UObject NewCache) {}
	public void SetInitialLoadSet(EUsdInitialLoadSet NewLoadSet) {}
	public void SetInterpolationType(EUsdInterpolationType NewType) {}
	public void SetKindsToCollapse(int NewKindsToCollapse) {}
	public void SetMergeIdenticalMaterialSlots(bool bMerge) {}
	public void SetCollapseTopLevelPointInstancers(bool bCollapse) {}
	public void SetPurposesToLoad(int NewPurposesToLoad) {}
	public void SetNaniteTriangleThreshold(int NewNaniteTriangleThreshold) {}
	public void SetRenderContext(sbyte NewRenderContext) {}
	public void SetMaterialPurpose(sbyte NewMaterialPurpose) {}
	public void SetRootMotionHandling(EUsdRootMotionHandling NewHandlingStrategy) {}
	public float GetTime(float ReturnValue) { return default; }
	public void SetTime(float InTime) {}
	public UObject GetLevelSequence(UObject ReturnValue) { return default; }
	public UObject GetGeneratedComponent(sbyte PrimPath,UObject ReturnValue) { return default; }
	public TArray<UObject> GetGeneratedAssets(sbyte PrimPath,TArray<UObject> ReturnValue) { return default; }
	public sbyte GetSourcePrimPath(UObject Object,sbyte ReturnValue) { return default; }
	public void NewStage() {}
	public void SetIsolatedRootLayer(sbyte IsolatedStageRootLayer) {}
	public sbyte GetIsolatedRootLayer(sbyte ReturnValue) { return default; }
	public USceneComponent SceneComponent;
	public float Time;
	public ULevelSequence LevelSequence;
	public UUsdPrimTwin RootUsdTwin;
	public TSet<sbyte> PrimsToAnimate;
	public TMap<UObject,sbyte> ObjectsToWatch;
	public UUsdAssetCache AssetCache;
	public UUsdTransactor Transactor;
}
