#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Simulation/RigVMFunction_Accumulate.h")]
///<summary>Multiplies a vector over time over and over again</summary>
public partial struct FRigVMFunction_AccumulateVectorMul {
// RigVMFunction_AccumulateVectorMul
	public FVector Multiplier;
	public FVector InitialValue;
	public bool bIntegrateDeltaTime;
	public FVector Result;
	public FVector AccumulatedValue;
	public bool bIsInitialized;
}
