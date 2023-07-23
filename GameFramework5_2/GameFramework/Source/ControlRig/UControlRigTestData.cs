#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigTestData.h")]
public partial class UControlRigTestData : UObject {
// ControlRigTestData
	public UObject CreateNewAsset(sbyte InDesiredPackagePath,sbyte InBlueprintPathName,UObject ReturnValue) { return default; }
	public FVector2D GetTimeRange(bool bInput=false,FVector2D ReturnValue) { return default; }
	public int GetFrameIndexForTime(double InSeconds,bool bInput=false,int ReturnValue) { return default; }
	public bool Record(UObject InControlRig,double InRecordingDuration=0.0,bool ReturnValue) { return default; }
	public bool SetupReplay(UObject InControlRig,bool bGroundTruth=true,bool ReturnValue) { return default; }
	public void ReleaseReplay() {}
	public EControlRigTestDataPlaybackMode GetPlaybackMode(EControlRigTestDataPlaybackMode ReturnValue) { return default; }
	public bool IsReplaying(bool ReturnValue) { return default; }
	public bool IsRecording(bool ReturnValue) { return default; }
	public FSoftObjectPath ControlRigObjectPath;
	public FControlRigTestDataFrame Initial;
	public TArray<FControlRigTestDataFrame> InputFrames;
	public TArray<FControlRigTestDataFrame> OutputFrames;
	public TArray<int> FramesToSkip;
	public double Tolerance;
}
