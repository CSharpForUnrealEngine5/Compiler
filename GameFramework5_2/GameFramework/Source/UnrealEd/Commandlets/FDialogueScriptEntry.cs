#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Commandlets/ExportDialogueScriptCommandlet.h")]
public partial struct FDialogueScriptEntry {
// DialogueScriptEntry
	public sbyte SpeakingVoice;
	public TArray<sbyte> TargetVoices;
	public sbyte SpokenDialogue;
	public sbyte VoiceActorDirection;
	public sbyte AudioFileName;
	public sbyte DialogueAsset;
	public bool IsRecorded;
	public TArray<sbyte> LocalizationKeys;
	public sbyte SpeakingVoiceGUID;
	public TArray<sbyte> TargetVoiceGUIDs;
	public sbyte DialogueAssetGUID;
}
