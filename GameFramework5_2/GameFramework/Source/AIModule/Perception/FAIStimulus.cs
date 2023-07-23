#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AIPerceptionTypes.h")]
public partial struct FAIStimulus {
// AIStimulus
	public float Age;
	public float ExpirationAge;
	public float Strength;
	public FVector StimulusLocation;
	public FVector ReceiverLocation;
	public sbyte Tag;
	public bool bSuccessfullySensed;
}
