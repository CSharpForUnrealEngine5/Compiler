#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/CustomizableObjectEditor.h")]
///<summary>Statistics for the Texture Analyzer</summary>
public partial class UCustomizableObjectEditorTextureStats : UObject {
// CustomizableObjectEditorTextureStats
	public sbyte TextureName;
	public sbyte TextureParameterName;
	public sbyte MaterialName;
	public sbyte MaterialParameterName;
	public UTexture Texture;
	public UMaterialInterface Material;
	public UMaterialInterface ParentMaterial;
	public int ResolutionX;
	public int ResolutionY;
	public sbyte Size;
	public byte Format;
	public int LODBias;
	public sbyte IsStreamed;
	public byte LODGroup;
	public int Component;
}
