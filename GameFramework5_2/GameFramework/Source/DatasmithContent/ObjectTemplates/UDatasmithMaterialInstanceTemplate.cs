#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectTemplates/DatasmithMaterialInstanceTemplate.h")]
///<summary>Applies material instance data to a material instance if it hasn't changed since the last time we've applied a template.</summary>
public partial class UDatasmithMaterialInstanceTemplate : UDatasmithObjectTemplate {
// DatasmithMaterialInstanceTemplate
	public TSoftObjectPtr<UMaterialInterface> ParentMaterial;
	public TMap<sbyte,float> ScalarParameterValues;
	public TMap<sbyte,FLinearColor> VectorParameterValues;
	public TMap<sbyte,TSoftObjectPtr<UTexture>> TextureParameterValues;
	public FDatasmithStaticParameterSetTemplate StaticParameters;
}
