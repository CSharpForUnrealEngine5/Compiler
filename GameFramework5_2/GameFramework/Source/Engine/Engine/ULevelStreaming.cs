#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/LevelStreaming.h")]
///<summary>Abstract base class of container object encapsulating data required for streaming and providing</summary>
public partial class ULevelStreaming : UObject {
// LevelStreaming
	public sbyte PackageName_DEPRECATED;
	public TSoftObjectPtr<UWorld> WorldAsset;
	public int StreamingPriority;
	public sbyte PackageNameToLoad;
	public TArray<sbyte> LODPackageNames;
	public FTransform LevelTransform;
	public bool bClientOnlyVisible;
	public int LevelLODIndex;
	public bool bShouldBeVisibleInEditor;
	public bool bShouldBeVisible;
	public bool bShouldBeLoaded;
	public bool bLocked;
	public bool bIsStatic;
	public bool bShouldBlockOnLoad;
	public bool bShouldBlockOnUnload;
	public bool bDisableDistanceStreaming;
	public bool bDrawOnLevelStatusMap;
	public FColor DrawColor_DEPRECATED;
	public FLinearColor LevelColor;
	public TArray<ALevelStreamingVolume> EditorStreamingVolumes;
	public float MinTimeBetweenVolumeUnloadRequests;
	public TArray<sbyte> Keywords;
	public void SetShouldBeVisible(bool bInShouldBeVisible) {}
	public void SetShouldBeLoaded(bool bInShouldBeLoaded) {}
	public void SetLevelLODIndex(int LODIndex) {}
	public void SetPriority(int NewPriority) {}
	public bool GetIsRequestingUnloadAndRemoval(bool ReturnValue) { return default; }
	public void SetIsRequestingUnloadAndRemoval(bool bInIsRequestingUnloadAndRemoval) {}
	public sbyte GetWorldAssetPackageFName(sbyte ReturnValue) { return default; }
	public bool ShouldBeLoaded(bool ReturnValue) { return default; }
	public UObject GetLoadedLevel(UObject ReturnValue) { return default; }
	public bool IsLevelVisible(bool ReturnValue) { return default; }
	public bool IsLevelLoaded(bool ReturnValue) { return default; }
	public bool IsStreamingStatePending(bool ReturnValue) { return default; }
	public UObject CreateInstance(sbyte UniqueInstanceName,UObject ReturnValue) { return default; }
	public UObject GetLevelScriptActor(UObject ReturnValue) { return default; }
	public FLevelStreamingLoadedStatus OnLevelLoaded;
	public FLevelStreamingLoadedStatus OnLevelUnloaded;
	public FLevelStreamingVisibilityStatus OnLevelShown;
	public FLevelStreamingVisibilityStatus OnLevelHidden;
	public ULevel LoadedLevel;
	public ULevel PendingUnloadLevel;
	public sbyte FolderPath;
}
