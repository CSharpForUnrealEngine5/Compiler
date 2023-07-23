#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Recorder/TakeRecorderBlueprintLibrary.h")]
public partial class UTakeRecorderBlueprintLibrary : UBlueprintFunctionLibrary {
// TakeRecorderBlueprintLibrary
	public bool IsTakeRecorderEnabled(bool ReturnValue) { return default; }
	public UObject StartRecording(UObject LevelSequence,UObject Sources,UObject MetaData,FTakeRecorderParameters Parameters,UObject ReturnValue) { return default; }
	public FTakeRecorderParameters GetDefaultParameters(FTakeRecorderParameters ReturnValue) { return default; }
	public void SetDefaultParameters(FTakeRecorderParameters DefaultParameters) {}
	public bool IsRecording(bool ReturnValue) { return default; }
	public UObject GetActiveRecorder(UObject ReturnValue) { return default; }
	public void StopRecording() {}
	public void CancelRecording() {}
	public UObject GetTakeRecorderPanel(UObject ReturnValue) { return default; }
	public UObject OpenTakeRecorderPanel(UObject ReturnValue) { return default; }
	public void SetOnTakeRecorderPanelChanged(FOnTakeRecorderPanelChanged OnTakeRecorderPanelChanged) {}
	public void SetOnTakeRecorderPreInitialize(FOnTakeRecorderPreInitialize OnTakeRecorderPreInitialize) {}
	public void SetOnTakeRecorderStarted(FOnTakeRecorderStarted OnTakeRecorderStarted) {}
	public void SetOnTakeRecorderStopped(FOnTakeRecorderStopped OnTakeRecorderStopped) {}
	public void SetOnTakeRecorderFinished(FOnTakeRecorderFinished OnTakeRecorderFinished) {}
	public void SetOnTakeRecorderCancelled(FOnTakeRecorderCancelled OnTakeRecorderCancelled) {}
	public void SetOnTakeRecorderMarkedFrameAdded(FOnTakeRecorderMarkedFrameAdded OnTakeRecorderMarkedFrameAdded) {}
}
