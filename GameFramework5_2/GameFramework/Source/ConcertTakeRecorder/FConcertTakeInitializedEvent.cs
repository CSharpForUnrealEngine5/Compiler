#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTakeRecorderMessages.h")]
public partial struct FConcertTakeInitializedEvent {
// ConcertTakeInitializedEvent
	public sbyte TakePresetPath;
	public sbyte TakeName;
	public TArray<byte> TakeData;
	public sbyte TakeMetaDataPath;
	public FConcertLocalIdentifierState IdentifierState;
	public FTakeRecorderUserParameters Settings;
}
