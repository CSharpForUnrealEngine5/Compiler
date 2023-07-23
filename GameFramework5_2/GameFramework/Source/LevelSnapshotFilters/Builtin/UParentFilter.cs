#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builtin/BlueprintOnly/ParentFilter.h")]
public partial class UParentFilter : ULevelSnapshotFilter {
// ParentFilter
	public void AddChild(UObject Filter) {}
	public bool RemovedChild(UObject Filter,bool ReturnValue) { return default; }
	public UObject CreateChild(UClass Class,UObject ReturnValue) { return default; }
	public TArray<UObject> GetChildren(TArray<UObject> ReturnValue) { return default; }
	public TArray<ULevelSnapshotFilter> Children;
	public TArray<ULevelSnapshotFilter> InstancedChildren;
}
