#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionExtractorUtilities.h")]
public partial class UMotionExtractorUtilityLibrary : UBlueprintFunctionLibrary {
// MotionExtractorUtilityLibrary
	public sbyte GenerateCurveName(sbyte BoneName,EMotionExtractor_MotionType MotionType,EMotionExtractor_Axis Axis,sbyte ReturnValue) { return default; }
	public float GetDesiredValue(FTransform BoneTransform,FTransform LastBoneTransform,float DeltaTime,EMotionExtractor_MotionType MotionType,EMotionExtractor_Axis Axis,float ReturnValue) { return default; }
	public TArray<FVector2D> GetStoppedRangesFromRootMotion(UObject AnimSequence,float StopSpeedThreshold=10.0f,float SampleRate=120.0f,TArray<FVector2D> ReturnValue) { return default; }
	public TArray<FVector2D> GetMovingRangesFromRootMotion(UObject AnimSequence,float StopSpeedThreshold=10.0f,float SampleRate=120.0f,TArray<FVector2D> ReturnValue) { return default; }
}
