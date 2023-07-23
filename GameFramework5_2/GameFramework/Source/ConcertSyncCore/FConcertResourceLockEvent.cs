#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertWorkspaceMessages.h")]
public partial struct FConcertResourceLockEvent {
// ConcertResourceLockEvent
	public FGuid ClientId;
	public TArray<sbyte> ResourceNames;
	public EConcertResourceLockType LockType;
}
