#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSelectors/PCGMeshSelectorWeightedByCategory.h")]
public partial struct FPCGWeightedByCategoryEntryList {
// PCGWeightedByCategoryEntryList
	public sbyte CategoryEntry;
	public bool IsDefault;
	public TArray<FPCGMeshSelectorWeightedEntry> WeightedMeshEntries;
}
