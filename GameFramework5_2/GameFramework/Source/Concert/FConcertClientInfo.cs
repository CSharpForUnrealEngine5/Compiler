#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessageData.h")]
///<summary>Holds info on a client connected through concert</summary>
public partial struct FConcertClientInfo {
// ConcertClientInfo
	public FConcertInstanceInfo InstanceInfo;
	public sbyte DeviceName;
	public sbyte PlatformName;
	public sbyte UserName;
	public sbyte DisplayName;
	public FLinearColor AvatarColor;
	public sbyte DesktopAvatarActorClass;
	public sbyte VRAvatarActorClass;
	public TArray<sbyte> Tags;
	public bool bHasEditorData;
	public bool bRequiresCookedData;
}
