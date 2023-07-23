#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeRenderCaptureTool.h")]
public partial class UBakeRenderCaptureToolProperties : UInteractiveToolPropertySet {
// BakeRenderCaptureToolProperties
	public sbyte MapPreview;
	public TArray<sbyte> GetMapPreviewNamesFunc(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> MapPreviewNamesList;
	public EBakeTextureSamplesPerPixel SamplesPerPixel;
	public EBakeTextureResolution TextureSize;
	public float ValidSampleDepthThreshold;
}
