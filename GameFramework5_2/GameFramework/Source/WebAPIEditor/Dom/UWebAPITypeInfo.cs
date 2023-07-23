#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPIType.h")]
///<summary>Holds information for an existing or pending type.</summary>
public partial class UWebAPITypeInfo : UObject {
// WebAPITypeInfo
	public sbyte Name;
	public sbyte DisplayName;
	public EWebAPISchemaType SchemaType;
	public bool bIsNested;
	public FWebAPITypeNameVariant ContainingType;
	public sbyte JsonName;
	public sbyte JsonType;
	public sbyte JsonPropertyToSerialize;
	public sbyte PrintFormatSpecifier;
	public sbyte PrintFormatExpression;
	public sbyte Namespace;
	public sbyte Prefix;
	public sbyte Suffix;
	public sbyte DeclarationType;
	public bool bIsBuiltinType;
	public sbyte DefaultValue;
	public TSoftObjectPtr<UWebAPIModelBase> Model;
	public TSet<sbyte> Modules;
	public TSet<sbyte> IncludePaths;
	public FSlateColor PinColor;
	public sbyte DebugString;
}
