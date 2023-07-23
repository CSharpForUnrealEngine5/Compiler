#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetArrayLibrary.h")]
public partial class UKismetArrayLibrary : UBlueprintFunctionLibrary {
// KismetArrayLibrary
	public int Array_Add(TArray<int> TargetArray,int NewItem,int ReturnValue) { return default; }
	public int Array_AddUnique(TArray<int> TargetArray,int NewItem,int ReturnValue) { return default; }
	public void Array_Shuffle(TArray<int> TargetArray) {}
	public bool Array_Identical(TArray<int> ArrayA,TArray<int> ArrayB,bool ReturnValue) { return default; }
	public void Array_Append(TArray<int> TargetArray,TArray<int> SourceArray) {}
	public void Array_Insert(TArray<int> TargetArray,int NewItem,int Index) {}
	public void Array_Remove(TArray<int> TargetArray,int IndexToRemove) {}
	public bool Array_RemoveItem(TArray<int> TargetArray,int Item,bool ReturnValue) { return default; }
	public void Array_Clear(TArray<int> TargetArray) {}
	public void Array_Resize(TArray<int> TargetArray,int Size) {}
	public void Array_Reverse(TArray<int> TargetArray) {}
	public int Array_Length(TArray<int> TargetArray,int ReturnValue) { return default; }
	public bool Array_IsEmpty(TArray<int> TargetArray,bool ReturnValue) { return default; }
	public bool Array_IsNotEmpty(TArray<int> TargetArray,bool ReturnValue) { return default; }
	public int Array_LastIndex(TArray<int> TargetArray,int ReturnValue) { return default; }
	public void Array_Get(TArray<int> TargetArray,int Index,int Item) {}
	public void Array_Set(TArray<int> TargetArray,int Index,int Item,bool bSizeToFit) {}
	public void Array_Swap(TArray<int> TargetArray,int FirstIndex,int SecondIndex) {}
	public int Array_Find(TArray<int> TargetArray,int ItemToFind,int ReturnValue) { return default; }
	public bool Array_Contains(TArray<int> TargetArray,int ItemToFind,bool ReturnValue) { return default; }
	public void FilterArray(TArray<UObject> TargetArray,UClass FilterClass,TArray<UObject> FilteredArray) {}
	public void SetArrayPropertyByName(UObject Object,sbyte PropertyName,TArray<int> Value) {}
	public bool Array_IsValidIndex(TArray<int> TargetArray,int IndexToTest,bool ReturnValue) { return default; }
	public void Array_Random(TArray<int> TargetArray,int OutItem,int OutIndex) {}
	public void Array_RandomFromStream(TArray<int> TargetArray,FRandomStream RandomStream,int OutItem,int OutIndex) {}
}
