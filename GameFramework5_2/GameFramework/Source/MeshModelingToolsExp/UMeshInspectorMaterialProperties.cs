#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshInspectorTool.h")]
///<summary>material settings for mesh inspector tool</summary>
public partial class UMeshInspectorMaterialProperties : UInteractiveToolPropertySet {
// MeshInspectorMaterialProperties
	public EMeshInspectorMaterialMode MaterialMode;
	public float CheckerDensity;
	public UMaterialInterface OverrideMaterial;
	public sbyte UVChannel;
	public TArray<sbyte> UVChannelNamesList;
	public TArray<sbyte> GetUVChannelNamesFunc(TArray<sbyte> ReturnValue) { return default; }
	public bool bFlatShading;
	public FLinearColor Color;
	public double Opacity;
	public FLinearColor TransparentMaterialColor;
	public bool bTwoSided;
	public UMaterialInstanceDynamic CheckerMaterial;
	public UMaterialInstanceDynamic ActiveCustomMaterial;
}
