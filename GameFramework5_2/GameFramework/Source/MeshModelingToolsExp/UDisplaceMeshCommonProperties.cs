#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplaceMeshTool.h")]
///<summary>The basic set of properties shared by (more or less) all DisplacementTypes.</summary>
public partial class UDisplaceMeshCommonProperties : UInteractiveToolPropertySet {
// DisplaceMeshCommonProperties
	public EDisplaceMeshToolDisplaceType DisplacementType;
	public float DisplaceIntensity;
	public int RandomSeed;
	public EDisplaceMeshToolSubdivisionType SubdivisionType;
	public int Subdivisions;
	public sbyte WeightMap;
	public TArray<sbyte> GetWeightMapsFunc(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> WeightMapsList;
	public bool bInvertWeightMap;
	public bool bShowWireframe;
	public bool bDisableSizeWarning;
}
