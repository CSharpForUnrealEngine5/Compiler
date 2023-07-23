#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineQueue.h")]
///<summary>A particular job within the Queue</summary>
public partial class UMoviePipelineExecutorJob : UObject {
// MoviePipelineExecutorJob
	public void SetStatusMessage(sbyte InStatus) {}
	public sbyte GetStatusMessage(sbyte ReturnValue) { return default; }
	public void SetStatusProgress(float InProgress) {}
	public float GetStatusProgress(float ReturnValue) { return default; }
	public void SetConsumed(bool bInConsumed) {}
	public bool IsConsumed(bool ReturnValue) { return default; }
	public void SetIsEnabled(bool bInEnabled) {}
	public bool IsEnabled(bool ReturnValue) { return default; }
	public void OnDuplicated() {}
	public void SetPresetOrigin(UObject InPreset) {}
	public UObject GetPresetOrigin(UObject ReturnValue) { return default; }
	public UObject GetConfiguration(UObject ReturnValue) { return default; }
	public void SetConfiguration(UObject InPreset) {}
	public void SetSequence(FSoftObjectPath InSequence) {}
	public sbyte JobName;
	public FSoftObjectPath Sequence;
	public FSoftObjectPath Map;
	public sbyte Author;
	public sbyte Comment;
	public TArray<UMoviePipelineExecutorShot> ShotInfo;
	public sbyte UserData;
	public sbyte StatusMessage;
	public float StatusProgress;
	public bool bIsConsumed;
	public UMoviePipelinePrimaryConfig Configuration;
	public TSoftObjectPtr<UMoviePipelinePrimaryConfig> PresetOrigin;
	public bool bEnabled;
}
