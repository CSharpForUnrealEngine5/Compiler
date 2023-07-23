#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DeviceProfiles/DeviceProfile.h")]
public partial class UDeviceProfile : UTextureLODSettings {
// DeviceProfile
	public sbyte DeviceType;
	public sbyte BaseProfileName;
	public bool bIsVisibleForAssets;
	public UDeviceProfile Parent;
	public TArray<sbyte> CVars;
	public TArray<FDPMatchingRulestruct> MatchingRules;
}
