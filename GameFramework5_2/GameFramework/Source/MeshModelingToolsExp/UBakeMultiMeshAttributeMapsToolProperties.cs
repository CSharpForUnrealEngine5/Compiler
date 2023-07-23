#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMultiMeshAttributeMapsTool.h")]
public partial class UBakeMultiMeshAttributeMapsToolProperties : UInteractiveToolPropertySet {
// BakeMultiMeshAttributeMapsToolProperties
	public int MapTypes;
	public sbyte MapPreview;
	public EBakeTextureResolution Resolution;
	public EBakeTextureBitDepth BitDepth;
	public EBakeTextureSamplesPerPixel SamplesPerPixel;
	public UTexture2D SampleFilterMask;
	public TArray<sbyte> GetMapPreviewNamesFunc(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> MapPreviewNamesList;
}
