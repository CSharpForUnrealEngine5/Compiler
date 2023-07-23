#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CineCameraSettings.h")]
public partial class UCineCameraSettings : UDeveloperSettings {
// CineCameraSettings
	public sbyte DefaultLensPresetName;
	public float DefaultLensFocalLength;
	public float DefaultLensFStop;
	public TArray<FNamedLensPreset> LensPresets;
	public sbyte DefaultFilmbackPreset;
	public TArray<FNamedFilmbackPreset> FilmbackPresets;
	public sbyte DefaultCropPresetName;
	public TArray<FNamedPlateCropPreset> CropPresets;
	public bool GetLensPresetByName(sbyte PresetName,FCameraLensSettings LensSettings,bool ReturnValue) { return default; }
	public bool GetFilmbackPresetByName(sbyte PresetName,FCameraFilmbackSettings FilmbackSettings,bool ReturnValue) { return default; }
	public bool GetCropPresetByName(sbyte PresetName,FPlateCropSettings CropSettings,bool ReturnValue) { return default; }
	public UObject GetCineCameraSettings(UObject ReturnValue) { return default; }
	public void SetDefaultLensPresetName(sbyte InDefaultLensPresetName) {}
	public void SetDefaultLensFocalLength(float InDefaultLensFocalLength) {}
	public void SetDefaultLensFStop(float InDefaultLensFStop) {}
	public void SetLensPresets(TArray<FNamedLensPreset> InLensPresets) {}
	public void SetDefaultFilmbackPreset(sbyte InDefaultFilmbackPreset) {}
	public void SetFilmbackPresets(TArray<FNamedFilmbackPreset> InFilmbackPresets) {}
	public void SetDefaultCropPresetName(sbyte InDefaultCropPresetName) {}
	public void SetCropPresets(TArray<FNamedPlateCropPreset> InCropPresets) {}
	public TArray<sbyte> GetLensPresetNames(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetFilmbackPresetNames(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetCropPresetNames(TArray<sbyte> ReturnValue) { return default; }
}
