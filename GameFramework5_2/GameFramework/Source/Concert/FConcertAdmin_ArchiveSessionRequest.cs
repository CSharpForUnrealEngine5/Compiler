#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
///<summary>Create an archived copy of a live session.</summary>
public partial struct FConcertAdmin_ArchiveSessionRequest {
// ConcertAdmin_ArchiveSessionRequest
	public FGuid SessionId;
	public sbyte ArchiveNameOverride;
	public sbyte UserName;
	public sbyte DeviceName;
	public FConcertSessionFilter SessionFilter;
}
