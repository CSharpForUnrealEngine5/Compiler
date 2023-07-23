#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeToolCommon.h")]
public partial class UBakeMultiTexture2DProperties : UInteractiveToolPropertySet {
// BakeMultiTexture2DProperties
	public TArray<UTexture2D> MaterialIDSourceTextures;
	public sbyte UVLayer;
	public TArray<sbyte> GetUVLayerNamesFunc(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> UVLayerNamesList;
	public TArray<UTexture2D> AllSourceTextures;
}
