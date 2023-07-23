#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTrackable.h")]
public partial class UARFaceGeometry : UARTrackedGeometry {
// ARFaceGeometry
	public float GetBlendShapeValue(EARFaceBlendShape BlendShape,float ReturnValue) { return default; }
	public TMap<EARFaceBlendShape,float> GetBlendShapes(TMap<EARFaceBlendShape,float> ReturnValue) { return default; }
	public FTransform GetLocalSpaceEyeTransform(EAREye Eye,FTransform ReturnValue) { return default; }
	public FTransform GetWorldSpaceEyeTransform(EAREye Eye,FTransform ReturnValue) { return default; }
	public FVector LookAtTarget;
	public bool bIsTracked;
	public TMap<EARFaceBlendShape,float> BlendShapes;
	public FTransform LeftEyeTransform;
	public FTransform RightEyeTransform;
}
