#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepOperation.h")]
///<summary>Base class for all Dataprep operations</summary>
public partial class UDataprepOperation : UDataprepParameterizableObject {
// DataprepOperation
	public void Execute(TArray<UObject> InObjects) {}
	public void OnExecution(FDataprepContext InContext) {}
	public void LogInfo(sbyte InLogText) {}
	public void LogWarning(sbyte InLogText) {}
	public void LogError(sbyte InLogError) {}
	public void BeginWork(sbyte InDescription,float InAmountOfWork) {}
	public void EndWork() {}
	public void ReportProgress(float IncrementOfWork,sbyte InMessage) {}
	public void AssetsModified(TArray<UObject> Assets) {}
	public sbyte GetDisplayOperationName(sbyte ReturnValue) { return default; }
	public sbyte GetTooltip(sbyte ReturnValue) { return default; }
	public sbyte GetCategory(sbyte ReturnValue) { return default; }
	public sbyte GetAdditionalKeyword(sbyte ReturnValue) { return default; }
}
