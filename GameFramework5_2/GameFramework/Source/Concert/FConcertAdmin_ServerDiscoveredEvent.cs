#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_ServerDiscoveredEvent {
// ConcertAdmin_ServerDiscoveredEvent
	public sbyte ServerName;
	public FConcertInstanceInfo InstanceInfo;
	public EConcertServerFlags ServerFlags;
}
