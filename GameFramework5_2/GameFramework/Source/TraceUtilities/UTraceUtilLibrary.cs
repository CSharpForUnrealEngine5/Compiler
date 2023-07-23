#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TraceUtilLibrary.h")]
public partial class UTraceUtilLibrary : UBlueprintFunctionLibrary {
// TraceUtilLibrary
	public bool StartTraceToFile(sbyte FileName,TArray<sbyte> Channels,bool ReturnValue) { return default; }
	public bool StartTraceSendTo(sbyte Target,TArray<sbyte> Channels,bool ReturnValue) { return default; }
	public bool StopTracing(bool ReturnValue) { return default; }
	public bool PauseTracing(bool ReturnValue) { return default; }
	public bool ResumeTracing(bool ReturnValue) { return default; }
	public bool IsTracing(bool ReturnValue) { return default; }
	public bool ToggleChannel(sbyte ChannelName,bool enabled,bool ReturnValue) { return default; }
	public bool IsChannelEnabled(sbyte ChannelName,bool ReturnValue) { return default; }
	public TArray<sbyte> GetEnabledChannels(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetAllChannels(TArray<sbyte> ReturnValue) { return default; }
	public void TraceBookmark(sbyte Name) {}
	public void TraceMarkRegionStart(sbyte Name) {}
	public void TraceMarkRegionEnd(sbyte Name) {}
}
