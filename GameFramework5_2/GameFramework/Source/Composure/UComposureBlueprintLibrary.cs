#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComposureBlueprintLibrary.h")]
public partial class UComposureBlueprintLibrary : UBlueprintFunctionLibrary {
// ComposureBlueprintLibrary
	public UObject CreatePlayerCompositingTarget(UObject WorldContextObject,UObject ReturnValue) { return default; }
	public void GetProjectionMatrixFromPostMoveSettings(FComposurePostMoveSettings PostMoveSettings,float HorizontalFOVAngle,float AspectRatio,FMatrix ProjectionMatrix) {}
	public void GetCroppingUVTransformationMatrixFromPostMoveSettings(FComposurePostMoveSettings PostMoveSettings,float AspectRatio,FMatrix CropingUVTransformationMatrix,FMatrix UncropingUVTransformationMatrix) {}
	public void SetUVMapSettingsToMaterialParameters(FComposureUVMapSettings UVMapSettings,UObject Material) {}
	public void InvertUVDisplacementMapEncodingParameters(FVector2D In,FVector2D Out) {}
	public void GetRedGreenUVFactorsFromChromaticAberration(float ChromaticAberrationAmount,FVector2D RedGreenUVFactors) {}
	public void GetPlayerDisplayGamma(UObject PlayerCameraManager,float DisplayGamma) {}
	public void CopyCameraSettingsToSceneCapture(UObject SrcCamera,UObject DstCaptureComponent,float OriginalFocalLength,float OverscanFactor=1.0f) {}
	public UObject CreateComposureElement(sbyte ElementName,UClass ClassType,UObject LevelContext=nullptr,UObject ReturnValue) { return default; }
	public UObject GetComposureElement(sbyte ElementName,UObject ReturnValue) { return default; }
	public void DeleteComposureElementAndChildren(sbyte ElementToDelete) {}
	public bool RenameComposureElement(sbyte OriginalElementName,sbyte NewElementName,bool ReturnValue) { return default; }
	public bool AttachComposureElement(sbyte ParentName,sbyte ChildName,bool ReturnValue) { return default; }
	public bool IsComposureElementDrawing(UObject CompElement,bool ReturnValue) { return default; }
	public void RequestRedrawComposureViewport() {}
	public void RefreshComposureElementList() {}
}
