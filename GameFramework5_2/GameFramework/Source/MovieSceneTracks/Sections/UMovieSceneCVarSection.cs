#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneCVarSection.h")]
///<summary>A CVar section is responsible for applying a user-supplied value to the specified cvar, and then restoring the previous value after the section ends.</summary>
public partial class UMovieSceneCVarSection : UMovieSceneSection {
// MovieSceneCVarSection
	public void SetFromString(sbyte InString) {}
	public sbyte GetString(sbyte ReturnValue) { return default; }
	public TArray<FMovieSceneConsoleVariableCollection> ConsoleVariableCollections;
	public FMovieSceneCVarOverrides ConsoleVariables;
}
