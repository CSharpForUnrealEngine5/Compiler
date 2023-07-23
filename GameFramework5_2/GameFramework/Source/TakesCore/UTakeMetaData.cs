#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TakeMetaData.h")]
///<summary>Take meta-data that is stored on ULevelSequence assets that are recorded through the Take Recorder.</summary>
public partial class UTakeMetaData : UObject {
// TakeMetaData
	public bool IsLocked(bool ReturnValue) { return default; }
	public bool Recorded(bool ReturnValue) { return default; }
	public sbyte GetSlate(sbyte ReturnValue) { return default; }
	public int GetTakeNumber(int ReturnValue) { return default; }
	public FDateTime GetTimestamp(FDateTime ReturnValue) { return default; }
	public FTimecode GetTimecodeIn(FTimecode ReturnValue) { return default; }
	public FTimecode GetTimecodeOut(FTimecode ReturnValue) { return default; }
	public FFrameTime GetDuration(FFrameTime ReturnValue) { return default; }
	public FFrameRate GetFrameRate(FFrameRate ReturnValue) { return default; }
	public sbyte GetDescription(sbyte ReturnValue) { return default; }
	public UObject GetPresetOrigin(UObject ReturnValue) { return default; }
	public sbyte GetLevelPath(sbyte ReturnValue) { return default; }
	public UObject GetLevelOrigin(UObject ReturnValue) { return default; }
	public bool GetFrameRateFromTimecode(bool ReturnValue) { return default; }
	public void Lock() {}
	public void Unlock() {}
	public sbyte GenerateAssetPath(sbyte PathFormatString,sbyte ReturnValue) { return default; }
	public void SetSlate(sbyte InSlate,bool bEmitChanged=true) {}
	public void SetTakeNumber(int InTakeNumber,bool bEmitChanged=true) {}
	public void SetTimestamp(FDateTime InTimestamp) {}
	public void SetTimecodeIn(FTimecode InTimecodeIn) {}
	public void SetTimecodeOut(FTimecode InTimecodeOut) {}
	public void SetDuration(FFrameTime InDuration) {}
	public void SetFrameRate(FFrameRate InFrameRate) {}
	public void SetDescription(sbyte InDescription) {}
	public void SetPresetOrigin(UObject InPresetOrigin) {}
	public void SetLevelOrigin(UObject InLevelOrigin) {}
	public void SetFrameRateFromTimecode(bool InFromTimecode) {}
	public bool bIsLocked;
	public sbyte Slate;
	public int TakeNumber;
	public FDateTime Timestamp;
	public FTimecode TimecodeIn;
	public FTimecode TimecodeOut;
	public FFrameTime Duration;
	public FFrameRate FrameRate;
	public sbyte Description;
	public TSoftObjectPtr<UTakePreset> PresetOrigin;
	public TSoftObjectPtr<ULevel> LevelOrigin;
	public bool bFrameRateFromTimecode;
}
