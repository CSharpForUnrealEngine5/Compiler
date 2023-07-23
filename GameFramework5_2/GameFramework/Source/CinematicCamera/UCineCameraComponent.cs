#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CineCameraComponent.h")]
///<summary>A specialized version of a camera component, geared toward cinematic usage.</summary>
public partial class UCineCameraComponent : UCameraComponent {
// CineCameraComponent
	public FCameraFilmbackSettings FilmbackSettings_DEPRECATED;
	public FCameraFilmbackSettings Filmback;
	public void SetFilmback(FCameraFilmbackSettings NewFilmback) {}
	public FCameraLensSettings LensSettings;
	public void SetLensSettings(FCameraLensSettings NewLensSettings) {}
	public FCameraFocusSettings FocusSettings;
	public void SetFocusSettings(FCameraFocusSettings NewFocusSettings) {}
	public FPlateCropSettings CropSettings;
	public void SetCropSettings(FPlateCropSettings NewCropSettings) {}
	public float CurrentFocalLength;
	public float CurrentAperture;
	public void SetCurrentAperture(float NewCurrentAperture) {}
	public float CurrentFocusDistance;
	public bool bOverride_CustomNearClippingPlane;
	public float CustomNearClippingPlane;
	public float CurrentHorizontalFOV;
	public void SetCurrentFocalLength(float InFocalLength) {}
	public void SetCustomNearClippingPlane(float NewCustomNearClippingPlane) {}
	public float GetHorizontalFieldOfView(float ReturnValue) { return default; }
	public float GetVerticalFieldOfView(float ReturnValue) { return default; }
	public sbyte GetFilmbackPresetName(sbyte ReturnValue) { return default; }
	public sbyte GetDefaultFilmbackPresetName(sbyte ReturnValue) { return default; }
	public void SetFilmbackPresetByName(sbyte InPresetName) {}
	public sbyte GetLensPresetName(sbyte ReturnValue) { return default; }
	public void SetLensPresetByName(sbyte InPresetName) {}
	public sbyte GetCropPresetName(sbyte ReturnValue) { return default; }
	public void SetCropPresetByName(sbyte InPresetName) {}
	public TArray<FNamedFilmbackPreset> GetFilmbackPresetsCopy(TArray<FNamedFilmbackPreset> ReturnValue) { return default; }
	public TArray<FNamedLensPreset> GetLensPresetsCopy(TArray<FNamedLensPreset> ReturnValue) { return default; }
	public UStaticMesh FocusPlaneVisualizationMesh;
	public UMaterial FocusPlaneVisualizationMaterial;
	public UStaticMeshComponent DebugFocusPlaneComponent;
	public UMaterialInstanceDynamic DebugFocusPlaneMID;
	public TArray<FNamedFilmbackPreset> FilmbackPresets;
	public TArray<FNamedLensPreset> LensPresets;
	public sbyte DefaultFilmbackPresetName_DEPRECATED;
	public sbyte DefaultFilmbackPreset;
	public sbyte DefaultLensPresetName;
	public float DefaultLensFocalLength;
	public float DefaultLensFStop;
}
