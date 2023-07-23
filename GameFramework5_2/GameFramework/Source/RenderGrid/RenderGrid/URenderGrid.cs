#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RenderGrid/RenderGrid.h")]
///<summary>This class represents a render grid, which is basically just a collection of render grid jobs.</summary>
public partial class URenderGrid : UObject {
// RenderGrid
	public void ReceiveBeginEditor() {}
	public void ReceiveEndEditor() {}
	public void ReceiveTick(float DeltaTime) {}
	public void ReceiveBeginBatchRender(UObject Queue) {}
	public void ReceiveEndBatchRender(UObject Queue) {}
	public void ReceiveBeginJobRender(UObject Queue,UObject Job) {}
	public void ReceiveEndJobRender(UObject Queue,UObject Job) {}
	public void ReceiveBeginViewportRender(UObject Job) {}
	public void ReceiveEndViewportRender(UObject Job) {}
	public UObject Render(UObject ReturnValue) { return default; }
	public UObject RenderJobs(TArray<UObject> Jobs,UObject ReturnValue) { return default; }
	public UObject RenderJob(UObject Job,UObject ReturnValue) { return default; }
	public FGuid GetGuid(FGuid ReturnValue) { return default; }
	public void GenerateNewGuid() {}
	public void SetPropsSource(ERenderGridPropsSourceType InPropsSourceType,UObject InPropsSourceOrigin=nullptr) {}
	public UObject GetPropsSource(UObject ReturnValue) { return default; }
	public ERenderGridPropsSourceType GetPropsSourceType(ERenderGridPropsSourceType ReturnValue) { return default; }
	public UObject GetPropsSourceOrigin(UObject ReturnValue) { return default; }
	public UObject GetDefaultLevelSequence(UObject ReturnValue) { return default; }
	public void SetDefaultLevelSequence(UObject NewSequence) {}
	public UObject GetDefaultRenderPreset(UObject ReturnValue) { return default; }
	public UObject GetDefaultRenderPresetOutputSettings(UObject ReturnValue) { return default; }
	public void SetDefaultRenderPreset(UObject NewRenderPreset) {}
	public sbyte GetDefaultOutputDirectory(sbyte ReturnValue) { return default; }
	public sbyte GetDefaultOutputDirectoryForDisplay(sbyte ReturnValue) { return default; }
	public void SetDefaultOutputDirectory(sbyte NewOutputDirectory) {}
	public void ClearRenderGridJobs() {}
	public void SetRenderGridJobs(TArray<UObject> Jobs) {}
	public void AddRenderGridJob(UObject Job) {}
	public void RemoveRenderGridJob(UObject Job) {}
	public void InsertRenderGridJob(UObject Job,int Index) {}
	public bool HasAnyRenderGridJobs(bool ReturnValue) { return default; }
	public bool HasRenderGridJob(UObject Job,bool ReturnValue) { return default; }
	public int GetIndexOfRenderGridJob(UObject Job,int ReturnValue) { return default; }
	public TArray<UObject> GetRenderGridJobs(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetEnabledRenderGridJobs(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetDisabledRenderGridJobs(TArray<UObject> ReturnValue) { return default; }
	public void InsertRenderGridJobBefore(UObject Job,UObject BeforeJob) {}
	public void InsertRenderGridJobAfter(UObject Job,UObject AfterJob) {}
	public sbyte GenerateUniqueRandomJobId(sbyte ReturnValue) { return default; }
	public sbyte GenerateNextJobId(sbyte ReturnValue) { return default; }
	public bool DoesJobIdExist(sbyte JobId,bool ReturnValue) { return default; }
	public UObject CreateTempRenderGridJob(UObject ReturnValue) { return default; }
	public UObject CreateAndAddNewRenderGridJob(UObject ReturnValue) { return default; }
	public UObject DuplicateAndAddRenderGridJob(UObject Job,UObject ReturnValue) { return default; }
	public bool ReorderRenderGridJob(UObject Job,UObject DroppedOnJob,bool bAfter=true,bool ReturnValue) { return default; }
	public FGuid Guid;
	public URenderGridSettings Settings;
	public URenderGridDefaults Defaults;
	public TArray<URenderGridJob> RenderGridJobs;
	public bool bExecutingBlueprintEvent;
}
