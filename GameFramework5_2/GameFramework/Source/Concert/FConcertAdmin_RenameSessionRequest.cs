#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
///<summary>Rename a session.</summary>
public partial struct FConcertAdmin_RenameSessionRequest {
// ConcertAdmin_RenameSessionRequest
	public FGuid SessionId;
	public sbyte NewName;
	public sbyte UserName;
	public sbyte DeviceName;
}
