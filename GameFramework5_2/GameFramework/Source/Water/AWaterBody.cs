#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBodyActor.h")]
///<summary>@todo_water: Remove Blueprintable</summary>
public partial class AWaterBody : AActor {
// WaterBody
	public EWaterBodyType GetWaterBodyType(EWaterBodyType ReturnValue) { return default; }
	public UObject GetWaterSpline(UObject ReturnValue) { return default; }
	public void SetWaterWaves(UObject InWaterWaves) {}
	public UObject GetWaterBodyComponent(UObject ReturnValue) { return default; }
	public UWaterSplineComponent SplineComp;
	public UWaterSplineMetadata WaterSplineMetadata;
	public UWaterBodyComponent WaterBodyComponent;
	public int WaterBodyIndex;
	public EWaterBodyType WaterBodyType;
	public UWaterWavesBase WaterWaves;
	public UObject GetRiverToLakeTransitionMaterialInstance(UObject ReturnValue) { return default; }
	public UObject GetRiverToOceanTransitionMaterialInstance(UObject ReturnValue) { return default; }
	public void SetWaterMaterial(UObject InMaterial) {}
	public UObject GetWaterMaterialInstance(UObject ReturnValue) { return default; }
	public float GetWaterVelocityAtSplineInputKey(float InKey,float ReturnValue) { return default; }
	public FVector GetWaterVelocityVectorAtSplineInputKey(float InKey,FVector ReturnValue) { return default; }
	public float GetAudioIntensityAtSplineInputKey(float InKey,float ReturnValue) { return default; }
	public TArray<UObject> GetIslands(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetExclusionVolumes(TArray<UObject> ReturnValue) { return default; }
	public void OnWaterBodyChanged(bool bShapeOrPositionChanged,bool bWeightmapSettingsChanged=false) {}
	public UPhysicalMaterial PhysicalMaterial_DEPRECATED;
	public float TargetWaveMaskDepth_DEPRECATED;
	public float MaxWaveHeightOffset_DEPRECATED;
	public bool bFillCollisionUnderWaterBodiesForNavmesh_DEPRECATED;
	public FUnderwaterPostProcessSettings UnderwaterPostProcessSettings_DEPRECATED;
	public FWaterCurveSettings CurveSettings_DEPRECATED;
	public UMaterialInterface WaterMaterial_DEPRECATED;
	public UMaterialInterface UnderwaterPostProcessMaterial_DEPRECATED;
	public FLandmassTerrainCarvingSettings TerrainCarvingSettings_DEPRECATED;
	public FWaterBodyHeightmapSettings WaterHeightmapSettings_DEPRECATED;
	public TMap<sbyte,FWaterBodyWeightmapSettings> LayerWeightmapSettings_DEPRECATED;
	public bool bAffectsLandscape_DEPRECATED;
	public bool bGenerateCollisions_DEPRECATED;
	public bool bOverrideWaterMesh_DEPRECATED;
	public UStaticMesh WaterMeshOverride_DEPRECATED;
	public int OverlapMaterialPriority_DEPRECATED;
	public sbyte CollisionProfileName_DEPRECATED;
	public UMaterialInstanceDynamic WaterMID_DEPRECATED;
	public UMaterialInstanceDynamic UnderwaterPostProcessMID_DEPRECATED;
	public TArray<TLazyObjectPtr<AWaterBodyIsland>> Islands_DEPRECATED;
	public TArray<TLazyObjectPtr<AWaterBodyExclusionVolume>> ExclusionVolumes_DEPRECATED;
	public bool bCanAffectNavigation_DEPRECATED;
	public UClass WaterNavAreaClass_DEPRECATED;
	public float ShapeDilation_DEPRECATED;
}
