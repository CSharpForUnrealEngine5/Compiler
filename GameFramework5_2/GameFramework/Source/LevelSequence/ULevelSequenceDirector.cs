#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequenceDirector.h")]
public partial class ULevelSequenceDirector : UObject {
// LevelSequenceDirector
	public void OnCreated() {}
	public FQualifiedFrameTime GetRootSequenceTime(FQualifiedFrameTime ReturnValue) { return default; }
	public FQualifiedFrameTime GetMasterSequenceTime(FQualifiedFrameTime ReturnValue) { return default; }
	public FQualifiedFrameTime GetCurrentTime(FQualifiedFrameTime ReturnValue) { return default; }
	public TArray<UObject> GetBoundObjects(FMovieSceneObjectBindingID ObjectBinding,TArray<UObject> ReturnValue) { return default; }
	public UObject GetBoundObject(FMovieSceneObjectBindingID ObjectBinding,UObject ReturnValue) { return default; }
	public TArray<UObject> GetBoundActors(FMovieSceneObjectBindingID ObjectBinding,TArray<UObject> ReturnValue) { return default; }
	public UObject GetBoundActor(FMovieSceneObjectBindingID ObjectBinding,UObject ReturnValue) { return default; }
	public UObject GetSequence(UObject ReturnValue) { return default; }
	public ULevelSequencePlayer Player;
	public int SubSequenceID;
	public int MovieScenePlayerIndex;
}
