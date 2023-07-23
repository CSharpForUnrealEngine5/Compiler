#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CameraCalibrationSubsystem.h")]
///<summary>Camera Calibration subsystem</summary>
public partial class UCameraCalibrationSubsystem : UEngineSubsystem {
// CameraCalibrationSubsystem
	public UObject GetDefaultLensFile(UObject ReturnValue) { return default; }
	public void SetDefaultLensFile(UObject NewDefaultLensFile) {}
	public UObject GetLensFile(FLensFilePicker Picker,UObject ReturnValue) { return default; }
	public TArray<UObject> GetDistortionModelHandlers(UObject Component,TArray<UObject> ReturnValue) { return default; }
	public UObject FindDistortionModelHandler(FDistortionHandlerPicker DistortionHandlerPicker,bool bUpdatePicker=true,UObject ReturnValue) { return default; }
	public UObject FindOrCreateDistortionModelHandler(FDistortionHandlerPicker DistortionHandlerPicker,UClass LensModelClass,UObject ReturnValue) { return default; }
	public void UnregisterDistortionModelHandler(UObject Component,UObject Handler) {}
	public UClass GetRegisteredLensModel(sbyte ModelName,UClass ReturnValue) { return default; }
	public UClass GetCameraNodalOffsetAlgo(sbyte Name,UClass ReturnValue) { return default; }
	public TArray<sbyte> GetCameraNodalOffsetAlgos(TArray<sbyte> ReturnValue) { return default; }
	public UClass GetCameraImageCenterAlgo(sbyte Name,UClass ReturnValue) { return default; }
	public TArray<sbyte> GetCameraImageCenterAlgos(TArray<sbyte> ReturnValue) { return default; }
	public UObject GetOverlayMaterial(sbyte OverlayName,UObject ReturnValue) { return default; }
	public TArray<sbyte> GetOverlayMaterialNames(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetCameraCalibrationSteps(TArray<sbyte> ReturnValue) { return default; }
	public UClass GetCameraCalibrationStep(sbyte Name,UClass ReturnValue) { return default; }
	public ULensFile DefaultLensFile;
	public TMap<sbyte,UClass> LensModelMap;
	public TMap<sbyte,UClass> CameraNodalOffsetAlgosMap;
	public TMap<sbyte,UClass> CameraImageCenterAlgosMap;
	public TMap<sbyte,UClass> CameraCalibrationStepsMap;
}
