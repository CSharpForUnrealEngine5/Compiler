#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlRequest.h")]
///<summary>Holds a request to search for an actor.</summary>
public partial struct FSearchActorRequest {
// SearchActorRequest
	public sbyte Query;
	public sbyte Class;
	public int Limit;
}
