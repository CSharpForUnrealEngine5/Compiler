#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCPresetControllersRemovedEvent {
// RCPresetControllersRemovedEvent
	public sbyte Type;
	public sbyte PresetName;
	public sbyte PresetId;
	public TArray<sbyte> RemovedControllers;
	public TArray<sbyte> RemovedControllerIds;
}
