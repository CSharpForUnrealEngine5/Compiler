#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Metadata/PCGMetadataTrigOpElement.h")]
public partial class UPCGMetadataTrigSettings : UPCGMetadataSettingsBase {
// PCGMetadataTrigSettings
	public EPCGMedadataTrigOperation Operation;
	public FPCGAttributePropertySelector InputSource1;
	public FPCGAttributePropertySelector InputSource2;
	public sbyte Input1AttributeName_DEPRECATED;
	public sbyte Input2AttributeName_DEPRECATED;
}
