#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMHost.h")]
///<summary>set this to something larger than 0 to profile N runs</summary>
public partial class URigVMHost : UObject {
// RigVMHost
	public TArray<UObject> FindRigVMHosts(UObject Outer,UClass OptionalClass,TArray<UObject> ReturnValue) { return default; }
	public float GetAbsoluteTime(float ReturnValue) { return default; }
	public float GetDeltaTime(float ReturnValue) { return default; }
	public void SetDeltaTime(float InDeltaTime) {}
	public void SetAbsoluteTime(float InAbsoluteTime,bool InSetDeltaTimeZero=false) {}
	public void SetAbsoluteAndDeltaTime(float InAbsoluteTime,float InDeltaTime) {}
	public void SetFramesPerSecond(float InFramesPerSecond) {}
	public float GetCurrentFramesPerSecond(float ReturnValue) { return default; }
	public bool CanExecute(bool ReturnValue) { return default; }
	public TArray<sbyte> GetScriptAccessibleVariables(TArray<sbyte> ReturnValue) { return default; }
	public sbyte GetVariableType(sbyte InVariableName,sbyte ReturnValue) { return default; }
	public sbyte GetVariableAsString(sbyte InVariableName,sbyte ReturnValue) { return default; }
	public bool SetVariableFromString(sbyte InVariableName,sbyte InValue,bool ReturnValue) { return default; }
	public FRigVMRuntimeSettings VMRuntimeSettings;
	public bool Execute(sbyte InEventName,bool ReturnValue) { return default; }
	public bool SupportsEvent(sbyte InEventName,bool ReturnValue) { return default; }
	public TArray<sbyte> GetSupportedEvents(TArray<sbyte> ReturnValue) { return default; }
	public bool ExecuteEvent(sbyte InEventName,bool ReturnValue) { return default; }
	public void RequestInit() {}
	public void RequestRunOnceEvent(sbyte InEventName,int InEventIndex=-1) {}
	public bool RemoveRunOnceEvent(sbyte InEventName,bool ReturnValue) { return default; }
	public UObject GetVM(UObject ReturnValue) { return default; }
	public URigVM VM;
	public FRigVMDrawContainer DrawContainer;
	public TArray<sbyte> EventQueue;
	public TArray<UAssetUserData> AssetUserData;
	public URigVM VMSnapshotBeforeExecution;
	public bool bIsInDebugMode;
}
