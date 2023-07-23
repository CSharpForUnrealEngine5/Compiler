#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimDistanceMatchingLibrary.h")]
///<summary>Library of techniques for driving animations by distance metrics rather than by time.</summary>
public partial class UAnimDistanceMatchingLibrary : UBlueprintFunctionLibrary {
// AnimDistanceMatchingLibrary
	public FSequenceEvaluatorReference AdvanceTimeByDistanceMatching(FAnimUpdateContext UpdateContext,FSequenceEvaluatorReference SequenceEvaluator,float DistanceTraveled,sbyte DistanceCurveName,FVector2D PlayRateClamp=FVector2D,FSequenceEvaluatorReference ReturnValue) { return default; }
	public FSequenceEvaluatorReference DistanceMatchToTarget(FSequenceEvaluatorReference SequenceEvaluator,float DistanceToTarget,sbyte DistanceCurveName,FSequenceEvaluatorReference ReturnValue) { return default; }
	public FSequencePlayerReference SetPlayrateToMatchSpeed(FSequencePlayerReference SequencePlayer,float SpeedToMatch,FVector2D PlayRateClamp=FVector2D,FSequencePlayerReference ReturnValue) { return default; }
}
