#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicalAnimationComponent.h")]
public partial class UPhysicalAnimationComponent : UActorComponent {
// PhysicalAnimationComponent
	public void SetSkeletalMeshComponent(UObject InSkeletalMeshComponent) {}
	public void ApplyPhysicalAnimationSettings(sbyte BodyName,FPhysicalAnimationData PhysicalAnimationData) {}
	public void ApplyPhysicalAnimationSettingsBelow(sbyte BodyName,FPhysicalAnimationData PhysicalAnimationData,bool bIncludeSelf=true) {}
	public void SetStrengthMultiplyer(float InStrengthMultiplyer) {}
	public float StrengthMultiplyer;
	public void ApplyPhysicalAnimationProfileBelow(sbyte BodyName,sbyte ProfileName,bool bIncludeSelf=true,bool bClearNotFound=false) {}
	public FTransform GetBodyTargetTransform(sbyte BodyName,FTransform ReturnValue) { return default; }
	public USkeletalMeshComponent SkeletalMeshComponent;
}
