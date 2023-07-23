#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARGeoTrackingSupport.h")]
///<summary>Blueprint async task to check Geo tracking availability.</summary>
public partial class UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy : UARBaseAsyncTaskBlueprintProxy {
// CheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy
	public void FGeoTrackingAvailabilityDelegate(bool bIsAvailable,sbyte Error) {}
	public FGeoTrackingAvailabilityDelegate OnSuccess;
	public FGeoTrackingAvailabilityDelegate OnFailed;
	public UObject CheckGeoTrackingAvailability(UObject WorldContextObject,UObject ReturnValue) { return default; }
	public UObject CheckGeoTrackingAvailabilityAtLocation(UObject WorldContextObject,float Longitude,float Latitude,UObject ReturnValue) { return default; }
}
