#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetEditor/LensDistortionTool.h")]
///<summary>ULensDistortionTool is the controller for the lens distortion panel.</summary>
public partial class ULensDistortionTool : UCameraCalibrationStep {
// LensDistortionTool
	public UCameraLensDistortionAlgo CurrentAlgo;
	public TMap<sbyte,UClass> AlgosMap;
	public TMap<sbyte,UClass> SupportedAlgosMap;
	public TMap<sbyte,UMaterialInstanceDynamic> AlgoOverlayMIDs;
}
