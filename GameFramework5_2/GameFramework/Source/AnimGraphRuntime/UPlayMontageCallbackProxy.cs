#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PlayMontageCallbackProxy.h")]
public partial class UPlayMontageCallbackProxy : UObject {
// PlayMontageCallbackProxy
	public FOnMontagePlayDelegate OnCompleted;
	public FOnMontagePlayDelegate OnBlendOut;
	public FOnMontagePlayDelegate OnInterrupted;
	public FOnMontagePlayDelegate OnNotifyBegin;
	public FOnMontagePlayDelegate OnNotifyEnd;
	public UObject CreateProxyObjectForPlayMontage(UObject InSkeletalMeshComponent,UObject MontageToPlay,float PlayRate=1.f,float StartingPosition=0.f,sbyte StartingSection=NAME_None,UObject ReturnValue) { return default; }
	public void OnMontageBlendingOut(UObject Montage,bool bInterrupted) {}
	public void OnMontageEnded(UObject Montage,bool bInterrupted) {}
	public void OnNotifyBeginReceived(sbyte NotifyName,FBranchingPointNotifyPayload BranchingPointNotifyPayload) {}
	public void OnNotifyEndReceived(sbyte NotifyName,FBranchingPointNotifyPayload BranchingPointNotifyPayload) {}
}
