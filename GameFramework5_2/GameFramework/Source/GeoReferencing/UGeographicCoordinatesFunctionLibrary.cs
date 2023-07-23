#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeographicCoordinates.h")]
public partial class UGeographicCoordinatesFunctionLibrary : UBlueprintFunctionLibrary {
// GeographicCoordinatesFunctionLibrary
	public sbyte ToFullText(FGeographicCoordinates GeographicCoordinates,int IntegralDigitsLatLon=8,int IntegralDigitsAlti=2,bool bAsDMS=false,sbyte ReturnValue) { return default; }
	public sbyte ToCompactText(FGeographicCoordinates GeographicCoordinates,int IntegralDigitsLatLon=8,int IntegralDigitsAlti=2,bool bAsDMS=false,sbyte ReturnValue) { return default; }
	public void ToSeparateTexts(FGeographicCoordinates GeographicCoordinates,sbyte OutLatitude,sbyte OutLongitude,sbyte OutAltitude,int IntegralDigitsLatLon=8,int IntegralDigitsAlti=2,bool bAsDMS=false) {}
	public void ToFloatApproximation(FGeographicCoordinates GeographicCoordinates,float OutLatitude,float OutLongitude,float OutAltitude) {}
	public FGeographicCoordinates MakeGeographicCoordinatesApproximation(float InLatitude,float InLongitude,float InAltitude,FGeographicCoordinates ReturnValue) { return default; }
	public FGeographicCoordinates MakeGeographicCoordinates(FVector LatLongAltVector,FGeographicCoordinates ReturnValue) { return default; }
	public void ToLatLongAltVector(FGeographicCoordinates GeographicCoordinates,FVector OutLatLongAltVector) {}
}
