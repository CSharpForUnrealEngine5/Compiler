#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/DialogueWave.h")]
public partial class UDialogueWave : UObject {
// DialogueWave
	public bool bMature;
	public bool bOverride_SubtitleOverride;
	public sbyte SpokenText;
	public sbyte SubtitleOverride;
	public sbyte VoiceActorDirection;
	public TArray<FDialogueContextMapping> ContextMappings;
	public FGuid LocalizationGUID;
}
