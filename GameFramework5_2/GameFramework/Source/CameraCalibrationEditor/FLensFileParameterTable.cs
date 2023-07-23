#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensFileExchangeFormat.h")]
public partial struct FLensFileParameterTable {
// LensFileParameterTable
	public sbyte ParameterName;
	public TArray<sbyte> Header;
	public TArray<FLensFileParameterTableRow> Data;
}
