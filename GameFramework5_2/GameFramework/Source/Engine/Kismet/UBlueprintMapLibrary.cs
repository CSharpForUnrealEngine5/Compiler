#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/BlueprintMapLibrary.h")]
public partial class UBlueprintMapLibrary : UBlueprintFunctionLibrary {
// BlueprintMapLibrary
	public void Map_Add(TMap<int,int> TargetMap,int Key,int Value) {}
	public bool Map_Remove(TMap<int,int> TargetMap,int Key,bool ReturnValue) { return default; }
	public bool Map_Find(TMap<int,int> TargetMap,int Key,int Value,bool ReturnValue) { return default; }
	public bool Map_Contains(TMap<int,int> TargetMap,int Key,bool ReturnValue) { return default; }
	public void Map_Keys(TMap<int,int> TargetMap,TArray<int> Keys) {}
	public void Map_Values(TMap<int,int> TargetMap,TArray<int> Values) {}
	public int Map_Length(TMap<int,int> TargetMap,int ReturnValue) { return default; }
	public bool Map_IsEmpty(TMap<int,int> TargetMap,bool ReturnValue) { return default; }
	public bool Map_IsNotEmpty(TMap<int,int> TargetMap,bool ReturnValue) { return default; }
	public void Map_Clear(TMap<int,int> TargetMap) {}
	public void SetMapPropertyByName(UObject Object,sbyte PropertyName,TMap<int,int> Value) {}
}
