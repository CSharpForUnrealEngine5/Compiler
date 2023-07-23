#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Metadata/PCGMetadataTransformOpElement.h")]
public partial class UPCGMetadataTransformSettings : UPCGMetadataSettingsBase {
// PCGMetadataTransformSettings
	public EPCGMedadataTransformOperation Operation;
	public EPCGTransformLerpMode TransformLerpMode;
	public FPCGAttributePropertySelector InputSource1;
	public FPCGAttributePropertySelector InputSource2;
	public FPCGAttributePropertySelector InputSource3;
	public sbyte Input1AttributeName_DEPRECATED;
	public sbyte Input2AttributeName_DEPRECATED;
	public sbyte Input3AttributeName_DEPRECATED;
}
