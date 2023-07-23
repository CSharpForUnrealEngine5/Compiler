#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationTypes.h")]
public partial struct FClientConversationMessage {
// ClientConversationMessage
	public FGameplayTag SpeakerID;
	public sbyte ParticipantDisplayName;
	public sbyte Text;
	public TArray<FConversationNodeParameterPair> MetadataParameters;
}
