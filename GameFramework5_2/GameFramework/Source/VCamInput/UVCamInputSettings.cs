#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamInputSettings.h")]
public partial class UVCamInputSettings : UDeveloperSettings {
// VCamInputSettings
	public sbyte DefaultInputProfile;
	public TMap<sbyte,FVCamInputProfile> InputProfiles;
	public UObject GetVCamInputSettings(UObject ReturnValue) { return default; }
	public void SetDefaultInputProfile(sbyte NewDefaultInputProfile) {}
	public void SetInputProfiles(TMap<sbyte,FVCamInputProfile> NewInputProfiles) {}
	public TArray<sbyte> GetInputProfileNames(TArray<sbyte> ReturnValue) { return default; }
}
