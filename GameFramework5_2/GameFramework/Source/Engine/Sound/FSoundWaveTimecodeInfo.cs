#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundWaveTimecodeInfo.h")]
public partial struct FSoundWaveTimecodeInfo {
// SoundWaveTimecodeInfo
	public ulong NumSamplesSinceMidnight;
	public uint NumSamplesPerSecond;
	public sbyte Description;
	public sbyte OriginatorTime;
	public sbyte OriginatorDate;
	public sbyte OriginatorDescription;
	public sbyte OriginatorReference;
	public FFrameRate TimecodeRate;
	public bool bTimecodeIsDropFrame;
}
