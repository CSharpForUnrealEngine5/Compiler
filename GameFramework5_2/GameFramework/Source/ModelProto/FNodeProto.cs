#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ModelProto.h")]
///<summary>Level 3 - FNodeProto</summary>
public partial struct FNodeProto {
// NodeProto
	public TArray<sbyte> Input;
	public TArray<sbyte> Output;
	public sbyte Name;
	public sbyte OperatorType;
	public sbyte Domain;
	public TArray<FAttributeProto> Attribute;
	public sbyte DocString;
}
