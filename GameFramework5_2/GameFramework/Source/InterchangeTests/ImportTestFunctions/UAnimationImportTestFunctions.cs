#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/AnimationImportTestFunctions.h")]
public partial class UAnimationImportTestFunctions : UImportTestFunctionsBase {
// AnimationImportTestFunctions
	public FInterchangeTestFunctionResult CheckImportedAnimSequenceCount(TArray<UObject> AnimSequences,int ExpectedNumberOfImportedAnimSequences,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckAnimationLength(UObject AnimSequence,float ExpectedAnimationLength,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckAnimationFrameNumber(UObject AnimSequence,int ExpectedFrameNumber,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckCurveKeyTime(UObject AnimSequence,sbyte CurveName,int KeyIndex,float ExpectedCurveKeyTime,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckCurveKeyValue(UObject AnimSequence,sbyte CurveName,int KeyIndex,float ExpectedCurveKeyValue,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckCurveKeyArriveTangent(UObject AnimSequence,sbyte CurveName,int KeyIndex,float ExpectedCurveKeyArriveTangent,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckCurveKeyArriveTangentWeight(UObject AnimSequence,sbyte CurveName,int KeyIndex,float ExpectedCurveKeyArriveTangentWeight,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckCurveKeyLeaveTangent(UObject AnimSequence,sbyte CurveName,int KeyIndex,float ExpectedCurveKeyLeaveTangent,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckCurveKeyLeaveTangentWeight(UObject AnimSequence,sbyte CurveName,int KeyIndex,float ExpectedCurveKeyLeaveTangentWeight,FInterchangeTestFunctionResult ReturnValue) { return default; }
}
