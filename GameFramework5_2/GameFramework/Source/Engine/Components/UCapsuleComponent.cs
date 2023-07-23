#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/CapsuleComponent.h")]
///<summary>A capsule generally used for simple collision. Bounds are rendered as lines in the editor.</summary>
public partial class UCapsuleComponent : UShapeComponent {
// CapsuleComponent
	public float CapsuleHalfHeight;
	public float CapsuleRadius;
	public float CapsuleHeight_DEPRECATED;
	public void SetCapsuleSize(float InRadius,float InHalfHeight,bool bUpdateOverlaps=true) {}
	public void SetCapsuleRadius(float Radius,bool bUpdateOverlaps=true) {}
	public void SetCapsuleHalfHeight(float HalfHeight,bool bUpdateOverlaps=true) {}
	public float GetScaledCapsuleRadius(float ReturnValue) { return default; }
	public float GetScaledCapsuleHalfHeight(float ReturnValue) { return default; }
	public float GetScaledCapsuleHalfHeight_WithoutHemisphere(float ReturnValue) { return default; }
	public void GetScaledCapsuleSize(float OutRadius,float OutHalfHeight) {}
	public void GetScaledCapsuleSize_WithoutHemisphere(float OutRadius,float OutHalfHeightWithoutHemisphere) {}
	public float GetUnscaledCapsuleRadius(float ReturnValue) { return default; }
	public float GetUnscaledCapsuleHalfHeight(float ReturnValue) { return default; }
	public float GetUnscaledCapsuleHalfHeight_WithoutHemisphere(float ReturnValue) { return default; }
	public void GetUnscaledCapsuleSize(float OutRadius,float OutHalfHeight) {}
	public void GetUnscaledCapsuleSize_WithoutHemisphere(float OutRadius,float OutHalfHeightWithoutHemisphere) {}
	public float GetShapeScale(float ReturnValue) { return default; }
}
