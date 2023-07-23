#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARPin.h")]
public partial class UARPin : UObject {
// ARPin
	public FTransform GetLocalToTrackingTransform(FTransform ReturnValue) { return default; }
	public FTransform GetLocalToWorldTransform(FTransform ReturnValue) { return default; }
	public EARTrackingState GetTrackingState(EARTrackingState ReturnValue) { return default; }
	public UObject GetTrackedGeometry(UObject ReturnValue) { return default; }
	public UObject GetPinnedComponent(UObject ReturnValue) { return default; }
	public void DebugDraw(UObject World,FLinearColor Color,float Scale,float PersistForSeconds) {}
	public sbyte GetDebugName(sbyte ReturnValue) { return default; }
	public UARTrackedGeometry TrackedGeometry;
	public USceneComponent PinnedComponent;
	public FTransform LocalToTrackingTransform;
	public FTransform LocalToAlignedTrackingTransform;
	public EARTrackingState TrackingState;
	public FOnARTrackingStateChanged OnARTrackingStateChanged;
	public FOnARTransformUpdated OnARTransformUpdated;
}
