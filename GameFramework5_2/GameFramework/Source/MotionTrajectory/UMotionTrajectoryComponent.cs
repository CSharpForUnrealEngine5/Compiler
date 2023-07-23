#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionTrajectory.h")]
///<summary>Abstract component interface for the minimum Motion Trajectory prediction and history API</summary>
public partial class UMotionTrajectoryComponent : UActorComponent {
// MotionTrajectoryComponent
	public FTrajectorySampleRange GetTrajectory(FTrajectorySampleRange ReturnValue) { return default; }
	public FTrajectorySampleRange GetTrajectoryWithSettings(FMotionTrajectorySettings Settings,bool bIncludeHistory,FTrajectorySampleRange ReturnValue) { return default; }
	public FTrajectorySampleRange GetHistory(FTrajectorySampleRange ReturnValue) { return default; }
	public FMotionTrajectorySettings PredictionSettings;
	public FMotionTrajectorySettings HistorySettings;
	public int SampleRate;
	public int MaxSamples;
	public bool bPredictionIncludesHistory;
	public bool bDebugDrawTrajectory;
}
