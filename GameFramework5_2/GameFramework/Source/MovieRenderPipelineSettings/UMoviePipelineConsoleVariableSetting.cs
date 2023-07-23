#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineConsoleVariableSetting.h")]
public partial class UMoviePipelineConsoleVariableSetting : UMoviePipelineSetting {
// MoviePipelineConsoleVariableSetting
	public TArray<object /*ConsoleVariablePresets*/> ConsoleVariablePresets;
	public TMap<sbyte,float> ConsoleVariables_DEPRECATED;
	public TArray<sbyte> StartConsoleCommands;
	public TArray<sbyte> EndConsoleCommands;
	public TArray<FMoviePipelineConsoleVariableEntry> GetConsoleVariables(TArray<FMoviePipelineConsoleVariableEntry> ReturnValue) { return default; }
	public bool RemoveConsoleVariable(sbyte Name,bool bRemoveAllInstances=false,bool ReturnValue) { return default; }
	public bool AddOrUpdateConsoleVariable(sbyte Name,float Value,bool ReturnValue) { return default; }
	public bool AddConsoleVariable(sbyte Name,float Value,bool ReturnValue) { return default; }
	public bool UpdateConsoleVariableEnableState(sbyte Name,bool bIsEnabled,bool ReturnValue) { return default; }
	public TArray<FMoviePipelineConsoleVariableEntry> CVars;
}
