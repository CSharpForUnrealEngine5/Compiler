#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreServicesFunctionLibrary.h")]
///<summary>A function library that provides static/Blueprint functions for Google ARCore Services.</summary>
public partial class UGoogleARCoreServicesFunctionLibrary : UBlueprintFunctionLibrary {
// GoogleARCoreServicesFunctionLibrary
	public bool ConfigGoogleARCoreServices(FGoogleARCoreServicesConfig ServiceConfig,bool ReturnValue) { return default; }
	public void CreateAndHostCloudARPinLatentAction(UObject WorldContextObject,FLatentActionInfo LatentInfo,UObject ARPinToHost,EARPinCloudTaskResult OutHostingResult,UObject OutCloudARPin) {}
	public void CreateAndResolveCloudARPinLatentAction(UObject WorldContextObject,FLatentActionInfo LatentInfo,sbyte CloudId,EARPinCloudTaskResult OutAcquiringResult,UObject OutCloudARPin) {}
	public UObject CreateAndHostCloudARPin(UObject ARPinToHost,EARPinCloudTaskResult OutTaskResult,UObject ReturnValue) { return default; }
	public UObject CreateAndResolveCloudARPin(sbyte CloudId,EARPinCloudTaskResult OutTaskResult,UObject ReturnValue) { return default; }
	public void RemoveCloudARPin(UObject PinToRemove) {}
	public TArray<UObject> GetAllCloudARPin(TArray<UObject> ReturnValue) { return default; }
}
