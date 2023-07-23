#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorFilterLibrary.h")]
///<summary>Utility class to filter a list of objects. Object should be in the World Editor.</summary>
public partial class UEditorFilterLibrary : UBlueprintFunctionLibrary {
// EditorFilterLibrary
	public TArray<UObject> ByClass(TArray<UObject> TargetArray,UClass ObjectClass,EEditorScriptingFilterType FilterType=EEditorScriptingFilterType,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> ByIDName(TArray<UObject> TargetArray,sbyte NameSubString,EEditorScriptingStringMatchType StringMatch=EEditorScriptingStringMatchType,EEditorScriptingFilterType FilterType=EEditorScriptingFilterType,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> ByActorLabel(TArray<UObject> TargetArray,sbyte NameSubString,EEditorScriptingStringMatchType StringMatch=EEditorScriptingStringMatchType,EEditorScriptingFilterType FilterType=EEditorScriptingFilterType,bool bIgnoreCase=true,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> ByActorTag(TArray<UObject> TargetArray,sbyte Tag,EEditorScriptingFilterType FilterType=EEditorScriptingFilterType,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> ByLayer(TArray<UObject> TargetArray,sbyte LayerName,EEditorScriptingFilterType FilterType=EEditorScriptingFilterType,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> ByLevelName(TArray<UObject> TargetArray,sbyte LevelName,EEditorScriptingFilterType FilterType=EEditorScriptingFilterType,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> BySelection(TArray<UObject> TargetArray,EEditorScriptingFilterType FilterType=EEditorScriptingFilterType,TArray<UObject> ReturnValue) { return default; }
}
