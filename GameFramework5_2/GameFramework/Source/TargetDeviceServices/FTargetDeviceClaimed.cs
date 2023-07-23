#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TargetDeviceServiceMessages.h")]
///<summary>Implements a message that is sent when a service claimed a device.</summary>
public partial struct FTargetDeviceClaimed {
// TargetDeviceClaimed
	public sbyte DeviceName;
	public sbyte HostName;
	public sbyte HostUser;
}
