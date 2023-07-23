#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimeManagementBlueprintLibrary.h")]
public partial class UTimeManagementBlueprintLibrary : UBlueprintFunctionLibrary {
// TimeManagementBlueprintLibrary
	public float Conv_FrameRateToSeconds(FFrameRate InFrameRate,float ReturnValue) { return default; }
	public float Conv_QualifiedFrameTimeToSeconds(FQualifiedFrameTime InFrameTime,float ReturnValue) { return default; }
	public FFrameTime Multiply_SecondsFrameRate(float TimeInSeconds,FFrameRate FrameRate,FFrameTime ReturnValue) { return default; }
	public sbyte Conv_TimecodeToString(FTimecode InTimecode,bool bForceSignDisplay=false,sbyte ReturnValue) { return default; }
	public bool IsValid_Framerate(FFrameRate InFrameRate,bool ReturnValue) { return default; }
	public bool IsValid_MultipleOf(FFrameRate InFrameRate,FFrameRate OtherFramerate,bool ReturnValue) { return default; }
	public FFrameTime TransformTime(FFrameTime SourceTime,FFrameRate SourceRate,FFrameRate DestinationRate,FFrameTime ReturnValue) { return default; }
	public FFrameTime SnapFrameTimeToRate(FFrameTime SourceTime,FFrameRate SourceRate,FFrameRate SnapToRate,FFrameTime ReturnValue) { return default; }
	public FFrameNumber Add_FrameNumberFrameNumber(FFrameNumber A,FFrameNumber B,FFrameNumber ReturnValue) { return default; }
	public FFrameNumber Subtract_FrameNumberFrameNumber(FFrameNumber A,FFrameNumber B,FFrameNumber ReturnValue) { return default; }
	public FFrameNumber Add_FrameNumberInteger(FFrameNumber A,int B,FFrameNumber ReturnValue) { return default; }
	public FFrameNumber Subtract_FrameNumberInteger(FFrameNumber A,int B,FFrameNumber ReturnValue) { return default; }
	public FFrameNumber Multiply_FrameNumberInteger(FFrameNumber A,int B,FFrameNumber ReturnValue) { return default; }
	public FFrameNumber Divide_FrameNumberInteger(FFrameNumber A,int B,FFrameNumber ReturnValue) { return default; }
	public int Conv_FrameNumberToInteger(FFrameNumber InFrameNumber,int ReturnValue) { return default; }
	public FTimecode GetTimecode(FTimecode ReturnValue) { return default; }
	public FFrameRate GetTimecodeFrameRate(FFrameRate ReturnValue) { return default; }
}
