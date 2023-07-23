#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WebAPIProviderSettings.h")]
///<summary>Encapsulates settings for WebAPI providers.</summary>
public partial struct FWebAPIProviderSettings {
// WebAPIProviderSettings
	public bool bEnableArbitraryJsonPayloads;
	public sbyte RequestTypeNameTemplate;
	public sbyte ResponseTypeNameTemplate;
	public sbyte NestedPropertyTypeNameTemplate;
	public sbyte ParameterTypeNameTemplate;
	public sbyte OperationObjectNameTemplate;
	public sbyte UnsetEnumValueName;
	public sbyte DefaultPropertyName;
	public sbyte DefaultArrayPropertyName;
}
