#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TargetDeviceServiceMessages.h")]
///<summary>Implements a message that is sent in response to target device service discovery messages.</summary>
public partial struct FTargetDeviceServicePong {
// TargetDeviceServicePong
	public bool Connected;
	public bool Authorized;
	public sbyte HostName;
	public sbyte HostUser;
	public sbyte Make;
	public sbyte Model;
	public sbyte Name;
	public sbyte DeviceUser;
	public sbyte DeviceUserPassword;
	public bool Shared;
	public bool SupportsMultiLaunch;
	public bool SupportsPowerOff;
	public bool SupportsPowerOn;
	public bool SupportsReboot;
	public bool SupportsVariants;
	public sbyte Type;
	public sbyte DefaultVariant;
	public TArray<FTargetDeviceVariant> Variants;
	public bool Aggregated;
	public sbyte AllDevicesName;
	public sbyte AllDevicesDefaultVariant;
}
