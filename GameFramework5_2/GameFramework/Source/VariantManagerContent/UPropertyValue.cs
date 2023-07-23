#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertyValue.h")]
public partial class UPropertyValue : UObject {
// PropertyValue
	public sbyte GetPropertyTooltip(sbyte ReturnValue) { return default; }
	public sbyte GetFullDisplayString(sbyte ReturnValue) { return default; }
	public bool HasRecordedData(bool ReturnValue) { return default; }
	public TArray<object> Properties_DEPRECATED;
	public TArray<int> PropertyIndices_DEPRECATED;
	public TArray<FCapturedPropSegment> CapturedPropSegments;
	public sbyte FullDisplayString;
	public sbyte PropertySetterName;
	public TMap<sbyte,sbyte> PropertySetterParameterDefaults;
	public bool bHasRecordedData;
	public UClass LeafPropertyClass_DEPRECATED;
	public TArray<byte> ValueBytes;
	public EPropertyValueCategory PropCategory;
	public uint DisplayOrder;
}
