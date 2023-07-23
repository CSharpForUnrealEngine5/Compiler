#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OSCClient.h")]
public partial class UOSCClient : UObject {
// OSCClient
	public void GetSendIPAddress(sbyte IPAddress,int Port) {}
	public bool SetSendIPAddress(sbyte IPAddress,int Port,bool ReturnValue) { return default; }
	public void SendOSCMessage(FOSCMessage Message) {}
	public void SendOSCBundle(FOSCBundle Bundle) {}
}
