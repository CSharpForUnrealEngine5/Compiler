#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_CreateSessionRequest {
// ConcertAdmin_CreateSessionRequest
	public sbyte SessionName;
	public FConcertClientInfo OwnerClientInfo;
	public FConcertSessionSettings SessionSettings;
	public FConcertSessionVersionInfo VersionInfo;
}
