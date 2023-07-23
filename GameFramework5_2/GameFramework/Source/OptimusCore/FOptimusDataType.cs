#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusDataType.h")]
public partial struct FOptimusDataType {
// OptimusDataType
	public sbyte TypeName;
	public sbyte DisplayName;
	public FShaderValueTypeHandle ShaderValueType;
	public int ShaderValueSize;
	public sbyte TypeCategory;
	public TWeakObjectPtr<UObject> TypeObject;
	public bool bHasCustomPinColor;
	public FLinearColor CustomPinColor;
	public EOptimusDataTypeUsageFlags UsageFlags;
	public EOptimusDataTypeFlags TypeFlags;
}
