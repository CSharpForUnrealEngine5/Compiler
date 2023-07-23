#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertySets/WeightMapSetProperties.h")]
///<summary>Basic Tool Property Set that allows for selecting from a list of FNames (that we assume are Weight Maps)</summary>
public partial class UWeightMapSetProperties : UInteractiveToolPropertySet {
// WeightMapSetProperties
	public sbyte WeightMap;
	public TArray<sbyte> GetWeightMapsFunc(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> WeightMapsList;
	public bool bInvertWeightMap;
}
