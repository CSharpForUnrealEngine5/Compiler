#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithContentBlueprintLibrary.h")]
public partial class UDatasmithContentBlueprintLibrary : UBlueprintFunctionLibrary {
// DatasmithContentBlueprintLibrary
	public UObject GetDatasmithUserData(UObject Object,UObject ReturnValue) { return default; }
	public sbyte GetDatasmithUserDataValueForKey(UObject Object,sbyte Key,bool bPartialMatchKey=false,sbyte ReturnValue) { return default; }
	public TArray<sbyte> GetDatasmithUserDataValuesForKey(UObject Object,sbyte Key,bool bPartialMatchKey=false,TArray<sbyte> ReturnValue) { return default; }
	public void GetDatasmithUserDataKeysAndValuesForValue(UObject Object,sbyte StringToMatch,TArray<sbyte> OutKeys,TArray<sbyte> OutValues) {}
	public void GetAllDatasmithUserData(UClass ObjectClass,TArray<UObject> OutUserData) {}
	public void GetAllObjectsAndValuesForKey(sbyte Key,UClass ObjectClass,TArray<UObject> OutObjects,TArray<sbyte> OutValues) {}
}
