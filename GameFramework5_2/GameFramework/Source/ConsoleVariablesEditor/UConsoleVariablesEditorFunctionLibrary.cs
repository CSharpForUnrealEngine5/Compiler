#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConsoleVariablesEditorFunctionLibrary.h")]
///<summary>An asset used to track collections of console variables that can be recalled and edited using the Console Variables Editor.</summary>
public partial class UConsoleVariablesEditorFunctionLibrary : UBlueprintFunctionLibrary {
// ConsoleVariablesEditorFunctionLibrary
	public UObject GetCurrentlyLoadedPreset(UObject ReturnValue) { return default; }
	public void LoadPresetIntoConsoleVariablesEditor(UObject InAsset) {}
	public bool CopyCurrentListToAsset(UObject InAsset,bool ReturnValue) { return default; }
	public bool AddValidatedCommandToCurrentPreset(sbyte NewCommand,bool ReturnValue) { return default; }
	public bool RemoveCommandFromCurrentPreset(sbyte NewCommand,bool ReturnValue) { return default; }
	public bool GetListOfCommandsFromPreset(UObject InAsset,TArray<sbyte> OutCommandList,bool ReturnValue) { return default; }
	public bool SetConsoleVariableByName_Float(sbyte InCommandName,float InValue,bool ReturnValue) { return default; }
	public bool SetConsoleVariableByName_Bool(sbyte InCommandName,bool InValue,bool ReturnValue) { return default; }
	public bool SetConsoleVariableByName_Int(sbyte InCommandName,int InValue,bool ReturnValue) { return default; }
	public bool SetConsoleVariableByName_String(sbyte InCommandName,sbyte InValue,bool ReturnValue) { return default; }
	public bool GetConsoleVariableStringValue(sbyte InCommandName,sbyte OutValue,bool ReturnValue) { return default; }
	public bool GetConsoleVariableSourceByName(sbyte InCommandName,sbyte OutValue,bool ReturnValue) { return default; }
	public bool GetEnableMultiUserCVarSync(bool ReturnValue) { return default; }
	public void SetEnableMultiUserCVarSync(bool bNewSetting) {}
}
