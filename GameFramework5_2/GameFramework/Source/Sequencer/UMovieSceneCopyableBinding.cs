#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneCopyableBinding.h")]
public partial class UMovieSceneCopyableBinding : UObject {
// MovieSceneCopyableBinding
	public UObject SpawnableObjectTemplate;
	public TArray<UMovieSceneTrack> Tracks;
	public FMovieSceneBinding Binding;
	public FMovieSceneSpawnable Spawnable;
	public FMovieScenePossessable Possessable;
	public TArray<sbyte> BoundObjectNames;
	public TArray<sbyte> FolderPath;
}
