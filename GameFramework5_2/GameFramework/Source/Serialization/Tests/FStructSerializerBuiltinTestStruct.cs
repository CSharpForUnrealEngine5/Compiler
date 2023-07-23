#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/StructSerializerTestTypes.h")]
///<summary>Test structure for properties of various built-in types.</summary>
public partial struct FStructSerializerBuiltinTestStruct {
// StructSerializerBuiltinTestStruct
	public FGuid Guid;
	public sbyte Name;
	public sbyte String;
	public sbyte Text;
	public FVector Vector;
	public FVector4 Vector4;
	public FRotator Rotator;
	public FQuat Quat;
	public FColor Color;
}
