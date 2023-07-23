#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BuoyancyComponent.h")]
public partial class UBuoyancyComponent : UActorComponent {
// BuoyancyComponent
	public TArray<UObject> GetCurrentWaterBodyComponents(TArray<UObject> ReturnValue) { return default; }
	public bool IsOverlappingWaterBody(bool ReturnValue) { return default; }
	public bool IsInWaterBody(bool ReturnValue) { return default; }
	public TArray<FSphericalPontoon> Pontoons_DEPRECATED;
	public void OnPontoonEnteredWater(FSphericalPontoon Pontoon) {}
	public void OnPontoonExitedWater(FSphericalPontoon Pontoon) {}
	public FOnPontoonEnteredWater OnEnteredWaterDelegate;
	public FOnPontoonExitedWater OnExitedWaterDelegate;
	public void GetLastWaterSurfaceInfo(FVector OutWaterPlaneLocation,FVector OutWaterPlaneNormal,FVector OutWaterSurfacePosition,float OutWaterDepth,int OutWaterBodyIdx,FVector OutWaterVelocity) {}
	public FBuoyancyData BuoyancyData;
	public TArray<UWaterBodyComponent> CurrentWaterBodyComponents;
	public UPrimitiveComponent SimulatingComponent;
}
