#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosFlesh/ChaosDeformableSolverComponent.h")]
public partial struct FSolverTimingGroup {
// SolverTimingGroup
	public int NumSubSteps;
	public int NumSolverIterations;
	public bool FixTimeStep;
	public float TimeStepSize;
	public bool bDoThreadedAdvance;
	public EDeformableExecutionModel ExecutionModel;
}
