#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionWarpingComponent.h")]
public partial class UMotionWarpingComponent : UActorComponent {
// MotionWarpingComponent
	public bool bSearchForWindowsInAnimsWithinMontages;
	public FMotionWarpingPreUpdate OnPreUpdate;
	public void DisableAllRootMotionModifiers() {}
	public void AddOrUpdateWarpTarget(FMotionWarpingTarget WarpTarget) {}
	public void AddOrUpdateWarpTargetFromTransform(sbyte WarpTargetName,FTransform TargetTransform) {}
	public void AddOrUpdateWarpTargetFromComponent(sbyte WarpTargetName,UObject Component,sbyte BoneName,bool bFollowComponent) {}
	public void AddOrUpdateWarpTargetFromLocation(sbyte WarpTargetName,FVector TargetLocation) {}
	public void AddOrUpdateWarpTargetFromLocationAndRotation(sbyte WarpTargetName,FVector TargetLocation,FRotator TargetRotation) {}
	public int RemoveWarpTarget(sbyte WarpTargetName,int ReturnValue) { return default; }
	public TWeakObjectPtr<ACharacter> CharacterOwner;
	public TArray<URootMotionModifier> Modifiers;
	public TArray<FMotionWarpingTarget> WarpTargets;
}
