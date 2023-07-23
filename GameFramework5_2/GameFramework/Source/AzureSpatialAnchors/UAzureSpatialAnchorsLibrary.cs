#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AzureSpatialAnchorsFunctionLibrary.h")]
///<summary>A function library that provides static/Blueprint functions for AzureSpatialAnchors.</summary>
public partial class UAzureSpatialAnchorsLibrary : UBlueprintFunctionLibrary {
// AzureSpatialAnchorsLibrary
	public bool CreateSession(bool ReturnValue) { return default; }
	public bool ConfigSession(sbyte AccountId,sbyte AccountKey,FCoarseLocalizationSettings CoarseLocalizationSettings,EAzureSpatialAnchorsLogVerbosity LogVerbosity,bool ReturnValue) { return default; }
	public bool ConfigSession2(FAzureSpatialAnchorsSessionConfiguration SessionConfiguration,FCoarseLocalizationSettings CoarseLocalizationSettings,EAzureSpatialAnchorsLogVerbosity LogVerbosity,bool ReturnValue) { return default; }
	public bool StartSession(bool ReturnValue) { return default; }
	public bool StopSession(bool ReturnValue) { return default; }
	public bool DestroySession(bool ReturnValue) { return default; }
	public bool GetCachedSessionStatus(FAzureSpatialAnchorsSessionStatus OutStatus,bool ReturnValue) { return default; }
	public void GetSessionStatus(UObject WorldContextObject,FLatentActionInfo LatentInfo,FAzureSpatialAnchorsSessionStatus OutStatus,EAzureSpatialAnchorsResult OutResult,sbyte OutErrorString) {}
	public void GetCloudAnchor(UObject ARPin,UObject OutAzureCloudSpatialAnchor) {}
	public void GetCloudAnchors(TArray<UObject> OutCloudAnchors) {}
	public void SavePinToCloud(UObject WorldContextObject,FLatentActionInfo LatentInfo,UObject ARPin,float Lifetime,UObject OutAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,sbyte OutErrorString) {}
	public void SavePinToCloudWithAppProperties(UObject WorldContextObject,FLatentActionInfo LatentInfo,UObject ARPin,float Lifetime,TMap<sbyte,sbyte> InAppProperties,UObject OutAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,sbyte OutErrorString) {}
	public void DeleteCloudAnchor(UObject WorldContextObject,FLatentActionInfo LatentInfo,UObject CloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,sbyte OutErrorString) {}
	public void LoadCloudAnchor(UObject WorldContextObject,FLatentActionInfo LatentInfo,sbyte CloudIdentifier,sbyte PinId,UObject OutARPin,UObject OutAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,sbyte OutErrorString) {}
	public void ConstructCloudAnchor(UObject ARPin,UObject OutAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,sbyte OutErrorString) {}
	public void SaveCloudAnchor(UObject WorldContextObject,FLatentActionInfo LatentInfo,UObject InAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,sbyte OutErrorString) {}
	public void UpdateCloudAnchorProperties(UObject WorldContextObject,FLatentActionInfo LatentInfo,UObject InAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,sbyte OutErrorString) {}
	public void RefreshCloudAnchorProperties(UObject WorldContextObject,FLatentActionInfo LatentInfo,UObject InAzureCloudSpatialAnchor,EAzureSpatialAnchorsResult OutResult,sbyte OutErrorString) {}
	public void CreateWatcher(UObject WorldContextObject,FAzureSpatialAnchorsLocateCriteria InLocateCriteria,int OutWatcherIdentifier,EAzureSpatialAnchorsResult OutResult,sbyte OutErrorString) {}
	public bool StopWatcher(int InWatcherIdentifier,bool ReturnValue) { return default; }
	public bool CreateARPinAroundAzureCloudSpatialAnchor(sbyte PinId,UObject InAzureCloudSpatialAnchor,UObject OutARPin,bool ReturnValue) { return default; }
}
