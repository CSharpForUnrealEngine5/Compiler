#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/Controller.h")]
///<summary>Controllers are non-physical actors that can possess a Pawn to control</summary>
public partial class AController : AActor {
// Controller
	public APlayerState PlayerState;
	public FInstigatedAnyDamageSignature OnInstigatedAnyDamage;
	public FOnPossessedPawnChanged OnPossessedPawnChanged;
	public sbyte StateName;
	public APawn Pawn;
	public ACharacter Character;
	public USceneComponent TransformComponent;
	public FRotator ControlRotation;
	public bool bAttachToPawn;
	public FRotator GetControlRotation(FRotator ReturnValue) { return default; }
	public void SetControlRotation(FRotator NewRotation) {}
	public void SetInitialLocationAndRotation(FVector NewLocation,FRotator NewRotation) {}
	public bool LineOfSightTo(UObject Other,FVector ViewPoint=FVector,bool bAlternateChecks=false,bool ReturnValue) { return default; }
	public void OnRep_Pawn() {}
	public void OnRep_PlayerState() {}
	public void ClientSetLocation(FVector NewLocation,FRotator NewRotation) {}
	public void ClientSetRotation(FRotator NewRotation,bool bResetCamera) {}
	public UObject K2_GetPawn(UObject ReturnValue) { return default; }
	public UObject GetViewTarget(UObject ReturnValue) { return default; }
	public FRotator GetDesiredRotation(FRotator ReturnValue) { return default; }
	public bool IsPlayerController(bool ReturnValue) { return default; }
	public bool IsLocalPlayerController(bool ReturnValue) { return default; }
	public bool IsLocalController(bool ReturnValue) { return default; }
	public void Possess(UObject InPawn) {}
	public void UnPossess() {}
	public void ReceivePossess(UObject PossessedPawn) {}
	public void ReceiveUnPossess(UObject UnpossessedPawn) {}
	public void GetPlayerViewPoint(FVector Location,FRotator Rotation) {}
	public void StopMovement() {}
	public void SetIgnoreMoveInput(bool bNewMoveInput) {}
	public void ResetIgnoreMoveInput() {}
	public bool IsMoveInputIgnored(bool ReturnValue) { return default; }
	public void SetIgnoreLookInput(bool bNewLookInput) {}
	public void ResetIgnoreLookInput() {}
	public bool IsLookInputIgnored(bool ReturnValue) { return default; }
	public void ResetIgnoreInputFlags() {}
	public void ReceiveInstigatedAnyDamage(float Damage,UObject DamageType,UObject DamagedActor,UObject DamageCauser) {}
}
