#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepFilterLibrary.h")]
public partial class UDataprepFilterLibrary : UBlueprintFunctionLibrary {
// DataprepFilterLibrary
	public TArray<UObject> FilterByClass(TArray<UObject> TargetArray,UClass ObjectClass,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> FilterByName(TArray<UObject> TargetArray,sbyte NameSubString,EEditorScriptingStringMatchType StringMatch=EEditorScriptingStringMatchType,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> FilterBySize(TArray<UObject> TargetArray,EDataprepSizeSource SizeSource,EDataprepSizeFilterMode FilterMode,float Threshold,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> FilterByTag(TArray<UObject> TargetArray,sbyte Tag,TArray<UObject> ReturnValue) { return default; }
}
