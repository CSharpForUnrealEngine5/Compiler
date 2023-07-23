#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SteamVRInputDeviceFunctionLibrary.h")]
///<summary>* SteamVR Input Extended Functions</summary>
public partial class UDEPRECATED_USteamVRInputDeviceFunctionLibrary : UBlueprintFunctionLibrary {
// USteamVRInputDeviceFunctionLibrary
	public void GetFingerCurlsAndSplays(EHand Hand,FSteamVRFingerCurls FingerCurls,FSteamVRFingerSplays FingerSplays,ESkeletalSummaryDataType SummaryDataType=ESkeletalSummaryDataType) {}
	public void PlaySteamVR_HapticFeedback(ESteamVRHand Hand,float StartSecondsFromNow,float DurationSeconds=1.f,float Frequency=1.f,float Amplitude=0.5f) {}
	public void GetCurlsAndSplaysState(bool LeftHandState,bool RightHandState) {}
	public void GetSkeletalState(bool LeftHandState,bool RightHandState) {}
	public void GetControllerFidelity(EControllerFidelity LeftControllerFidelity,EControllerFidelity RightControllerFidelity) {}
	public void SetCurlsAndSplaysState(bool NewLeftHandState,bool NewRightHandState) {}
	public void GetPoseSource(bool bUsingSkeletonPose) {}
	public void SetPoseSource(bool bUseSkeletonPose) {}
	public void GetSkeletalTransform(FSteamVRSkeletonTransform LeftHand,FSteamVRSkeletonTransform RightHand,bool bWithController=false) {}
	public void GetLeftHandPoseData(FVector Position,FRotator Orientation,FVector AngularVelocity,FVector Velocity) {}
	public void GetRightHandPoseData(FVector Position,FRotator Orientation,FVector AngularVelocity,FVector Velocity) {}
	public void GetSteamVR_ActionArray(TArray<FSteamVRAction> SteamVRActions) {}
	public void FindSteamVR_Action(sbyte ActionName,bool bResult,FSteamVRAction FoundAction,FSteamVRActionSet FoundActionSet,sbyte ActionSet=FName) {}
	public void GetSteamVR_ActionSetArray(TArray<FSteamVRActionSet> SteamVRActionSets) {}
	public bool GetSteamVR_OriginTrackedDeviceInfo(FSteamVRAction SteamVRAction,FSteamVRInputOriginInfo InputOriginInfo,bool ReturnValue) { return default; }
	public void FindSteamVR_OriginTrackedDeviceInfo(sbyte ActionName,bool bResult,FSteamVRInputOriginInfo InputOriginInfo,sbyte ActionSet=FName) {}
	public void GetSteamVR_OriginLocalizedName(FSteamVRAction SteamVRAction,TArray<ESteamVRInputStringBits> LocalizedParts,sbyte OriginLocalizedName) {}
	public void ShowSteamVR_ActionOrigin(FSteamVRAction SteamVRAction,FSteamVRActionSet SteamVRActionSet) {}
	public bool FindSteamVR_ActionOrigin(sbyte ActionName,sbyte ActionSet=FName,bool ReturnValue) { return default; }
	public bool GetSteamVR_HandPoseRelativeToNow(FVector Position,FRotator Orientation,ESteamVRHand Hand=ESteamVRHand,float PredictedSecondsFromNow=0.f,bool ReturnValue) { return default; }
	public float GetSteamVR_GlobalPredictedSecondsFromNow(float ReturnValue) { return default; }
	public float SetSteamVR_GlobalPredictedSecondsFromNow(float NewValue,float ReturnValue) { return default; }
	public void ShowAllSteamVR_ActionOrigins() {}
	public TArray<FSteamVRInputBindingInfo> GetSteamVR_InputBindingInfo(FSteamVRAction SteamVRActionHandle,TArray<FSteamVRInputBindingInfo> ReturnValue) { return default; }
	public TArray<FSteamVRInputBindingInfo> FindSteamVR_InputBindingInfo(sbyte ActionName,sbyte ActionSet=FName,TArray<FSteamVRInputBindingInfo> ReturnValue) { return default; }
	public bool ResetSeatedPosition(bool ReturnValue) { return default; }
	public float GetUserIPD(float ReturnValue) { return default; }
}
