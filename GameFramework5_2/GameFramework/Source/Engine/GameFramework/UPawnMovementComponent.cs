#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/PawnMovementComponent.h")]
///<summary>PawnMovementComponent can be used to update movement for an associated Pawn.</summary>
public partial class UPawnMovementComponent : UNavMovementComponent {
// PawnMovementComponent
	public void AddInputVector(FVector WorldVector,bool bForce=false) {}
	public FVector GetPendingInputVector(FVector ReturnValue) { return default; }
	public FVector GetLastInputVector(FVector ReturnValue) { return default; }
	public FVector ConsumeInputVector(FVector ReturnValue) { return default; }
	public bool IsMoveInputIgnored(bool ReturnValue) { return default; }
	public UObject GetPawnOwner(UObject ReturnValue) { return default; }
	public APawn PawnOwner;
}
