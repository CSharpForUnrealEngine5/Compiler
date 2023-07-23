#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TargetDeviceServiceMessages.h")]
///<summary>Implements a message that is sent when a device is no longer claimed.</summary>
public partial struct FTargetDeviceUnclaimed {
// TargetDeviceUnclaimed
	public sbyte DeviceName;
	public sbyte HostName;
	public sbyte HostUser;
}