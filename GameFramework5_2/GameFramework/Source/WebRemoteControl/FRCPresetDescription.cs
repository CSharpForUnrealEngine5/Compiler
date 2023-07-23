#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCPresetDescription {
// RCPresetDescription
	public sbyte Name;
	public sbyte Path;
	public sbyte ID;
	public TArray<FRCPresetLayoutGroupDescription> Groups;
	public TArray<FRCControllerDescription> Controllers;
}
