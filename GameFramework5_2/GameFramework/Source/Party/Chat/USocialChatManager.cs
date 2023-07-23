#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chat/SocialChatManager.h")]
///<summary>The chat manager is a fully passive construct that watches for creation of chat rooms and message activity therein</summary>
public partial class USocialChatManager : UObject {
// SocialChatManager
	public TMap<TWeakObjectPtr<USocialUser>,USocialPrivateMessageChannel> DirectChannelsByTargetUser;
	public TMap<sbyte,USocialChatRoom> ChatRoomsById;
	public TMap<sbyte,USocialReadOnlyChatChannel> ReadOnlyChannelsByDisplayName;
	public bool bEnableChatSlashCommands;
	public TMap<FUniqueNetIdRepl,USocialGroupChannel> GroupChannels;
}
