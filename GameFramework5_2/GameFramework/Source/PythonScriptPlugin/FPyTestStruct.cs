#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PyTest.h")]
///<summary>Struct to allow testing of the various UStruct features that are exposed to Python wrapped types.</summary>
public partial struct FPyTestStruct {
// PyTestStruct
	public bool Bool;
	public int Int;
	public float Float;
	public EPyTestEnum Enum;
	public sbyte String;
	public sbyte Name;
	public sbyte Text;
	public object FieldPath;
	public object StructFieldPath;
	public TArray<sbyte> StringArray;
	public TSet<sbyte> StringSet;
	public TMap<sbyte,int> StringIntMap;
	public int LegacyInt_DEPRECATED;
	public bool BoolInstanceOnly;
	public bool BoolDefaultsOnly;
	public bool BoolMutable;
}
