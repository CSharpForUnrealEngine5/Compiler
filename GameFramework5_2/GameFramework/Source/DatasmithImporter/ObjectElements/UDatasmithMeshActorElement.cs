#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
///<summary>* UDatasmithMeshActorElement</summary>
public partial class UDatasmithMeshActorElement : UDatasmithActorElement {
// DatasmithMeshActorElement
	public void AddMaterialOverride(UObject Material) {}
	public int GetMaterialOverridesCount(int ReturnValue) { return default; }
	public TArray<UObject> GetMaterials(TArray<UObject> ReturnValue) { return default; }
	public void RemoveMaterialOverride(UObject Material) {}
	public sbyte GetStaticMeshPathName(sbyte ReturnValue) { return default; }
	public void SetStaticMeshPathName(sbyte InStaticMeshName) {}
	public UObject GetMeshElement(UObject ReturnValue) { return default; }
	public FVector GetBoundingBoxSize(FVector ReturnValue) { return default; }
}
