#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundUtilities.h")]
///<summary>Sound Utilities Blueprint Function Library</summary>
public partial class USoundUtilitiesBPFunctionLibrary : UBlueprintFunctionLibrary {
// SoundUtilitiesBPFunctionLibrary
	public float GetBeatTempo(float BeatsPerMinute=120.0f,int BeatMultiplier=1,int DivisionsOfWholeNote=4,float ReturnValue) { return default; }
	public float GetFrequencyFromMIDIPitch(int MidiNote,float ReturnValue) { return default; }
	public int GetMIDIPitchFromFrequency(float Frequency,int ReturnValue) { return default; }
	public float GetPitchScaleFromMIDIPitch(int BaseMidiNote,int TargetMidiNote,float ReturnValue) { return default; }
	public float GetGainFromMidiVelocity(int InVelocity,float ReturnValue) { return default; }
	public float ConvertLinearToDecibels(float InLinear,float InFloor,float ReturnValue) { return default; }
	public float ConvertDecibelsToLinear(float InDecibels,float ReturnValue) { return default; }
	public float GetLogFrequencyClamped(float InValue,FVector2D InDomain,FVector2D InRange,float ReturnValue) { return default; }
	public float GetLinearFrequencyClamped(float InValue,FVector2D InDomain,FVector2D InRange,float ReturnValue) { return default; }
	public float GetFrequencyMultiplierFromSemitones(float InPitchSemitones,float ReturnValue) { return default; }
	public float GetBandwidthFromQ(float InQ,float ReturnValue) { return default; }
	public float GetQFromBandwidth(float InBandwidth,float ReturnValue) { return default; }
}
