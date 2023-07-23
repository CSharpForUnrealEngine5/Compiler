#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineConfigBase.h")]
public partial class UMoviePipelineConfigBase : UObject {
// MoviePipelineConfigBase
	public void RemoveSetting(UObject InSetting) {}
	public void CopyFrom(UObject InConfig) {}
	public TArray<UObject> GetUserSettings(TArray<UObject> ReturnValue) { return default; }
	public UObject GetConfigOrigin(UObject ReturnValue) { return default; }
	public void SetConfigOrigin(UObject InConfig) {}
	public TArray<UObject> FindSettingsByClass(UClass InClass,bool bIncludeDisabledSettings=false,bool bExactMatch=false,TArray<UObject> ReturnValue) { return default; }
	public UObject FindSettingByClass(UClass InClass,bool bIncludeDisabledSettings=false,bool bExactMatch=false,UObject ReturnValue) { return default; }
	public UObject FindOrAddSettingByClass(UClass InClass,bool bIncludeDisabledSettings=false,bool bExactMatch=false,UObject ReturnValue) { return default; }
	public sbyte DisplayName;
	public TArray<UMoviePipelineSetting> Settings;
	public TSoftObjectPtr<UMoviePipelineConfigBase> ConfigOrigin;
}
