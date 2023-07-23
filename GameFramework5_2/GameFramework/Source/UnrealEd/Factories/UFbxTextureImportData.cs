#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxTextureImportData.h")]
///<summary>Import data and options used when importing any mesh from FBX</summary>
public partial class UFbxTextureImportData : UFbxAssetImportData {
// FbxTextureImportData
	public bool bInvertNormalMaps;
	public EMaterialSearchLocation MaterialSearchLocation;
	public FSoftObjectPath BaseMaterialName;
	public sbyte BaseColorName;
	public sbyte BaseDiffuseTextureName;
	public sbyte BaseNormalTextureName;
	public sbyte BaseEmissiveColorName;
	public sbyte BaseEmmisiveTextureName;
	public sbyte BaseSpecularTextureName;
	public sbyte BaseOpacityTextureName;
}
