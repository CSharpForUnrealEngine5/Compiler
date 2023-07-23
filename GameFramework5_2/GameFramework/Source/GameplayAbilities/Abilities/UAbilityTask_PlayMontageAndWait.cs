#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_PlayMontageAndWait.h")]
///<summary>Ability task to simply play a montage. Many games will want to make a modified version of this task that looks for game-specific events</summary>
public partial class UAbilityTask_PlayMontageAndWait : UAbilityTask {
// AbilityTask_PlayMontageAndWait
	public FMontageWaitSimpleDelegate OnCompleted;
	public FMontageWaitSimpleDelegate OnBlendOut;
	public FMontageWaitSimpleDelegate OnInterrupted;
	public FMontageWaitSimpleDelegate OnCancelled;
	public void OnMontageBlendingOut(UObject Montage,bool bInterrupted) {}
	public void OnMontageInterrupted() {}
	public void OnMontageEnded(UObject Montage,bool bInterrupted) {}
	public UObject CreatePlayMontageAndWaitProxy(UObject OwningAbility,sbyte TaskInstanceName,UObject MontageToPlay,float Rate=1.f,sbyte StartSection=NAME_None,bool bStopWhenAbilityEnds=true,float AnimRootMotionTranslationScale=1.f,float StartTimeSeconds=0.f,UObject ReturnValue) { return default; }
	public UAnimMontage MontageToPlay;
	public float Rate;
	public sbyte StartSection;
	public float AnimRootMotionTranslationScale;
	public float StartTimeSeconds;
	public bool bStopWhenAbilityEnds;
}
