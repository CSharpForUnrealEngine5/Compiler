#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Commandlets/ExportDialogueScriptCommandlet.h")]
public partial struct FDialogueScriptEntry {
// DialogueScriptEntry
	public string SpeakingVoice;
	public TArray<string> TargetVoices;
	public string SpokenDialogue;
	public string VoiceActorDirection;
	public string AudioFileName;
	public string DialogueAsset;
	public bool IsRecorded;
	public TArray<string> LocalizationKeys;
	public string SpeakingVoiceGUID;
	public TArray<string> TargetVoiceGUIDs;
	public string DialogueAssetGUID;
}
