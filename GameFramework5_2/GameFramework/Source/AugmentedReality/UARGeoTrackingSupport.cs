#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARGeoTrackingSupport.h")]
///<summary>Interface class for Geo tracking related features.</summary>
public partial class UARGeoTrackingSupport : UObject {
// ARGeoTrackingSupport
	public UObject GetGeoTrackingSupport(UObject ReturnValue) { return default; }
	public EARGeoTrackingState GetGeoTrackingState(EARGeoTrackingState ReturnValue) { return default; }
	public EARGeoTrackingStateReason GetGeoTrackingStateReason(EARGeoTrackingStateReason ReturnValue) { return default; }
	public EARGeoTrackingAccuracy GetGeoTrackingAccuracy(EARGeoTrackingAccuracy ReturnValue) { return default; }
	public bool AddGeoAnchorAtLocation(float Longitude,float Latitude,sbyte OptionalAnchorName,bool ReturnValue) { return default; }
	public bool AddGeoAnchorAtLocationWithAltitude(float Longitude,float Latitude,float AltitudeMeters,sbyte OptionalAnchorName,bool ReturnValue) { return default; }
}
