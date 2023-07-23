#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConsoleVariablesAsset.h")]
///<summary>An asset used to track collections of console variables that can be recalled and edited using the Console Variables Editor.</summary>
public partial class UConsoleVariablesAsset : UObject {
// ConsoleVariablesAsset
	public void SetVariableCollectionDescription(sbyte InVariableCollectionDescription) {}
	public sbyte GetVariableCollectionDescription(sbyte ReturnValue) { return default; }
	public TArray<FConsoleVariablesEditorAssetSaveData> GetSavedCommands(TArray<FConsoleVariablesEditorAssetSaveData> ReturnValue) { return default; }
	public TArray<sbyte> GetSavedCommandsAsStringArray(bool bOnlyIncludeChecked=false,TArray<sbyte> ReturnValue) { return default; }
	public sbyte GetSavedCommandsAsCommaSeparatedString(bool bOnlyIncludeChecked=false,sbyte ReturnValue) { return default; }
	public void ExecuteSavedCommands(UObject WorldContextObject,bool bOnlyIncludeChecked=false) {}
	public void ReplaceSavedCommands(TArray<FConsoleVariablesEditorAssetSaveData> Replacement) {}
	public int GetSavedCommandsCount(int ReturnValue) { return default; }
	public bool FindSavedDataByCommandString(sbyte InCommandString,FConsoleVariablesEditorAssetSaveData OutValue,ESearchCase SearchCase=ESearchCase,bool ReturnValue) { return default; }
	public void AddOrSetConsoleObjectSavedData(FConsoleVariablesEditorAssetSaveData InData) {}
	public bool RemoveConsoleVariable(sbyte InCommandString,bool ReturnValue) { return default; }
	public void CopyFrom(UObject InAssetToCopy) {}
	public sbyte VariableCollectionDescription;
	public TArray<FConsoleVariablesEditorAssetSaveData> SavedCommands;
}
