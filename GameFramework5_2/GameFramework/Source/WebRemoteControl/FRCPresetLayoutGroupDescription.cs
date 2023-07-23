#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCPresetLayoutGroupDescription {
// RCPresetLayoutGroupDescription
	public sbyte Name;
	public TArray<FRCExposedPropertyDescription> ExposedProperties;
	public TArray<FRCExposedFunctionDescription> ExposedFunctions;
	public TArray<FRCExposedActorDescription> ExposedActors;
}
