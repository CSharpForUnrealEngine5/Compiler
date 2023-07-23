#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaBundle.h")]
///<summary>A bundle of the Media Asset necessary to play a video & audio</summary>
public partial class UMediaBundle : UObject {
// MediaBundle
	public UObject GetMaterial(UObject ReturnValue) { return default; }
	public UObject GetMediaPlayer(UObject ReturnValue) { return default; }
	public UObject GetMediaTexture(UObject ReturnValue) { return default; }
	public UObject GetLensDisplacementTexture(UObject ReturnValue) { return default; }
	public UObject GetMediaSource(UObject ReturnValue) { return default; }
	public FOpenCVCameraViewInfo GetUndistortedCameraViewInfo(FOpenCVCameraViewInfo ReturnValue) { return default; }
	public UMediaSource MediaSource;
	public bool bLoopMediaSource;
	public bool bReopenSourceOnError;
	public UClass MediaBundleActorClass;
	public UMediaPlayer MediaPlayer;
	public UMediaTexture MediaTexture;
	public UMaterialInterface Material;
	public FOpenCVLensDistortionParameters LensParameters;
	public FOpenCVCameraViewInfo UndistortedCameraViewInfo;
	public FOpenCVLensDistortionParameters CurrentLensParameters;
	public UTextureRenderTarget2D LensDisplacementMap;
	public int ReferenceCount;
	public UMaterial DefaultMaterial;
	public UTexture DefaultFailedTexture;
	public UClass DefaultActorClass;
	public void OnMediaClosed() {}
	public void OnMediaOpenOpened(sbyte DeviceUrl) {}
	public void OnMediaOpenFailed(sbyte DeviceUrl) {}
}
