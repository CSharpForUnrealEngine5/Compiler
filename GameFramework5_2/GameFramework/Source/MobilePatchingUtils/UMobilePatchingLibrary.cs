#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MobilePatchingLibrary.h")]
public partial class UMobilePatchingLibrary : UBlueprintFunctionLibrary {
// MobilePatchingLibrary
	public UObject GetInstalledContent(sbyte InstallDirectory,UObject ReturnValue) { return default; }
	public void RequestContent(sbyte RemoteManifestURL,sbyte CloudURL,sbyte InstallDirectory,FOnRequestContentSucceeded OnSucceeded,FOnRequestContentFailed OnFailed) {}
	public bool HasActiveWiFiConnection(bool ReturnValue) { return default; }
	public sbyte GetActiveDeviceProfileName(sbyte ReturnValue) { return default; }
	public TArray<sbyte> GetSupportedPlatformNames(TArray<sbyte> ReturnValue) { return default; }
}
