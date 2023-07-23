#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StageAppResponse.h")]
///<summary>Event sent to a client when light cards were created at the request of the client.</summary>
public partial struct FRCRequestedActorsCreated {
// RCRequestedActorsCreated
	public sbyte Type;
	public TArray<sbyte> ActorPaths;
	public int RequestId;
}
