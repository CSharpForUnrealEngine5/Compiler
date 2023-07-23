#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneCapture.h")]
///<summary>Class responsible for capturing scene data</summary>
public partial class UMovieSceneCapture : UObject {
// MovieSceneCapture
	public FSoftClassPath ImageCaptureProtocolType;
	public FSoftClassPath AudioCaptureProtocolType;
	public UMovieSceneImageCaptureProtocolBase ImageCaptureProtocol;
	public UMovieSceneAudioCaptureProtocolBase AudioCaptureProtocol;
	public FMovieSceneCaptureSettings Settings;
	public bool bUseSeparateProcess;
	public bool bCloseEditorWhenCaptureStarts;
	public sbyte AdditionalCommandLineArguments;
	public sbyte InheritedCommandLineArguments;
	public UObject GetImageCaptureProtocol(UObject ReturnValue) { return default; }
	public UObject GetAudioCaptureProtocol(UObject ReturnValue) { return default; }
	public void SetImageCaptureProtocolType(UClass ProtocolType) {}
	public void SetAudioCaptureProtocolType(UClass ProtocolType) {}
}
