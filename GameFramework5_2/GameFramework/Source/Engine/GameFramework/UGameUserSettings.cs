#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/GameUserSettings.h")]
///<summary>Stores user settings for a game (for example graphics and sound settings), with the ability to save and load to and from a file.</summary>
public partial class UGameUserSettings : UObject {
// GameUserSettings
	public void ApplySettings(bool bCheckForCommandLineOverrides) {}
	public void ApplyNonResolutionSettings() {}
	public void ApplyResolutionSettings(bool bCheckForCommandLineOverrides) {}
	public FIntPoint GetScreenResolution(FIntPoint ReturnValue) { return default; }
	public FIntPoint GetLastConfirmedScreenResolution(FIntPoint ReturnValue) { return default; }
	public FIntPoint GetDesktopResolution(FIntPoint ReturnValue) { return default; }
	public void SetScreenResolution(FIntPoint Resolution) {}
	public EWindowMode GetFullscreenMode(EWindowMode ReturnValue) { return default; }
	public EWindowMode GetLastConfirmedFullscreenMode(EWindowMode ReturnValue) { return default; }
	public void SetFullscreenMode(EWindowMode InFullscreenMode) {}
	public EWindowMode GetPreferredFullscreenMode(EWindowMode ReturnValue) { return default; }
	public void SetVSyncEnabled(bool bEnable) {}
	public bool IsVSyncEnabled(bool ReturnValue) { return default; }
	public void SetDynamicResolutionEnabled(bool bEnable) {}
	public bool IsDynamicResolutionEnabled(bool ReturnValue) { return default; }
	public bool IsScreenResolutionDirty(bool ReturnValue) { return default; }
	public bool IsFullscreenModeDirty(bool ReturnValue) { return default; }
	public bool IsVSyncDirty(bool ReturnValue) { return default; }
	public bool IsDynamicResolutionDirty(bool ReturnValue) { return default; }
	public void ConfirmVideoMode() {}
	public void RevertVideoMode() {}
	public void SetBenchmarkFallbackValues() {}
	public void SetAudioQualityLevel(int QualityLevel) {}
	public int GetAudioQualityLevel(int ReturnValue) { return default; }
	public void SetFrameRateLimit(float NewLimit) {}
	public float GetFrameRateLimit(float ReturnValue) { return default; }
	public void SetOverallScalabilityLevel(int Value) {}
	public int GetOverallScalabilityLevel(int ReturnValue) { return default; }
	public void GetResolutionScaleInformation(float CurrentScaleNormalized,int CurrentScaleValue,int MinScaleValue,int MaxScaleValue) {}
	public void GetResolutionScaleInformationEx(float CurrentScaleNormalized,float CurrentScaleValue,float MinScaleValue,float MaxScaleValue) {}
	public float GetResolutionScaleNormalized(float ReturnValue) { return default; }
	public void SetResolutionScaleValue(int NewScaleValue) {}
	public void SetResolutionScaleValueEx(float NewScaleValue) {}
	public void SetResolutionScaleNormalized(float NewScaleNormalized) {}
	public void SetViewDistanceQuality(int Value) {}
	public int GetViewDistanceQuality(int ReturnValue) { return default; }
	public void SetShadowQuality(int Value) {}
	public int GetShadowQuality(int ReturnValue) { return default; }
	public void SetGlobalIlluminationQuality(int Value) {}
	public int GetGlobalIlluminationQuality(int ReturnValue) { return default; }
	public void SetReflectionQuality(int Value) {}
	public int GetReflectionQuality(int ReturnValue) { return default; }
	public void SetAntiAliasingQuality(int Value) {}
	public int GetAntiAliasingQuality(int ReturnValue) { return default; }
	public void SetTextureQuality(int Value) {}
	public int GetTextureQuality(int ReturnValue) { return default; }
	public void SetVisualEffectQuality(int Value) {}
	public int GetVisualEffectQuality(int ReturnValue) { return default; }
	public void SetPostProcessingQuality(int Value) {}
	public int GetPostProcessingQuality(int ReturnValue) { return default; }
	public void SetFoliageQuality(int Value) {}
	public int GetFoliageQuality(int ReturnValue) { return default; }
	public void SetShadingQuality(int Value) {}
	public int GetShadingQuality(int ReturnValue) { return default; }
	public bool IsDirty(bool ReturnValue) { return default; }
	public void ValidateSettings() {}
	public void LoadSettings(bool bForceReload=false) {}
	public void SaveSettings() {}
	public void ResetToCurrentSettings() {}
	public void SetToDefaults() {}
	public float GetDefaultResolutionScale(float ReturnValue) { return default; }
	public float GetRecommendedResolutionScale(float ReturnValue) { return default; }
	public FIntPoint GetDefaultResolution(FIntPoint ReturnValue) { return default; }
	public FIntPoint GetDefaultWindowPosition(FIntPoint ReturnValue) { return default; }
	public EWindowMode GetDefaultWindowMode(EWindowMode ReturnValue) { return default; }
	public int GetSyncInterval(int ReturnValue) { return default; }
	public int GetFramePace(int ReturnValue) { return default; }
	public UObject GetGameUserSettings(UObject ReturnValue) { return default; }
	public void RunHardwareBenchmark(int WorkScale=10,float CPUMultiplier=1.0f,float GPUMultiplier=1.0f) {}
	public void ApplyHardwareBenchmarkResults() {}
	public bool SupportsHDRDisplayOutput(bool ReturnValue) { return default; }
	public void EnableHDRDisplayOutput(bool bEnable,int DisplayNits=1000) {}
	public int GetCurrentHDRDisplayNits(int ReturnValue) { return default; }
	public bool IsHDREnabled(bool ReturnValue) { return default; }
	public bool bUseVSync;
	public bool bUseDynamicResolution;
	public uint ResolutionSizeX;
	public uint ResolutionSizeY;
	public uint LastUserConfirmedResolutionSizeX;
	public uint LastUserConfirmedResolutionSizeY;
	public int WindowPosX;
	public int WindowPosY;
	public int FullscreenMode;
	public int LastConfirmedFullscreenMode;
	public int PreferredFullscreenMode;
	public uint Version;
	public int AudioQualityLevel;
	public int LastConfirmedAudioQualityLevel;
	public float FrameRateLimit;
	public int DesiredScreenWidth;
	public bool bUseDesiredScreenHeight;
	public int DesiredScreenHeight;
	public int LastUserConfirmedDesiredScreenWidth;
	public int LastUserConfirmedDesiredScreenHeight;
	public float LastRecommendedScreenWidth;
	public float LastRecommendedScreenHeight;
	public float LastCPUBenchmarkResult;
	public float LastGPUBenchmarkResult;
	public TArray<float> LastCPUBenchmarkSteps;
	public TArray<float> LastGPUBenchmarkSteps;
	public float LastGPUBenchmarkMultiplier;
	public bool bUseHDRDisplayOutput;
	public int HDRDisplayOutputNits;
	public FOnGameUserSettingsUINeedsUpdate OnGameUserSettingsUINeedsUpdate;
}
