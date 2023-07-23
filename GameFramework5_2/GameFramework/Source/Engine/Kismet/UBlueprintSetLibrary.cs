#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/BlueprintSetLibrary.h")]
public partial class UBlueprintSetLibrary : UBlueprintFunctionLibrary {
// BlueprintSetLibrary
	public void Set_Add(TSet<int> TargetSet,int NewItem) {}
	public void Set_AddItems(TSet<int> TargetSet,TArray<int> NewItems) {}
	public bool Set_Remove(TSet<int> TargetSet,int Item,bool ReturnValue) { return default; }
	public bool Set_IsEmpty(TSet<int> TargetSet,bool ReturnValue) { return default; }
	public bool Set_IsNotEmpty(TSet<int> TargetSet,bool ReturnValue) { return default; }
	public void Set_RemoveItems(TSet<int> TargetSet,TArray<int> Items) {}
	public void Set_ToArray(TSet<int> A,TArray<int> Result) {}
	public void Set_Clear(TSet<int> TargetSet) {}
	public int Set_Length(TSet<int> TargetSet,int ReturnValue) { return default; }
	public bool Set_Contains(TSet<int> TargetSet,int ItemToFind,bool ReturnValue) { return default; }
	public void Set_Intersection(TSet<int> A,TSet<int> B,TSet<int> Result) {}
	public void Set_Union(TSet<int> A,TSet<int> B,TSet<int> Result) {}
	public void Set_Difference(TSet<int> A,TSet<int> B,TSet<int> Result) {}
	public void SetSetPropertyByName(UObject Object,sbyte PropertyName,TSet<int> Value) {}
}
