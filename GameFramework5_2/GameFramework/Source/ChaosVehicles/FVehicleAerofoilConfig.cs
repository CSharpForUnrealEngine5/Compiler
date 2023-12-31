#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosVehicleMovementComponent.h")]
public partial struct FVehicleAerofoilConfig {
// VehicleAerofoilConfig
	public EVehicleAerofoilType AerofoilType;
	public string BoneName;
	public FVector Offset;
	public FVector UpAxis;
	public float Area;
	public float Camber;
	public float MaxControlAngle;
	public float StallAngle;
	public float LiftMultiplier;
	public float DragMultiplier;
}
