#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Metadata/PCGMetadataElement.h")]
public partial class UPCGMetadataOperationSettings : UPCGSettings {
// PCGMetadataOperationSettings
	public FPCGAttributePropertySelector InputSource;
	public FPCGAttributePropertySelector OutputTarget;
	public sbyte SourceAttribute_DEPRECATED;
	public EPCGPointProperties PointProperty_DEPRECATED;
	public sbyte DestinationAttribute_DEPRECATED;
	public EPCGMetadataOperationTarget Target_DEPRECATED;
}
