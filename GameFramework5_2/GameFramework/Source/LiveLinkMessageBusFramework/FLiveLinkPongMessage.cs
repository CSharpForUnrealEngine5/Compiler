#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkMessages.h")]
public partial struct FLiveLinkPongMessage {
// LiveLinkPongMessage
	public sbyte ProviderName;
	public sbyte MachineName;
	public FGuid PollRequest;
	public int LiveLinkVersion;
	public double CreationPlatformTime;
}
