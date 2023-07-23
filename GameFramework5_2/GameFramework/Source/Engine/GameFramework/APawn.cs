#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/Pawn.h")]
///<summary>Pawn is the base class of all actors that can be possessed by players or AI.</summary>
public partial class APawn : AActor {
// Pawn
	public UObject GetMovementComponent(UObject ReturnValue) { return default; }
	public bool bUseControllerRotationPitch;
	public bool bUseControllerRotationYaw;
	public bool bUseControllerRotationRoll;
	public bool bCanAffectNavigationGeneration;
	public bool bIsLocalViewTarget;
	public float BaseEyeHeight;
	public byte AutoPossessPlayer;
	public EAutoPossessAI AutoPossessAI;
	public byte RemoteViewPitch;
	public UClass AIControllerClass;
	public void PawnMakeNoise(float Loudness,FVector NoiseLocation,bool bUseNoiseMakerLocation=true,UObject NoiseMaker=nullptr) {}
	public UObject GetLocalViewingPlayerController(UObject ReturnValue) { return default; }
	public bool IsLocallyViewed(bool ReturnValue) { return default; }
	public APlayerState PlayerState;
	public AController LastHitBy;
	public AController Controller;
	public AController PreviousController;
	public UObject GetMovementBaseActor(UObject Pawn,UObject ReturnValue) { return default; }
	public bool IsControlled(bool ReturnValue) { return default; }
	public bool IsPawnControlled(bool ReturnValue) { return default; }
	public UObject GetController(UObject ReturnValue) { return default; }
	public FRotator GetControlRotation(FRotator ReturnValue) { return default; }
	public void OnRep_Controller() {}
	public void OnRep_PlayerState() {}
	public void SetCanAffectNavigationGeneration(bool bNewValue,bool bForceUpdate=false) {}
	public FVector GetNavAgentLocation(FVector ReturnValue) { return default; }
	public void ReceivePossessed(UObject NewController) {}
	public void ReceiveUnpossessed(UObject OldController) {}
	public void ReceiveControllerChanged(UObject OldController,UObject NewController) {}
	public FPawnControllerChangedSignature ReceiveControllerChangedDelegate;
	public void ReceiveRestarted() {}
	public FPawnRestartedSignature ReceiveRestartedDelegate;
	public bool IsLocallyControlled(bool ReturnValue) { return default; }
	public FPlatformUserId GetPlatformUserId(FPlatformUserId ReturnValue) { return default; }
	public bool IsPlayerControlled(bool ReturnValue) { return default; }
	public bool IsBotControlled(bool ReturnValue) { return default; }
	public FRotator GetBaseAimRotation(FRotator ReturnValue) { return default; }
	public void DetachFromControllerPendingDestroy() {}
	public void SpawnDefaultController() {}
	public void AddMovementInput(FVector WorldDirection,float ScaleValue=1.0f,bool bForce=false) {}
	public FVector GetPendingMovementInputVector(FVector ReturnValue) { return default; }
	public FVector GetLastMovementInputVector(FVector ReturnValue) { return default; }
	public FVector ConsumeMovementInputVector(FVector ReturnValue) { return default; }
	public void AddControllerPitchInput(float Val) {}
	public void AddControllerYawInput(float Val) {}
	public void AddControllerRollInput(float Val) {}
	public bool IsMoveInputIgnored(bool ReturnValue) { return default; }
	public UClass GetOverrideInputComponentClass(UClass ReturnValue) { return default; }
	public FVector ControlInputVector;
	public FVector LastControlInputVector;
	public UClass OverrideInputComponentClass;
}
