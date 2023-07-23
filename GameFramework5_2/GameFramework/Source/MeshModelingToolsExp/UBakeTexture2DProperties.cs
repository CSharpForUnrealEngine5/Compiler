#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeToolCommon.h")]
public partial class UBakeTexture2DProperties : UInteractiveToolPropertySet {
// BakeTexture2DProperties
	public UTexture2D SourceTexture;
	public sbyte UVLayer;
	public TArray<sbyte> GetUVLayerNamesFunc(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> UVLayerNamesList;
}
