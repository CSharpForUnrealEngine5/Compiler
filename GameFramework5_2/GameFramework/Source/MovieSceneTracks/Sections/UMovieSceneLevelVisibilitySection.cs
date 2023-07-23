#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneLevelVisibilitySection.h")]
///<summary>A section for use with the movie scene level visibility track, which controls streamed level visibility.</summary>
public partial class UMovieSceneLevelVisibilitySection : UMovieSceneSection {
// MovieSceneLevelVisibilitySection
	public ELevelVisibility GetVisibility(ELevelVisibility ReturnValue) { return default; }
	public void SetVisibility(ELevelVisibility InVisibility) {}
	public TArray<sbyte> GetLevelNames(TArray<sbyte> ReturnValue) { return default; }
	public void SetLevelNames(TArray<sbyte> InLevelNames) {}
	public ELevelVisibility Visibility;
	public TArray<sbyte> LevelNames;
}
