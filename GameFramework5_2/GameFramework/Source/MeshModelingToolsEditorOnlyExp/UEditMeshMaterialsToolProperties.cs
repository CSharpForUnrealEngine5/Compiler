#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditMeshMaterialsTool.h")]
public partial class UEditMeshMaterialsToolProperties : UInteractiveToolPropertySet {
// EditMeshMaterialsToolProperties
	public sbyte ActiveMaterial;
	public TArray<sbyte> GetMaterialNamesFunc(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> MaterialNamesList;
	public TArray<UMaterialInterface> Materials;
}
