#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeoReferencingBFL.h")]
///<summary>Blueprint function library to convert geospatial coordinates to text</summary>
public partial class UGeoReferencingBFL : UBlueprintFunctionLibrary {
// GeoReferencingBFL
	public sbyte ToFullText(FVector CartesianCoordinates,int IntegralDigits=3,sbyte ReturnValue) { return default; }
	public sbyte ToCompactText(FVector CartesianCoordinates,int IntegralDigits=3,sbyte ReturnValue) { return default; }
	public void ToSeparateTexts(FVector CartesianCoordinates,sbyte OutX,sbyte OutY,sbyte OutZ,int IntegralDigits=3) {}
}
