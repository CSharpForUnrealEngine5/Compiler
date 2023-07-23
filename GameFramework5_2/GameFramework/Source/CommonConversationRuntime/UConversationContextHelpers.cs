#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationContext.h")]
///<summary>Wrapper methods from FConversationContext</summary>
public partial class UConversationContextHelpers : UBlueprintFunctionLibrary {
// ConversationContextHelpers
	public UObject GetConversationInstance(FConversationContext Context,UObject ReturnValue) { return default; }
	public FConversationNodeHandle GetCurrentConversationNodeHandle(FConversationContext Context,FConversationNodeHandle ReturnValue) { return default; }
	public void MakeConversationParticipant(FConversationContext Context,UObject ParticipantActor,FGameplayTag ParticipantTag) {}
	public FConversationTaskResult AdvanceConversation(FConversationContext Context,FConversationTaskResult ReturnValue) { return default; }
	public FConversationTaskResult AdvanceConversationWithChoice(FConversationContext Context,FAdvanceConversationRequest Choice,FConversationTaskResult ReturnValue) { return default; }
	public FConversationTaskResult PauseConversationAndSendClientChoices(FConversationContext Context,FClientConversationMessage Message,FConversationTaskResult ReturnValue) { return default; }
	public FConversationTaskResult ReturnToLastClientChoice(FConversationContext Context,FConversationTaskResult ReturnValue) { return default; }
	public FConversationTaskResult ReturnToCurrentClientChoice(FConversationContext Context,FConversationTaskResult ReturnValue) { return default; }
	public FConversationTaskResult ReturnToConversationStart(FConversationContext Context,FConversationTaskResult ReturnValue) { return default; }
	public FConversationTaskResult AbortConversation(FConversationContext Context,FConversationTaskResult ReturnValue) { return default; }
	public bool CanConversationContinue(FConversationTaskResult ConversationTasResult,bool ReturnValue) { return default; }
	public UObject GetConversationParticipant(FConversationContext Context,FGameplayTag ParticipantTag,UObject ReturnValue) { return default; }
	public UObject GetConversationParticipantActor(FConversationContext Context,FGameplayTag ParticipantTag,UObject ReturnValue) { return default; }
	public UObject FindConversationComponent(UObject Actor,UObject ReturnValue) { return default; }
}
