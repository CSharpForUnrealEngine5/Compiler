#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDConversionBlueprintLibrary.h")]
///<summary>Wrapped static conversion functions from the UsdUtilities module, so that they can be used via scripting</summary>
public partial class UUsdConversionBlueprintLibrary : UBlueprintFunctionLibrary {
// UsdConversionBlueprintLibrary
	public void StreamInRequiredLevels(UObject World,TSet<sbyte> LevelsToIgnore) {}
	public void RevertSequencerAnimations() {}
	public void ReapplySequencerAnimations() {}
	public TArray<sbyte> GetLoadedLevelNames(UObject World,TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetVisibleInEditorLevelNames(UObject World,TArray<sbyte> ReturnValue) { return default; }
	public void StreamOutLevels(UObject OwningWorld,TArray<sbyte> LevelNamesToStreamOut,TArray<sbyte> LevelNamesToHide) {}
	public TSet<UObject> GetActorsToConvert(UObject World,TSet<UObject> ReturnValue) { return default; }
	public sbyte GenerateObjectVersionString(UObject ObjectToExport,UObject ExportOptions,sbyte ReturnValue) { return default; }
	public bool CanExportToLayer(sbyte TargetFilePath,bool ReturnValue) { return default; }
	public sbyte MakePathRelativeToLayer(sbyte AnchorLayerPath,sbyte PathToMakeRelative,sbyte ReturnValue) { return default; }
	public void InsertSubLayer(sbyte ParentLayerPath,sbyte SubLayerPath,int Index=-1) {}
	public void AddPayload(sbyte ReferencingStagePath,sbyte ReferencingPrimPath,sbyte TargetStagePath) {}
	public sbyte GetPrimPathForObject(UObject ActorOrComponent,sbyte ParentPrimPath=TEXT,bool bUseActorFolders=false,sbyte ReturnValue) { return default; }
	public sbyte GetSchemaNameForComponent(UObject Component,sbyte ReturnValue) { return default; }
	public UObject GetInstancedFoliageActorForLevel(bool bCreateIfNone=false,UObject Level=nullptr,UObject ReturnValue) { return default; }
	public TArray<UObject> GetUsedFoliageTypes(UObject Actor,TArray<UObject> ReturnValue) { return default; }
	public UObject GetSource(UObject FoliageType,UObject ReturnValue) { return default; }
	public TArray<FTransform> GetInstanceTransforms(UObject Actor,UObject FoliageType,UObject InstancesLevel=nullptr,TArray<FTransform> ReturnValue) { return default; }
	public TArray<FAnalyticsEventAttr> GetAnalyticsAttributes(UObject Options,TArray<FAnalyticsEventAttr> ReturnValue) { return default; }
	public void SendAnalytics(TArray<FAnalyticsEventAttr> Attrs,sbyte EventName,bool bAutomated,double ElapsedSeconds,double NumberOfFrames,sbyte Extension) {}
	public void RemoveAllPrimSpecs(sbyte StageRootLayer,sbyte PrimPath,sbyte TargetLayer) {}
	public bool CutPrims(sbyte StageRootLayer,TArray<sbyte> PrimPaths,bool ReturnValue) { return default; }
	public bool CopyPrims(sbyte StageRootLayer,TArray<sbyte> PrimPaths,bool ReturnValue) { return default; }
	public TArray<sbyte> PastePrims(sbyte StageRootLayer,sbyte ParentPrimPath,TArray<sbyte> ReturnValue) { return default; }
	public bool CanPastePrims(bool ReturnValue) { return default; }
	public void ClearPrimClipboard() {}
	public TArray<sbyte> DuplicatePrims(sbyte StageRootLayer,TArray<sbyte> PrimPaths,EUsdDuplicateType DuplicateType,sbyte TargetLayer,TArray<sbyte> ReturnValue) { return default; }
}
