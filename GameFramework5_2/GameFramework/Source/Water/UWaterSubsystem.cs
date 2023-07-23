#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterSubsystem.h")]
///<summary>This is the API used to get information about water at runtime</summary>
public partial class UWaterSubsystem : UTickableWorldSubsystem {
// WaterSubsystem
	public bool IsShallowWaterSimulationEnabled(bool ReturnValue) { return default; }
	public bool IsUnderwaterPostProcessEnabled(bool ReturnValue) { return default; }
	public int GetShallowWaterMaxDynamicForces(int ReturnValue) { return default; }
	public int GetShallowWaterMaxImpulseForces(int ReturnValue) { return default; }
	public int GetShallowWaterSimulationRenderTargetSize(int ReturnValue) { return default; }
	public bool IsWaterRenderingEnabled(bool ReturnValue) { return default; }
	public float GetWaterTimeSeconds(float ReturnValue) { return default; }
	public float GetSmoothedWorldTimeSeconds(float ReturnValue) { return default; }
	public float GetCameraUnderwaterDepth(float ReturnValue) { return default; }
	public void PrintToWaterLog(sbyte Message,bool bWarning) {}
	public float GetOceanBaseHeight(float ReturnValue) { return default; }
	public float GetOceanFloodHeight(float ReturnValue) { return default; }
	public float GetOceanTotalHeight(float ReturnValue) { return default; }
	public void SetOceanFloodHeight(float InFloodHeight) {}
	public ABuoyancyManager BuoyancyManager;
	public FOnCameraUnderwaterStateChanged OnCameraUnderwaterStateChanged;
	public FOnWaterScalabilityChanged OnWaterScalabilityChanged;
	public UStaticMesh DefaultRiverMesh;
	public UStaticMesh DefaultLakeMesh;
	public UMaterialParameterCollection MaterialParameterCollection;
}
