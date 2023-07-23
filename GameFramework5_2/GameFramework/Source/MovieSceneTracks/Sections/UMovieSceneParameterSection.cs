#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneParameterSection.h")]
///<summary>A single movie scene section which can contain data for multiple named parameters.</summary>
public partial class UMovieSceneParameterSection : UMovieSceneSection {
// MovieSceneParameterSection
	public void AddScalarParameterKey(sbyte InParameterName,FFrameNumber InTime,float InValue) {}
	public void AddBoolParameterKey(sbyte InParameterName,FFrameNumber InTime,bool InValue) {}
	public void AddVector2DParameterKey(sbyte InParameterName,FFrameNumber InTime,FVector2D InValue) {}
	public void AddVectorParameterKey(sbyte InParameterName,FFrameNumber InTime,FVector InValue) {}
	public void AddColorParameterKey(sbyte InParameterName,FFrameNumber InTime,FLinearColor InValue) {}
	public void AddTransformParameterKey(sbyte InParameterName,FFrameNumber InTime,FTransform InValue) {}
	public bool RemoveScalarParameter(sbyte InParameterName,bool ReturnValue) { return default; }
	public bool RemoveBoolParameter(sbyte InParameterName,bool ReturnValue) { return default; }
	public bool RemoveVector2DParameter(sbyte InParameterName,bool ReturnValue) { return default; }
	public bool RemoveVectorParameter(sbyte InParameterName,bool ReturnValue) { return default; }
	public bool RemoveColorParameter(sbyte InParameterName,bool ReturnValue) { return default; }
	public bool RemoveTransformParameter(sbyte InParameterName,bool ReturnValue) { return default; }
	public void GetParameterNames(TSet<sbyte> ParameterNames) {}
	public TArray<FBoolParameterNameAndCurve> BoolParameterNamesAndCurves;
	public TArray<FScalarParameterNameAndCurve> ScalarParameterNamesAndCurves;
	public TArray<FVector2DParameterNameAndCurves> Vector2DParameterNamesAndCurves;
	public TArray<FVectorParameterNameAndCurves> VectorParameterNamesAndCurves;
	public TArray<FColorParameterNameAndCurves> ColorParameterNamesAndCurves;
	public TArray<FTransformParameterNameAndCurves> TransformParameterNamesAndCurves;
}
