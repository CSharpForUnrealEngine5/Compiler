#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RenderGrid/RenderGrid.h")]
///<summary>This class represents a render grid job, in other words, an entry (a row) of a render grid.</summary>
public partial class URenderGridJob : UObject {
// RenderGridJob
	public FIntPoint GetOutputResolution(FIntPoint ReturnValue) { return default; }
	public double GetOutputAspectRatio(double ReturnValue) { return default; }
	public bool MatchesSearchTerm(sbyte SearchTerm,bool ReturnValue) { return default; }
	public FGuid GetGuid(FGuid ReturnValue) { return default; }
	public void GenerateNewGuid() {}
	public int GetWaitFramesBeforeRendering(int ReturnValue) { return default; }
	public void SetWaitFramesBeforeRendering(int NewWaitFramesBeforeRendering) {}
	public UObject GetLevelSequence(UObject ReturnValue) { return default; }
	public void SetLevelSequence(UObject NewSequence) {}
	public bool GetIsUsingCustomStartFrame(bool ReturnValue) { return default; }
	public void SetIsUsingCustomStartFrame(bool bNewOverrideStartFrame) {}
	public int GetCustomStartFrame(int ReturnValue) { return default; }
	public void SetCustomStartFrame(int NewCustomStartFrame) {}
	public bool GetIsUsingCustomEndFrame(bool ReturnValue) { return default; }
	public void SetIsUsingCustomEndFrame(bool bNewOverrideEndFrame) {}
	public int GetCustomEndFrame(int ReturnValue) { return default; }
	public void SetCustomEndFrame(int NewCustomEndFrame) {}
	public bool GetIsUsingCustomResolution(bool ReturnValue) { return default; }
	public void SetIsUsingCustomResolution(bool bNewOverrideResolution) {}
	public FIntPoint GetCustomResolution(FIntPoint ReturnValue) { return default; }
	public void SetCustomResolution(FIntPoint NewCustomResolution) {}
	public sbyte GetJobId(sbyte ReturnValue) { return default; }
	public void SetJobId(sbyte NewJobId) {}
	public sbyte GetJobName(sbyte ReturnValue) { return default; }
	public void SetJobName(sbyte NewJobName) {}
	public bool GetIsEnabled(bool ReturnValue) { return default; }
	public void SetIsEnabled(bool bEnabled) {}
	public sbyte GetOutputDirectory(sbyte ReturnValue) { return default; }
	public sbyte GetOutputDirectoryForDisplay(sbyte ReturnValue) { return default; }
	public void SetOutputDirectory(sbyte NewOutputDirectory) {}
	public UObject GetRenderPreset(UObject ReturnValue) { return default; }
	public UObject GetRenderPresetOutputSettings(UObject ReturnValue) { return default; }
	public void SetRenderPreset(UObject NewRenderPreset) {}
	public bool HasRemoteControlValue(FGuid FieldId,bool ReturnValue) { return default; }
	public bool GetRemoteControlValue(FGuid FieldId,sbyte OutJson,bool ReturnValue) { return default; }
	public bool SetRemoteControlValue(FGuid FieldId,sbyte Json,bool ReturnValue) { return default; }
	public bool GetRemoteControlFieldIdFromLabel(sbyte Label,FGuid OutFieldId,bool ReturnValue) { return default; }
	public bool GetRemoteControlLabelFromFieldId(FGuid FieldId,sbyte OutLabel,bool ReturnValue) { return default; }
	public TMap<FGuid,sbyte> GetRemoteControlValues(TMap<FGuid,sbyte> ReturnValue) { return default; }
	public FGuid Guid;
	public int WaitFramesBeforeRendering;
	public ULevelSequence LevelSequence;
	public bool bOverrideStartFrame;
	public int CustomStartFrame;
	public bool bOverrideEndFrame;
	public int CustomEndFrame;
	public bool bOverrideResolution;
	public FIntPoint CustomResolution;
	public bool bIsEnabled;
	public sbyte JobId;
	public sbyte JobName;
	public sbyte OutputDirectory;
	public UMoviePipelinePrimaryConfig RenderPreset;
	public TMap<FGuid,FRenderGridRemoteControlPropertyData> RemoteControlValues;
}
