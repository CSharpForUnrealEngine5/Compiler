#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequence/VirtualCameraClipsMetaData.h")]
///<summary>Clips meta-data that is stored on ULevelSequence assets that are recorded through the virtual camera.</summary>
public partial class UVirtualCameraClipsMetaData : UObject {
// VirtualCameraClipsMetaData
	public float GetFocalLength(float ReturnValue) { return default; }
	public bool GetSelected(bool ReturnValue) { return default; }
	public sbyte GetRecordedLevelName(sbyte ReturnValue) { return default; }
	public int GetFrameCountStart(int ReturnValue) { return default; }
	public int GetFrameCountEnd(int ReturnValue) { return default; }
	public int GetLengthInFrames(int ReturnValue) { return default; }
	public FFrameRate GetDisplayRate(FFrameRate ReturnValue) { return default; }
	public bool GetIsACineCameraRecording(bool ReturnValue) { return default; }
	public void SetFocalLength(float InFocalLength) {}
	public void SetSelected(bool bInSelected) {}
	public void SetRecordedLevelName(sbyte InLevelName) {}
	public void SetFrameCountStart(int InFrame) {}
	public void SetFrameCountEnd(int InFrame) {}
	public void SetLengthInFrames(int InLength) {}
	public void SetDisplayRate(FFrameRate InDisplayRate) {}
	public void SetIsACineCameraRecording(bool bInIsACineCameraRecording) {}
	public float FocalLength;
	public bool bIsSelected;
	public sbyte RecordedLevelName;
	public int FrameCountStart;
	public int FrameCountEnd;
	public int LengthInFrames;
	public FFrameRate DisplayRate;
	public bool bIsACineCameraRecording;
}
