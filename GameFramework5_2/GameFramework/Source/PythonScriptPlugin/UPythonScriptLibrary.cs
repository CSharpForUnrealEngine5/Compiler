#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PythonScriptLibrary.h")]
public partial class UPythonScriptLibrary : UBlueprintFunctionLibrary {
// PythonScriptLibrary
	public bool IsPythonAvailable(bool ReturnValue) { return default; }
	public bool ExecutePythonCommand(sbyte PythonCommand,bool ReturnValue) { return default; }
	public bool ExecutePythonCommandEx(sbyte PythonCommand,sbyte CommandResult,TArray<FPythonLogOutputEntry> LogOutput,EPythonCommandExecutionMode ExecutionMode=EPythonCommandExecutionMode,EPythonFileExecutionScope FileExecutionScope=EPythonFileExecutionScope,bool ReturnValue) { return default; }
	public bool ExecutePythonScript(sbyte PythonScript,TArray<sbyte> PythonInputs,TArray<sbyte> PythonOutputs,bool ReturnValue) { return default; }
}
