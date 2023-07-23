#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/StructSerializerTestTypes.h")]
///<summary>Test structure for map properties.</summary>
public partial struct FStructSerializerMapTestStruct {
// StructSerializerMapTestStruct
	public TMap<int,sbyte> IntToStr;
	public TMap<sbyte,sbyte> StrToStr;
	public TMap<sbyte,FVector> StrToVec;
	public TMap<sbyte,FStructSerializerBuiltinTestStruct> StrToStruct;
}
