#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeEditorObject.h")]
public partial class ULandscapeEditorObject : UObject {
// LandscapeEditorObject
	public float ToolStrength;
	public float PaintToolStrength;
	public bool bUseWeightTargetValue;
	public float WeightTargetValue;
	public float MaximumValueRadius;
	public bool bCombinedLayersOperation;
	public ELandscapeToolFlattenMode FlattenMode;
	public bool bUseSlopeFlatten;
	public bool bPickValuePerApply;
	public bool bUseFlattenTarget;
	public float FlattenTarget;
	public bool bShowFlattenTargetPreview;
	public float TerraceInterval;
	public float TerraceSmooth;
	public bool bFlattenEyeDropperModeActivated;
	public float FlattenEyeDropperModeDesiredTarget;
	public float RampWidth;
	public float RampSideFalloff;
	public int SmoothFilterKernelSize;
	public bool bDetailSmooth;
	public float DetailScale;
	public int ErodeThresh;
	public int ErodeSurfaceThickness;
	public int ErodeIterationNum;
	public ELandscapeToolErosionMode ErosionNoiseMode;
	public float ErosionNoiseScale;
	public int RainAmount;
	public float SedimentCapacity;
	public int HErodeIterationNum;
	public ELandscapeToolHydroErosionMode RainDistMode;
	public float RainDistScale;
	public bool bHErosionDetailSmooth;
	public float HErosionDetailScale;
	public ELandscapeToolNoiseMode NoiseMode;
	public float NoiseScale;
	public bool bUseSelectedRegion;
	public bool bUseNegativeMask;
	public ELandscapeToolPasteMode PasteMode;
	public bool bApplyToAllTargets;
	public ELandscapeGizmoSnapType SnapMode;
	public bool bSmoothGizmoBrush;
	public sbyte GizmoHeightmapFilenameString;
	public FIntPoint GizmoImportSize;
	public TArray<FGizmoImportLayer> GizmoImportLayers;
	public FVector2D MirrorPoint;
	public ELandscapeMirrorOperation MirrorOp;
	public int MirrorSmoothingWidth;
	public UClass BlueprintBrush;
	public int ResizeLandscape_QuadsPerSection;
	public int ResizeLandscape_SectionsPerComponent;
	public FIntPoint ResizeLandscape_ComponentCount;
	public ELandscapeConvertMode ResizeLandscape_ConvertMode;
	public TWeakObjectPtr<UMaterialInterface> NewLandscape_Material;
	public int NewLandscape_QuadsPerSection;
	public int NewLandscape_SectionsPerComponent;
	public FIntPoint NewLandscape_ComponentCount;
	public FVector NewLandscape_Location;
	public FRotator NewLandscape_Rotation;
	public FVector NewLandscape_Scale;
	public ELandscapeImportResult ImportLandscape_HeightmapImportResult;
	public sbyte ImportLandscape_HeightmapErrorMessage;
	public sbyte ImportLandscape_HeightmapFilename;
	public uint ImportLandscape_Width;
	public uint ImportLandscape_Height;
	public sbyte HeightmapExportFilename;
	public FIntPoint ImportLandscape_GizmoLocalPosition;
	public ELandscapeImportTransformType ImportType;
	public bool bHeightmapSelected;
	public bool bExportEditLayer;
	public bool bExportSingleFile;
	public FLandscapeImportDescriptor HeightmapImportDescriptor;
	public int HeightmapImportDescriptorIndex;
	public TArray<ushort> ImportLandscape_Data;
	public bool bCanHaveLayersContent;
	public bool bFlipYAxis;
	public uint WorldPartitionGridSize;
	public ELandscapeImportAlphamapType ImportLandscape_AlphamapType;
	public TArray<FLandscapeImportLayer> ImportLandscape_Layers;
	public float BrushRadius;
	public float PaintBrushRadius;
	public float BrushFalloff;
	public float PaintBrushFalloff;
	public bool bUseClayBrush;
	public float AlphaBrushScale;
	public bool bAlphaBrushAutoRotate;
	public float AlphaBrushRotation;
	public float AlphaBrushPanU;
	public float AlphaBrushPanV;
	public bool bUseWorldSpacePatternBrush;
	public FLandscapePatternBrushWorldSpaceSettings WorldSpacePatternBrushSettings;
	public UTexture2D AlphaTexture;
	public ELandscapeTextureColorChannel AlphaTextureChannel;
	public int AlphaTextureSizeX;
	public int AlphaTextureSizeY;
	public TArray<byte> AlphaTextureData;
	public int BrushComponentSize;
	public ELandscapeLayerPaintingRestriction PaintingRestriction;
	public ELandscapeLayerDisplayMode TargetDisplayOrder;
	public bool ShowUnusedLayers;
	public int CurrentLayerIndex;
}
