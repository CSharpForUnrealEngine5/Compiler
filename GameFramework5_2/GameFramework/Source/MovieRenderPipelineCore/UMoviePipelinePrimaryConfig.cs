#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelinePrimaryConfig.h")]
///<summary>This class describes the main configuration for a Movie Render Pipeline.</summary>
public partial class UMoviePipelinePrimaryConfig : UMoviePipelineConfigBase {
// MoviePipelinePrimaryConfig
	public void InitializeTransientSettings() {}
	public TArray<UObject> GetTransientSettings(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetAllSettings(bool bIncludeDisabledSettings=false,bool bIncludeTransientSettings=false,TArray<UObject> ReturnValue) { return default; }
	public FFrameRate GetEffectiveFrameRate(UObject InSequence,FFrameRate ReturnValue) { return default; }
	public TMap<sbyte,UMoviePipelineShotConfig> PerShotConfigMapping;
	public UMoviePipelineOutputSetting OutputSetting;
	public TArray<UMoviePipelineSetting> TransientSettings;
}
