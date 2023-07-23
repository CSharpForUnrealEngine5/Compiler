#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PIEPreviewDeviceSpecification.h")]
public partial class UPIEPreviewDeviceSpecification : UObject {
// PIEPreviewDeviceSpecification
	public EPIEPreviewDeviceType PreviewDeviceType;
	public sbyte GPUFamily;
	public sbyte GLVersion;
	public sbyte VulkanVersion;
	public sbyte AndroidVersion;
	public sbyte DeviceMake;
	public sbyte DeviceModel;
	public sbyte DeviceBuildNumber;
	public bool UsingHoudini;
	public sbyte Hardware;
	public sbyte Chipset;
}
