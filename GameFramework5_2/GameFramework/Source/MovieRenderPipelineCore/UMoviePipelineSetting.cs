#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineSetting.h")]
///<summary>A base class for all Movie Render Pipeline settings.</summary>
public partial class UMoviePipelineSetting : UObject {
// MoviePipelineSetting
	public void BuildNewProcessCommandLine(sbyte InOutUnrealURLParams,sbyte InOutCommandLineArgs) {}
	public void BuildNewProcessCommandLineArgs(TArray<sbyte> InOutUnrealURLParams,TArray<sbyte> InOutCommandLineArgs,TArray<sbyte> InOutDeviceProfileCvars,TArray<sbyte> InOutExecCmds) {}
	public bool IsEnabled(bool ReturnValue) { return default; }
	public void SetIsEnabled(bool bInEnabled) {}
	public TWeakObjectPtr<UMoviePipeline> CachedPipeline;
	public bool bEnabled;
}
