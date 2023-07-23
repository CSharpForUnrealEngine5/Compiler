#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorDataprepAssetLibrary.h")]
///<summary>Utility class to do most expose most of the common functionalities of the dataprep editor plugin (Visual Dataprep).</summary>
public partial class UEditorDataprepAssetLibrary : UBlueprintFunctionLibrary {
// EditorDataprepAssetLibrary
	public bool ExecuteDataprep(UObject DataprepAssetInterface,EDataprepReportMethod LogReportingMethod,EDataprepReportMethod ProgressReportingMethod,bool ReturnValue) { return default; }
	public int GetProducersCount(UObject DataprepAssetInterface,int ReturnValue) { return default; }
	public UObject GetProducer(UObject DataprepAssetInterface,int Index,UObject ReturnValue) { return default; }
	public void RemoveProducer(UObject DataprepAssetInterface,int Index) {}
	public UObject AddProducer(UObject DataprepAssetInterface,UClass ProducerClass,UObject ReturnValue) { return default; }
	public UObject AddProducerAutomated(UObject DataprepAssetInterface,UClass ProducerClass,UObject ReturnValue) { return default; }
	public int GetActionCount(UObject DataprepAsset,int ReturnValue) { return default; }
	public void RemoveAction(UObject DataprepAsset,int Index) {}
	public UObject AddAction(UObject DataprepAsset,UObject ReturnValue) { return default; }
	public UObject AddActionByDuplication(UObject DataprepAsset,UObject ActionToDuplicate,UObject ReturnValue) { return default; }
	public void SwapActions(UObject DataprepAsset,int FirstActionIndex,int SecondActionIndex) {}
	public UObject GetAction(UObject DataprepAsset,int Index,UObject ReturnValue) { return default; }
	public UObject GetConsumer(UObject DataprepAssetInterface,UObject ReturnValue) { return default; }
	public int GetStepsCount(UObject DataprepAction,int ReturnValue) { return default; }
	public UObject AddStep(UObject DataprepAction,UClass StepType,UObject ReturnValue) { return default; }
	public UObject AddStepByDuplication(UObject DataprepAction,UObject StepObject,UObject ReturnValue) { return default; }
	public void RemoveStep(UObject DataprepAction,int Index) {}
	public void MoveStep(UObject DataprepAction,int StepIndex,int DestinationIndex) {}
	public void SwapSteps(UObject DataprepAction,int FirstIndex,int SecondIndex) {}
	public UObject GetStepObject(UObject DataprepAction,int Index,UObject ReturnValue) { return default; }
}
