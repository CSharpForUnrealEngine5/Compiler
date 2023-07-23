#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
///<summary>Event triggered when an exposed entity struct is modified.</summary>
public partial struct FRCPresetEntitiesModifiedEvent {
// RCPresetEntitiesModifiedEvent
	public sbyte Type;
	public sbyte PresetName;
	public sbyte PresetId;
	public FRCPresetModifiedEntitiesDescription ModifiedEntities;
}
