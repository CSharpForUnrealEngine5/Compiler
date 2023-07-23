#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCExposedPropertyDescription {
// RCExposedPropertyDescription
	public sbyte DisplayName;
	public sbyte ID;
	public FRCPropertyDescription UnderlyingProperty;
	public TMap<sbyte,sbyte> Metadata;
	public TArray<FRCObjectDescription> OwnerObjects;
}
