#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TimecodeProvider.h")]
///<summary>A class responsible of fetching a timecode from a source.</summary>
public partial class UTimecodeProvider : UObject {
// TimecodeProvider
	public float FrameDelay;
	public bool FetchTimecode(FQualifiedFrameTime OutFrameTime,bool ReturnValue) { return default; }
	public void FetchAndUpdate() {}
	public FQualifiedFrameTime GetQualifiedFrameTime(FQualifiedFrameTime ReturnValue) { return default; }
	public FQualifiedFrameTime GetDelayedQualifiedFrameTime(FQualifiedFrameTime ReturnValue) { return default; }
	public FTimecode GetTimecode(FTimecode ReturnValue) { return default; }
	public FTimecode GetDelayedTimecode(FTimecode ReturnValue) { return default; }
	public FFrameRate GetFrameRate(FFrameRate ReturnValue) { return default; }
	public ETimecodeProviderSynchronizationState GetSynchronizationState(ETimecodeProviderSynchronizationState ReturnValue) { return default; }
}
