#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/MovieSceneGameplayCueSections.h")]
public partial struct FMovieSceneGameplayCueKey {
// MovieSceneGameplayCueKey
	public FGameplayCueTag Cue;
	public FVector Location;
	public FVector Normal;
	public string AttachSocketName;
	public float NormalizedMagnitude;
	public FMovieSceneObjectBindingID Instigator;
	public FMovieSceneObjectBindingID EffectCauser;
	public UPhysicalMaterial PhysicalMaterial;
	public int GameplayEffectLevel;
	public int AbilityLevel;
	public bool bAttachToBinding;
}
