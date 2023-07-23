#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionTrajectoryLibrary.h")]
public partial class UMotionTrajectoryBlueprintLibrary : UBlueprintFunctionLibrary {
// MotionTrajectoryBlueprintLibrary
	public FTrajectorySampleRange FlattenTrajectory2D(FTrajectorySampleRange Trajectory,FTrajectorySampleRange ReturnValue) { return default; }
	public FTrajectorySampleRange RotateTrajectory(FTrajectorySampleRange Trajectory,FQuat Rotation,FTrajectorySampleRange ReturnValue) { return default; }
	public FTrajectorySampleRange MakeTrajectoryRelativeToComponent(FTrajectorySampleRange ActorTrajectory,UObject Component,FTrajectorySampleRange ReturnValue) { return default; }
	public void DebugDrawTrajectory(UObject Actor,FTransform WorldTransform,FTrajectorySampleRange Trajectory,FLinearColor PredictionColor=FLinearColor,FLinearColor HistoryColor=FLinearColor,float TransformScale=10.f,float TransformThickness=2.f,float ArrowScale=0.025f,float ArrowSize=40.f,float ArrowThickness=2.f) {}
	public bool IsStoppingTrajectory(FTrajectorySampleRange Trajectory,float MoveMinSpeed=1.0f,float IdleMaxSpeed=0.0f,bool ReturnValue) { return default; }
	public bool IsStartingTrajectory(FTrajectorySampleRange Trajectory,float MoveMinSpeed=1.0f,float IdleMaxSpeed=0.0f,bool ReturnValue) { return default; }
	public bool IsConstantSpeedTrajectory(FTrajectorySampleRange Trajectory,float Speed=0.0f,float Tolerance=0.001f,bool ReturnValue) { return default; }
}
