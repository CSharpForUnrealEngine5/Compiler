#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertClientSettings.h")]
public partial struct FConcertClientSettings {
// ConcertClientSettings
	public string DisplayName;
	public FLinearColor AvatarColor;
	public FSoftClassPath DesktopAvatarActorClass;
	public FSoftClassPath VRAvatarActorClass;
	public ushort ServerPort;
	public int DiscoveryTimeoutSeconds;
	public int SessionTickFrequencySeconds;
	public float LatencyCompensationMs;
	public bool bReflectLevelEditorInGame;
	public bool bSupportMixedBuildTypes;
	public TArray<string> Tags;
	public string ClientAuthenticationKey;
}
