#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSelectors/PCGMeshSelectorWeightedByCategory.h")]
public partial class UPCGMeshSelectorWeightedByCategory : UPCGMeshSelectorBase {
// PCGMeshSelectorWeightedByCategory
	public sbyte CategoryAttribute;
	public TArray<FPCGWeightedByCategoryEntryList> Entries;
	public bool bUseAttributeMaterialOverrides;
	public TArray<sbyte> MaterialOverrideAttributes;
}
