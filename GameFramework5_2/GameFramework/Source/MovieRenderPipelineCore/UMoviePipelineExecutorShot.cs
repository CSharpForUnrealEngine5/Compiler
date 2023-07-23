#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineQueue.h")]
///<summary>This class represents a segment of work within the Executor Job. This should be owned</summary>
public partial class UMoviePipelineExecutorShot : UObject {
// MoviePipelineExecutorShot
	public void SetStatusMessage(sbyte InStatus) {}
	public sbyte GetStatusMessage(sbyte ReturnValue) { return default; }
	public void SetStatusProgress(float InProgress) {}
	public float GetStatusProgress(float ReturnValue) { return default; }
	public UObject AllocateNewShotOverrideConfig(UClass InConfigType,UObject ReturnValue) { return default; }
	public void SetShotOverrideConfiguration(UObject InPreset) {}
	public void SetShotOverridePresetOrigin(UObject InPreset) {}
	public UObject GetShotOverrideConfiguration(UObject ReturnValue) { return default; }
	public UObject GetShotOverridePresetOrigin(UObject ReturnValue) { return default; }
	public bool ShouldRender(bool ReturnValue) { return default; }
	public sbyte GetCameraName(int InCameraIndex,sbyte ReturnValue) { return default; }
	public bool bEnabled;
	public sbyte OuterName;
	public sbyte InnerName;
	public TArray<FMoviePipelineSidecarCamera> SidecarCameras;
	public float Progress;
	public sbyte StatusMessage;
	public UMoviePipelineShotConfig ShotOverrideConfig;
	public TSoftObjectPtr<UMoviePipelineShotConfig> ShotOverridePresetOrigin;
}
