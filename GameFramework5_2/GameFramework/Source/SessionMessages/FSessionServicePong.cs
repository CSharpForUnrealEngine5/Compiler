#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SessionServiceMessages.h")]
///<summary>Implements a message that is published in response to FSessionServicePing.</summary>
public partial struct FSessionServicePong {
// SessionServicePong
	public bool Authorized;
	public sbyte BuildDate;
	public sbyte DeviceName;
	public FGuid InstanceId;
	public sbyte InstanceName;
	public sbyte PlatformName;
	public FGuid SessionId;
	public sbyte SessionName;
	public sbyte SessionOwner;
	public bool Standalone;
}
