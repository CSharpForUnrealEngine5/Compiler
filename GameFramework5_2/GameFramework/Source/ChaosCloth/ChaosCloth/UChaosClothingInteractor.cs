#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosCloth/ChaosClothingSimulationInteractor.h")]
public partial class UChaosClothingInteractor : UClothingInteractor {
// ChaosClothingInteractor
	public void SetMaterialLinear(float EdgeStiffness=1.f,float BendingStiffness=1.f,float AreaStiffness=1.f) {}
	public void SetMaterial(FVector2D EdgeStiffness=FVector2D,FVector2D BendingStiffness=FVector2D,FVector2D AreaStiffness=FVector2D) {}
	public void SetLongRangeAttachmentLinear(float TetherStiffness=1.f,float TetherScale=1.f) {}
	public void SetLongRangeAttachment(FVector2D TetherStiffness=FVector2D,FVector2D TetherScale=FVector2D) {}
	public void SetCollision(float CollisionThickness=1.f,float FrictionCoefficient=0.8f,bool bUseCCD=false,float SelfCollisionThickness=2.f) {}
	public void SetBackstop(bool bEnabled=true) {}
	public void SetDamping(float DampingCoefficient=0.01f,float LocalDampingCoefficient=0.f) {}
	public void SetAerodynamics(float DragCoefficient=0.07f,float LiftCoefficient=0.035f,FVector WindVelocity=FVector) {}
	public void SetWind(FVector2D Drag=FVector2D,FVector2D Lift=FVector2D,float AirDensity=1.225e-6f,FVector WindVelocity=FVector) {}
	public void SetPressure(FVector2D Pressure=FVector2D) {}
	public void SetGravity(float GravityScale=1.f,bool bIsGravityOverridden=false,FVector GravityOverride=FVector) {}
	public void SetAnimDriveLinear(float AnimDriveStiffness=0.f) {}
	public void SetAnimDrive(FVector2D AnimDriveStiffness=FVector2D,FVector2D AnimDriveDamping=FVector2D) {}
	public void SetVelocityScale(FVector LinearVelocityScale=FVector,float AngularVelocityScale=0.75f,float FictitiousAngularScale=1.f) {}
	public void ResetAndTeleport(bool bReset=false,bool bTeleport=false) {}
}
