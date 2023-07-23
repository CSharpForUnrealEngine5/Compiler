#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlPreset.h")]
///<summary>Holds exposed functions and properties.</summary>
public partial class URemoteControlPreset : UObject {
// RemoteControlPreset
	public FRemoteControlPresetLayout Layout;
	public TMap<sbyte,sbyte> Metadata;
	public TArray<URemoteControlBinding> Bindings;
	public URCVirtualPropertyContainerBase ControllerContainer;
	public FGuid PresetId;
	public TMap<FGuid,FRCCachedFieldData> FieldCache;
	public TMap<sbyte,FGuid> NameToGuidMap;
	public URemoteControlExposeRegistry Registry;
	public TArray<sbyte> DetailsTabIdentifierOverrides;
}
