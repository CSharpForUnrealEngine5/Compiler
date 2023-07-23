#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KismetAnimationLibrary.h")]
///<summary>A library of the most common animation blueprint functions.</summary>
public partial class UKismetAnimationLibrary : UBlueprintFunctionLibrary {
// KismetAnimationLibrary
	public void K2_TwoBoneIK(FVector RootPos,FVector JointPos,FVector EndPos,FVector JointTarget,FVector Effector,FVector OutJointPos,FVector OutEndPos,bool bAllowStretching,float StartStretchRatio,float MaxStretchScale) {}
	public FTransform K2_LookAt(FTransform CurrentTransform,FVector TargetPosition,FVector LookAtVector,bool bUseUpVector,FVector UpVector,float ClampConeInDegree,FTransform ReturnValue) { return default; }
	public float K2_DistanceBetweenTwoSocketsAndMapRange(UObject Component,sbyte SocketOrBoneNameA,ERelativeTransformSpace SocketSpaceA,sbyte SocketOrBoneNameB,ERelativeTransformSpace SocketSpaceB,bool bRemapRange,float InRangeMin,float InRangeMax,float OutRangeMin,float OutRangeMax,float ReturnValue) { return default; }
	public FVector K2_DirectionBetweenSockets(UObject Component,sbyte SocketOrBoneNameFrom,sbyte SocketOrBoneNameTo,FVector ReturnValue) { return default; }
	public FVector K2_MakePerlinNoiseVectorAndRemap(float X,float Y,float Z,float RangeOutMinX,float RangeOutMaxX,float RangeOutMinY,float RangeOutMaxY,float RangeOutMinZ,float RangeOutMaxZ,FVector ReturnValue) { return default; }
	public float K2_MakePerlinNoiseAndRemap(float Value,float RangeOutMin,float RangeOutMax,float ReturnValue) { return default; }
	public float K2_CalculateVelocityFromPositionHistory(float DeltaSeconds,FVector Position,FPositionHistory History,int NumberOfSamples,float VelocityMin,float VelocityMax,float ReturnValue) { return default; }
	public float K2_CalculateVelocityFromSockets(float DeltaSeconds,UObject Component,sbyte SocketOrBoneName,sbyte ReferenceSocketOrBone,ERelativeTransformSpace SocketSpace,FVector OffsetInBoneSpace,FPositionHistory History,int NumberOfSamples,float VelocityMin,float VelocityMax,EEasingFuncType EasingType,FRuntimeFloatCurve CustomCurve,float ReturnValue) { return default; }
	public void K2_StartProfilingTimer() {}
	public float K2_EndProfilingTimer(bool bLog=true,sbyte LogPrefix="",float ReturnValue) { return default; }
	public float CalculateDirection(FVector Velocity,FRotator BaseRotation,float ReturnValue) { return default; }
}
