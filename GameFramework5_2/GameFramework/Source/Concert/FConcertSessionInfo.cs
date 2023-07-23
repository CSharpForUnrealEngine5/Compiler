#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessageData.h")]
///<summary>Holds info on a session</summary>
public partial struct FConcertSessionInfo {
// ConcertSessionInfo
	public FGuid ServerInstanceId;
	public FGuid ServerEndpointId;
	public FGuid OwnerInstanceId;
	public FGuid SessionId;
	public sbyte SessionName;
	public sbyte OwnerUserName;
	public sbyte OwnerDeviceName;
	public FConcertSessionSettings Settings;
	public TArray<FConcertSessionVersionInfo> VersionInfos;
	public EConcertSessionState State;
	public long LastModifiedTicks;
}
