#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerTools.h")]
///<summary>This is a set of helper functions to access various parts of the Sequencer API via Python. Because Sequencer itself is not suitable for exposing, most functionality</summary>
public partial class USequencerToolsFunctionLibrary : UBlueprintFunctionLibrary {
// SequencerToolsFunctionLibrary
	public bool RenderMovie(UObject InCaptureSettings,FOnRenderMovieStopped OnFinishedCallback,bool ReturnValue) { return default; }
	public bool IsRenderingMovie(bool ReturnValue) { return default; }
	public void CancelMovieRender() {}
	public TArray<FSequencerBoundObjects> GetBoundObjects(UObject InWorld,UObject InSequence,TArray<FMovieSceneBindingProxy> InBindings,FSequencerScriptingRange InRange,TArray<FSequencerBoundObjects> ReturnValue) { return default; }
	public TArray<FSequencerBoundObjects> GetObjectBindings(UObject InWorld,UObject InSequence,TArray<UObject> InObject,FSequencerScriptingRange InRange,TArray<FSequencerBoundObjects> ReturnValue) { return default; }
	public bool ExportLevelSequenceFBX(FSequencerExportFBXParams InParams,bool ReturnValue) { return default; }
	public bool ExportAnimSequence(UObject World,UObject Sequence,UObject AnimSequence,UObject ExportOption,FMovieSceneBindingProxy Binding,bool bCreateLink,bool ReturnValue) { return default; }
	public bool LinkAnimSequence(UObject Sequence,UObject AnimSequence,UObject ExportOptions,FMovieSceneBindingProxy Binding,bool ReturnValue) { return default; }
	public void ClearLinkedAnimSequences(UObject InLevelSequence) {}
	public UObject GetLevelSequenceLinkFromAnimSequence(UObject InAnimSequence,UObject ReturnValue) { return default; }
	public UObject GetAnimSequenceLinkFromLevelSequence(UObject InLevelSequence,UObject ReturnValue) { return default; }
	public bool ImportLevelSequenceFBX(UObject InWorld,UObject InSequence,TArray<FMovieSceneBindingProxy> InBindings,UObject InImportFBXSettings,sbyte InImportFilename,bool ReturnValue) { return default; }
	public FMovieSceneEvent CreateEvent(UObject InSequence,UObject InSection,FSequencerQuickBindingResult InEndpoint,TArray<sbyte> InPayload,FMovieSceneEvent ReturnValue) { return default; }
	public bool IsEventEndpointValid(FSequencerQuickBindingResult InEndpoint,bool ReturnValue) { return default; }
	public FSequencerQuickBindingResult CreateQuickBinding(UObject InSequence,UObject InObject,sbyte InFunctionName,bool bCallInEditor,FSequencerQuickBindingResult ReturnValue) { return default; }
	public bool ImportFBXToControlRig(UObject World,UObject InSequence,sbyte ActorWithControlRigTrack,TArray<sbyte> SelectedControlRigNames,UObject ImportFBXControlRigSettings,sbyte ImportFilename,bool ReturnValue) { return default; }
}
