#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NUTActor.h")]
public partial class ANUTActor : AActor {
// NUTActor
	public FExecuteOnServer TempDelegate;
	public void Admin(sbyte Command) {}
	public void ServerAdmin(sbyte Command) {}
	public void UnitSeamlessTravel(sbyte Dest=TEXT) {}
	public void UnitTravel(sbyte Dest=TEXT) {}
	public void NetFlush() {}
	public void Wait(ushort Seconds) {}
	public void ServerClientStillAlive() {}
	public void ServerReceiveText(sbyte InText) {}
	public void ServerClientPing() {}
	public void NetMulticastPing() {}
	public void ServerExecute(sbyte InDelegate) {}
}
