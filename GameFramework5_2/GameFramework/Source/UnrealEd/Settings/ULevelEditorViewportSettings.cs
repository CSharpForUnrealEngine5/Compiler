#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/LevelEditorViewportSettings.h")]
///<summary>Implements the Level Editor's view port settings.</summary>
public partial class ULevelEditorViewportSettings : UObject {
// LevelEditorViewportSettings
	public byte FlightCameraControlType;
	public bool FlightCameraControlExperimentalNavigation;
	public ELandscapeFoliageEditorControlType LandscapeEditorControlType;
	public ELandscapeFoliageEditorControlType FoliageEditorControlType;
	public bool bPanMovesCanvas;
	public bool bCenterZoomAroundCursor;
	public float MinimumOrthographicZoom;
	public bool bAllowTranslateRotateZWidget;
	public bool bAllowArcballRotate;
	public bool bAllowScreenRotate;
	public bool bClickBSPSelectsBrush;
	public bool bShowActorEditorContext;
	public int CameraSpeed;
	public float CameraSpeedScalar;
	public int MouseScrollCameraSpeed;
	public float MouseSensitivty;
	public bool bInvertMouseLookYAxis;
	public bool bInvertOrbitYAxis;
	public bool bInvertMiddleMousePan;
	public bool bInvertRightMouseDollyYAxis;
	public bool bUseAbsoluteTranslation;
	public bool bLevelStreamingVolumePrevis;
	public bool bUseUE3OrbitControls;
	public EScrollGestureDirection ScrollGestureDirectionFor3DViewports;
	public EScrollGestureDirection ScrollGestureDirectionForOrthoViewports;
	public bool bLevelEditorJoystickControls;
	public bool bUseDistanceScaledCameraSpeed;
	public bool bOrbitCameraAroundSelection;
	public bool bUsePowerOf2SnapSize;
	public TArray<float> DecimalGridSizes;
	public TArray<float> DecimalGridIntervals;
	public TArray<float> Pow2GridSizes;
	public TArray<float> Pow2GridIntervals;
	public TArray<float> CommonRotGridSizes;
	public TArray<float> DivisionsOf360RotGridSizes;
	public TArray<float> ScalingGridSizes;
	public bool GridEnabled;
	public bool RotGridEnabled;
	public bool SnapScaleEnabled;
	public FSnapToSurfaceSettings SnapToSurface;
	public bool bUsePercentageBasedScaling;
	public bool bEnableLayerSnap;
	public int ActiveSnapLayerIndex;
	public bool bEnableActorSnap;
	public float ActorSnapScale;
	public float ActorSnapDistance;
	public bool bSnapVertices;
	public float SnapDistance;
	public int CurrentPosGridSize;
	public int CurrentRotGridSize;
	public int CurrentScalingGridSize;
	public bool PreserveNonUniformScale;
	public byte CurrentRotGridMode;
	public byte AspectRatioAxisConstraint;
	public bool bEnableViewportHoverFeedback;
	public bool bHighlightWithBrackets;
	public bool bUseLinkedOrthographicViewports;
	public bool bStrictBoxSelection;
	public bool bTransparentBoxSelection;
	public bool bUseSelectionOutline;
	public float SelectionHighlightIntensity;
	public float BSPSelectionHighlightIntensity;
	public bool bEnableViewportCameraToUpdateFromPIV;
	public bool bPreviewSelectedCameras;
	public float CameraPreviewSize;
	public float BackgroundDropDistance;
	public TArray<FSoftObjectPath> PreviewMeshes;
	public float BillboardScale;
	public int TransformWidgetSizeAdjustment;
	public bool bSaveEngineStats;
	public byte MeasuringToolUnits;
	public float SelectedSplinePointSizeAdjustment;
	public float SplineLineThicknessAdjustment;
	public float SplineTangentHandleSizeAdjustment;
	public float SplineTangentScale;
	public FVector2D LastInViewportMenuLocation;
	public TSoftObjectPtr<UMaterialInterface> MaterialForDroppedTextures;
	public TMap<EMaterialKind,string> MaterialParamsForDroppedTextures;
	public TArray<FLevelEditorViewportInstanceSettingsKeyValuePair> PerInstanceSettings;
}
