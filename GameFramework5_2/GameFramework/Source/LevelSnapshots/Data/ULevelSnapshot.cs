#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/LevelSnapshot.h")]
///<summary>Holds the state of a world at a given time. This asset can be used to rollback certain properties in a UWorld.</summary>
public partial class ULevelSnapshot : UObject {
// LevelSnapshot
	public void SetSnapshotName(sbyte InSnapshotName) {}
	public void SetSnapshotDescription(sbyte InSnapshotDescription) {}
	public FSoftObjectPath GetMapPath(FSoftObjectPath ReturnValue) { return default; }
	public FDateTime GetCaptureTime(FDateTime ReturnValue) { return default; }
	public sbyte GetSnapshotName(sbyte ReturnValue) { return default; }
	public sbyte GetSnapshotDescription(sbyte ReturnValue) { return default; }
	public UPackage TransientWorldPackage;
	public UWorld RootSnapshotWorld;
	public TArray<UWorld> SnapshotSublevels;
	public FWorldSnapshotData SerializedData;
	public FSnapshotDataCache Cache;
	public bool bIsDiffCacheEnabled;
	public TMap<TWeakObjectPtr<AActor>,ECachedDiffResult> CachedDiffedActors;
	public FSoftObjectPath MapPath;
	public FDateTime CaptureTime;
	public sbyte SnapshotName;
	public sbyte SnapshotDescription;
}
