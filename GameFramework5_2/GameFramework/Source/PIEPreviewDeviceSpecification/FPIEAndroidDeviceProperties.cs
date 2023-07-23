#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PIEPreviewDeviceSpecification.h")]
public partial struct FPIEAndroidDeviceProperties {
// PIEAndroidDeviceProperties
	public sbyte GPUFamily;
	public sbyte GLVersion;
	public sbyte VulkanVersion;
	public sbyte AndroidVersion;
	public sbyte DeviceMake;
	public sbyte DeviceModel;
	public sbyte DeviceBuildNumber;
	public bool VulkanAvailable;
	public bool UsingHoudini;
	public sbyte Hardware;
	public sbyte Chipset;
	public sbyte TotalPhysicalGB;
	public sbyte HMDSystemName;
	public FPIERHIOverrideState GLES31RHIState;
}
