#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARGeoTrackingSupport.h")]
///<summary>Blueprint async task to convert Geo location.</summary>
public partial class UGetGeoLocationAsyncTaskBlueprintProxy : UARBaseAsyncTaskBlueprintProxy {
// GetGeoLocationAsyncTaskBlueprintProxy
	public void FGetGeoLocationDelegate(float Longitude,float Latitude,float Altitude,sbyte Error) {}
	public FGetGeoLocationDelegate OnSuccess;
	public FGetGeoLocationDelegate OnFailed;
	public UObject GetGeoLocationAtWorldPosition(UObject WorldContextObject,FVector WorldPosition,UObject ReturnValue) { return default; }
}
