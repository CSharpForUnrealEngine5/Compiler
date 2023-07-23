#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TemplateSequenceActor.h")]
///<summary>Actor responsible for controlling a specific template sequence in the world.</summary>
public partial class ATemplateSequenceActor : AActor {
// TemplateSequenceActor
	public FMovieSceneSequencePlaybackSettings PlaybackSettings;
	public UTemplateSequencePlayer SequencePlayer;
	public FSoftObjectPath TemplateSequence;
	public FTemplateSequenceBindingOverrideData BindingOverride;
	public UObject GetSequence(UObject ReturnValue) { return default; }
	public UObject LoadSequence(UObject ReturnValue) { return default; }
	public void SetSequence(UObject InSequence) {}
	public UObject GetSequencePlayer(UObject ReturnValue) { return default; }
	public void SetBinding(UObject Actor,bool bOverridesDefault=true) {}
}
