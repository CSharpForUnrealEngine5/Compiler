#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusInputFunctionLibrary.h")]
public partial class UDEPRECATED_UOculusInputFunctionLibrary : UBlueprintFunctionLibrary {
// UOculusInputFunctionLibrary
	public EOculusFinger ConvertBoneToFinger(EBone Bone,EOculusFinger ReturnValue) { return default; }
	public bool GetHandSkeletalMesh(UObject HandSkeletalMesh,EOculusHandType SkeletonType,EOculusHandType MeshType,float WorldToMeters=100.0f,bool ReturnValue) { return default; }
	public TArray<FOculusCapsuleCollider> InitializeHandPhysics(EOculusHandType SkeletonType,UObject HandComponent,float WorldToMeters=100.0f,TArray<FOculusCapsuleCollider> ReturnValue) { return default; }
	public FQuat GetBoneRotation(EOculusHandType DeviceHand,EBone BoneId,int ControllerIndex=0,FQuat ReturnValue) { return default; }
	public FTransform GetPointerPose(EOculusHandType DeviceHand,int ControllerIndex=0,FTransform ReturnValue) { return default; }
	public bool IsPointerPoseValid(EOculusHandType DeviceHand,int ControllerIndex=0,bool ReturnValue) { return default; }
	public ETrackingConfidence GetTrackingConfidence(EOculusHandType DeviceHand,int ControllerIndex=0,ETrackingConfidence ReturnValue) { return default; }
	public ETrackingConfidence GetFingerTrackingConfidence(EOculusHandType DeviceHand,EOculusFinger Finger,int ControllerIndex=0,ETrackingConfidence ReturnValue) { return default; }
	public float GetHandScale(EOculusHandType DeviceHand,int ControllerIndex=0,float ReturnValue) { return default; }
	public EOculusHandType GetDominantHand(int ControllerIndex=0,EOculusHandType ReturnValue) { return default; }
	public bool IsHandTrackingEnabled(bool ReturnValue) { return default; }
	public bool IsHandPositionValid(EOculusHandType DeviceHand,int ControllerIndex=0,bool ReturnValue) { return default; }
	public sbyte GetBoneName(EBone BoneId,sbyte ReturnValue) { return default; }
}
