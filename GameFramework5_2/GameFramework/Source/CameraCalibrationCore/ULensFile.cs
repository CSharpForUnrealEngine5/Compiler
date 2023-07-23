#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensFile.h")]
///<summary>A Lens file containing calibration mapping from FIZ data</summary>
public partial class ULensFile : UObject {
// LensFile
	public bool EvaluateDistortionParameters(float InFocus,float InZoom,FDistortionInfo OutEvaluatedValue,bool ReturnValue) { return default; }
	public bool EvaluateFocalLength(float InFocus,float InZoom,FFocalLengthInfo OutEvaluatedValue,bool ReturnValue) { return default; }
	public bool EvaluateImageCenterParameters(float InFocus,float InZoom,FImageCenterInfo OutEvaluatedValue,bool ReturnValue) { return default; }
	public bool EvaluateDistortionData(float InFocus,float InZoom,FVector2D InFilmback,UObject InLensHandler,bool ReturnValue) { return default; }
	public bool EvaluateNodalPointOffset(float InFocus,float InZoom,FNodalPointOffset OutEvaluatedValue,bool ReturnValue) { return default; }
	public bool HasFocusEncoderMapping(bool ReturnValue) { return default; }
	public float EvaluateNormalizedFocus(float InNormalizedValue,float ReturnValue) { return default; }
	public bool HasIrisEncoderMapping(bool ReturnValue) { return default; }
	public float EvaluateNormalizedIris(float InNormalizedValue,float ReturnValue) { return default; }
	public TArray<FDistortionPointInfo> GetDistortionPoints(TArray<FDistortionPointInfo> ReturnValue) { return default; }
	public TArray<FFocalLengthPointInfo> GetFocalLengthPoints(TArray<FFocalLengthPointInfo> ReturnValue) { return default; }
	public TArray<FSTMapPointInfo> GetSTMapPoints(TArray<FSTMapPointInfo> ReturnValue) { return default; }
	public TArray<FImageCenterPointInfo> GetImageCenterPoints(TArray<FImageCenterPointInfo> ReturnValue) { return default; }
	public TArray<FNodalOffsetPointInfo> GetNodalOffsetPoints(TArray<FNodalOffsetPointInfo> ReturnValue) { return default; }
	public bool GetDistortionPoint(float InFocus,float InZoom,FDistortionInfo OutDistortionInfo,bool ReturnValue) { return default; }
	public bool GetFocalLengthPoint(float InFocus,float InZoom,FFocalLengthInfo OutFocalLengthInfo,bool ReturnValue) { return default; }
	public bool GetImageCenterPoint(float InFocus,float InZoom,FImageCenterInfo OutImageCenterInfo,bool ReturnValue) { return default; }
	public bool GetNodalOffsetPoint(float InFocus,float InZoom,FNodalPointOffset OutNodalPointOffset,bool ReturnValue) { return default; }
	public bool GetSTMapPoint(float InFocus,float InZoom,FSTMapInfo OutSTMapInfo,bool ReturnValue) { return default; }
	public void AddDistortionPoint(float NewFocus,float NewZoom,FDistortionInfo NewPoint,FFocalLengthInfo NewFocalLength) {}
	public void AddFocalLengthPoint(float NewFocus,float NewZoom,FFocalLengthInfo NewFocalLength) {}
	public void AddImageCenterPoint(float NewFocus,float NewZoom,FImageCenterInfo NewPoint) {}
	public void AddNodalOffsetPoint(float NewFocus,float NewZoom,FNodalPointOffset NewPoint) {}
	public void AddSTMapPoint(float NewFocus,float NewZoom,FSTMapInfo NewPoint) {}
	public void RemoveFocusPoint(ELensDataCategory InDataCategory,float InFocus) {}
	public void RemoveZoomPoint(ELensDataCategory InDataCategory,float InFocus,float InZoom) {}
	public void ClearAll() {}
	public void ClearData(ELensDataCategory InDataCategory) {}
	public bool HasSamples(ELensDataCategory InDataCategory,bool ReturnValue) { return default; }
	public int GetTotalPointNum(ELensDataCategory InDataCategory,int ReturnValue) { return default; }
	public FLensInfo LensInfo;
	public FCameraFeedInfo CameraFeedInfo;
	public FSimulcamInfo SimulcamInfo;
	public ELensDataMode DataMode;
	public TMap<sbyte,sbyte> UserMetadata;
	public FEncodersTable EncodersTable;
	public FDistortionTable DistortionTable;
	public FFocalLengthTable FocalLengthTable;
	public FImageCenterTable ImageCenterTable;
	public FNodalOffsetTable NodalOffsetTable;
	public FSTMapTable STMapTable;
	public UAssetImportData AssetImportData;
	public TArray<UTextureRenderTarget2D> UndistortionDisplacementMapHolders;
	public TArray<UTextureRenderTarget2D> DistortionDisplacementMapHolders;
}
