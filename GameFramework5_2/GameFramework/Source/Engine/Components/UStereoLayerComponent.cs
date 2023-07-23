#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/StereoLayerComponent.h")]
///<summary>A geometry layer within the stereo rendered viewport.</summary>
public partial class UStereoLayerComponent : USceneComponent {
// StereoLayerComponent
	public void SetTexture(UObject InTexture) {}
	public void SetLeftTexture(UObject InTexture) {}
	public UObject GetTexture(UObject ReturnValue) { return default; }
	public UObject GetLeftTexture(UObject ReturnValue) { return default; }
	public void SetQuadSize(FVector2D InQuadSize) {}
	public FVector2D GetQuadSize(FVector2D ReturnValue) { return default; }
	public void SetUVRect(FBox2D InUVRect) {}
	public FBox2D GetUVRect(FBox2D ReturnValue) { return default; }
	public void SetEquirectProps(FEquirectProps InScaleBiases) {}
	public void SetPriority(int InPriority) {}
	public int GetPriority(int ReturnValue) { return default; }
	public void MarkTextureForUpdate() {}
	public bool bLiveTexture;
	public bool bSupportsDepth;
	public bool bNoAlphaChannel;
	public UTexture Texture;
	public UTexture LeftTexture;
	public bool bQuadPreserveTextureRatio;
	public FVector2D QuadSize;
	public FBox2D UVRect;
	public float CylinderRadius_DEPRECATED;
	public float CylinderOverlayArc_DEPRECATED;
	public int CylinderHeight_DEPRECATED;
	public FEquirectProps EquirectProps_DEPRECATED;
	public byte StereoLayerType;
	public byte StereoLayerShape_DEPRECATED;
	public UStereoLayerShape Shape;
	public int Priority;
}
