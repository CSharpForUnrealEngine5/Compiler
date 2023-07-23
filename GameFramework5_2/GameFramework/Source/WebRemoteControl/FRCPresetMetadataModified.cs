#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCPresetMetadataModified {
// RCPresetMetadataModified
	public sbyte Type;
	public sbyte PresetName;
	public sbyte PresetId;
	public TMap<sbyte,sbyte> Metadata;
}
