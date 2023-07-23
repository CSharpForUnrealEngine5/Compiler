#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OpenCVLensCalibrator.h")]
public partial class UOpenCVLensCalibrator : UObject {
// OpenCVLensCalibrator
	public UObject CreateCalibrator(int BoardWidth=7,int BoardHeight=5,float SquareSize=3.f,bool bUseFisheyeModel=false,UObject ReturnValue) { return default; }
	public bool FeedRenderTarget(UObject TextureRenderTarget,bool ReturnValue) { return default; }
	public bool FeedImage(sbyte FilePath,bool ReturnValue) { return default; }
	public bool CalculateLensParameters(FOpenCVLensDistortionParameters LensDistortionParameters,float MarginOfError,FOpenCVCameraViewInfo CameraViewInfo,bool ReturnValue) { return default; }
	public FVector2D MinimumCornerCoordinates;
	public FVector2D MaximumCornerCoordinates;
}
