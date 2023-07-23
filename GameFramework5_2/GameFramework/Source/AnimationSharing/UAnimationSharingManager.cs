#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingManager.h")]
public partial class UAnimationSharingManager : UObject {
// AnimationSharingManager
	public UObject GetAnimationSharingManager(UObject WorldContextObject,UObject ReturnValue) { return default; }
	public bool CreateAnimationSharingManager(UObject WorldContextObject,UObject Setup,bool ReturnValue) { return default; }
	public void RegisterActorWithSkeletonBP(UObject InActor,UObject SharingSkeleton) {}
	public bool AnimationSharingEnabled(bool ReturnValue) { return default; }
	public TArray<USkeleton> Skeletons;
	public TArray<UAnimSharingInstance> PerSkeletonData;
}
