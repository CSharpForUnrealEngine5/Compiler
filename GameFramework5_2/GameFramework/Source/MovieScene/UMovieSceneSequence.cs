#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneSequence.h")]
///<summary>Abstract base class for movie scene animations (C++ version).</summary>
public partial class UMovieSceneSequence : UMovieSceneSignedObject {
// MovieSceneSequence
	public FMovieSceneObjectBindingID FindBindingByTag(sbyte InBindingName,FMovieSceneObjectBindingID ReturnValue) { return default; }
	public TArray<FMovieSceneObjectBindingID> FindBindingsByTag(sbyte InBindingName,TArray<FMovieSceneObjectBindingID> ReturnValue) { return default; }
	public FMovieSceneTimecodeSource GetEarliestTimecodeSource(FMovieSceneTimecodeSource ReturnValue) { return default; }
	public UMovieSceneCompiledData CompiledData;
	public EMovieSceneCompletionMode DefaultCompletionMode;
	public bool bParentContextsAreSignificant;
	public bool bPlayableDirectly;
	public EMovieSceneSequenceFlags SequenceFlags;
}
