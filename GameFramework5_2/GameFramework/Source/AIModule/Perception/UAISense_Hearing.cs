#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Hearing.h")]
public partial class UAISense_Hearing : UAISense {
// AISense_Hearing
	public TArray<FAINoiseEvent> NoiseEvents;
	public float SpeedOfSoundSq;
	public void ReportNoiseEvent(UObject WorldContextObject,FVector NoiseLocation,float Loudness=1.f,UObject Instigator=nullptr,float MaxRange=0.f,sbyte Tag=NAME_None) {}
}
