#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCPropertyDescription {
// RCPropertyDescription
	public sbyte Name;
	public sbyte DisplayName;
	public sbyte Description;
	public sbyte Type;
	public sbyte TypePath;
	public sbyte ContainerType;
	public sbyte KeyType;
	public TMap<sbyte,sbyte> Metadata;
}
