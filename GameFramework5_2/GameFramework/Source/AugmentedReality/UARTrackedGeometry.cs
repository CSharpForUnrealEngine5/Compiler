#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTrackable.h")]
public partial class UARTrackedGeometry : UObject {
// ARTrackedGeometry
	public FTransform GetLocalToWorldTransform(FTransform ReturnValue) { return default; }
	public FTransform GetLocalToTrackingTransform(FTransform ReturnValue) { return default; }
	public EARTrackingState GetTrackingState(EARTrackingState ReturnValue) { return default; }
	public bool IsTracked(bool ReturnValue) { return default; }
	public sbyte GetDebugName(sbyte ReturnValue) { return default; }
	public sbyte GetName(sbyte ReturnValue) { return default; }
	public int GetLastUpdateFrameNumber(int ReturnValue) { return default; }
	public float GetLastUpdateTimestamp(float ReturnValue) { return default; }
	public UObject GetUnderlyingMesh(UObject ReturnValue) { return default; }
	public FGuid UniqueId;
	public EARObjectClassification GetObjectClassification(EARObjectClassification ReturnValue) { return default; }
	public bool HasSpatialMeshUsageFlag(EARSpatialMeshUsageFlags InFlag,bool ReturnValue) { return default; }
	public FTransform LocalToTrackingTransform;
	public FTransform LocalToAlignedTrackingTransform;
	public EARTrackingState TrackingState;
	public UMRMeshComponent UnderlyingMesh;
	public EARObjectClassification ObjectClassification;
	public EARSpatialMeshUsageFlags SpatialMeshUsageFlags;
	public int LastUpdateFrameNumber;
	public sbyte DebugName;
}
