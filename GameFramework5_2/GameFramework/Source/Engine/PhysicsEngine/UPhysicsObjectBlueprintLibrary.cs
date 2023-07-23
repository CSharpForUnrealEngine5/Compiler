#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicsObjectBlueprintLibrary.h")]
public partial class UPhysicsObjectBlueprintLibrary : UBlueprintFunctionLibrary {
// PhysicsObjectBlueprintLibrary
	public FClosestPhysicsObjectResult GetClosestPhysicsObjectFromWorldLocation(UObject Component,FVector WorldLocation,FClosestPhysicsObjectResult ReturnValue) { return default; }
	public bool ExtractClosestPhysicsObjectResults(FClosestPhysicsObjectResult Result,sbyte OutName,bool ReturnValue) { return default; }
	public FTransform GetPhysicsObjectWorldTransform(UObject Component,sbyte BoneName,FTransform ReturnValue) { return default; }
}
