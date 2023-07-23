#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CineSplineComponent.h")]
public partial class UCineSplineComponent : USplineComponent {
// CineSplineComponent
	public FCineSplineCurveDefaults CameraSplineDefaults;
	public UCineSplineMetadata CineSplineMetadata;
	public void SetFocalLengthAtSplinePoint(int PointIndex,float Value) {}
	public void SetApertureAtSplinePoint(int PointIndex,float value) {}
	public void SetFocusDistanceAtSplinePoint(int PointIndex,float value) {}
	public void SetAbsolutePositionAtSplinePoint(int PointIndex,float value) {}
	public void SetPointRotationAtSplinePoint(int PointIndex,FQuat value) {}
	public bool FindSplineDataAtPosition(float InPosition,int OutIndex,float Tolerance=0.001f,bool ReturnValue) { return default; }
	public void UpdateSplineDataAtIndex(int InIndex,FCineSplinePointData InPointData) {}
	public void AddSplineDataAtPosition(float InPosition,FCineSplinePointData InPointData) {}
	public FCineSplinePointData GetSplineDataAtPosition(float InPosition,FCineSplinePointData ReturnValue) { return default; }
	public float GetInputKeyAtPosition(float InPosition,float ReturnValue) { return default; }
	public float GetPositionAtInputKey(float InKey,float ReturnValue) { return default; }
	public FQuat GetPointRotationAtSplinePoint(int Index,FQuat ReturnValue) { return default; }
	public FQuat GetPointRotationAtSplineInputKey(float InKey,FQuat ReturnValue) { return default; }
	public void FOnSplineEdited_BP() {}
	public FOnSplineEdited_BP OnSplineEdited_BP;
}
