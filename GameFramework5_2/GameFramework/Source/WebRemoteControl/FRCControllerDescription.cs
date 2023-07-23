#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCControllerDescription {
// RCControllerDescription
	public sbyte DisplayName;
	public sbyte ID;
	public sbyte Type;
	public sbyte Path;
	public TMap<sbyte,sbyte> Metadata;
}
