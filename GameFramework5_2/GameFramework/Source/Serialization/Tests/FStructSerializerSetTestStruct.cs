#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/StructSerializerTestTypes.h")]
///<summary>Test structure for set properties.</summary>
public partial struct FStructSerializerSetTestStruct {
// StructSerializerSetTestStruct
	public TSet<sbyte> StrSet;
	public TSet<int> IntSet;
	public TSet<sbyte> NameSet;
	public TSet<FStructSerializerBuiltinTestStruct> StructSet;
}
