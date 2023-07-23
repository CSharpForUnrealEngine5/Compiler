#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CubeGridTool.h")]
public partial class UCubeGridToolProperties : UInteractiveToolPropertySet {
// CubeGridToolProperties
	public FVector GridFrameOrigin;
	public FRotator GridFrameOrientation;
	public bool bShowGizmo;
	public byte GridPower;
	public double CurrentBlockSize;
	public int BlocksPerStep;
	public bool bPowerOfTwoBlockSizes;
	public double BlockBaseSize;
	public bool bCrosswiseDiagonal;
	public bool bKeepSideGroups;
	public double PlaneTolerance;
	public bool bHitUnrelatedGeometry;
	public bool bHitGridGroundPlaneIfCloser;
	public ECubeGridToolFaceSelectionMode FaceSelectionMode;
	public sbyte ToggleCornerMode;
	public sbyte PushPull;
	public sbyte ResizeGrid;
	public sbyte SlideSelection;
	public sbyte FlipSelection;
	public sbyte GridGizmo;
	public sbyte QuickShiftGizmo;
	public sbyte AlignGizmo;
	public bool bInCornerMode;
	public bool bAllowedToEditGrid;
}
