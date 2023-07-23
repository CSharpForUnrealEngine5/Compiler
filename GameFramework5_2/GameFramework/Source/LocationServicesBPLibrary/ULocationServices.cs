#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LocationServicesBPLibrary.h")]
public partial class ULocationServices : UBlueprintFunctionLibrary {
// LocationServices
	public bool InitLocationServices(ELocationAccuracy Accuracy,float UpdateFrequency,float MinDistanceFilter,bool ReturnValue) { return default; }
	public bool StartLocationServices(bool ReturnValue) { return default; }
	public bool StopLocationServices(bool ReturnValue) { return default; }
	public FLocationServicesData GetLastKnownLocation(FLocationServicesData ReturnValue) { return default; }
	public bool AreLocationServicesEnabled(bool ReturnValue) { return default; }
	public bool IsLocationAccuracyAvailable(ELocationAccuracy Accuracy,bool ReturnValue) { return default; }
	public UObject GetLocationServicesImpl(UObject ReturnValue) { return default; }
}
