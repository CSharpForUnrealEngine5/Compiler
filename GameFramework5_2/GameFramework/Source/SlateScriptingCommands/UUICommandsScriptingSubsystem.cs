#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UICommandsScriptingSubsystem.h")]
///<summary>UEditorInputSubsystem</summary>
public partial class UUICommandsScriptingSubsystem : UEngineSubsystem {
// UICommandsScriptingSubsystem
	public bool RegisterCommand(FScriptingCommandInfo CommandInfo,FExecuteCommand OnExecuteCommand,bool bOverrideExisting=false,bool ReturnValue) { return default; }
	public bool RegisterCommandChecked(FScriptingCommandInfo CommandInfo,FExecuteCommand OnExecuteCommand,FCanExecuteCommand OnCanExecuteCommand,bool bOverrideExisting=false,bool ReturnValue) { return default; }
	public bool UnregisterCommand(FScriptingCommandInfo CommandInfo,bool ReturnValue) { return default; }
	public bool IsCommandRegistered(FScriptingCommandInfo CommandInfo,bool bCheckInputChord=true,bool ReturnValue) { return default; }
	public TArray<FScriptingCommandInfo> GetRegisteredCommands(TArray<FScriptingCommandInfo> ReturnValue) { return default; }
	public bool CanExecuteCommands(bool ReturnValue) { return default; }
	public void SetCanExecuteCommands(bool bShouldExecuteCommands) {}
	public void UnregisterAllSets() {}
	public bool RegisterCommandSet(sbyte SetName,bool ReturnValue) { return default; }
	public bool IsCommandSetRegistered(sbyte SetName,bool ReturnValue) { return default; }
	public bool UnregisterCommandSet(sbyte SetName,bool ReturnValue) { return default; }
	public void SetCanSetExecuteCommands(sbyte SetName,bool bShouldExecuteCommands) {}
	public bool CanSetExecuteCommands(sbyte SetName,bool ReturnValue) { return default; }
	public TArray<sbyte> GetAvailableContexts(TArray<sbyte> ReturnValue) { return default; }
	public bool IsContextRegistered(sbyte ContextName,bool ReturnValue) { return default; }
	public int GetBindingCountForContext(sbyte ContextName,int ReturnValue) { return default; }
	public bool IsInputChordMapped(sbyte ContextName,FInputChord InputChord,bool ReturnValue) { return default; }
	public void HandleExecuteAction(FExecuteCommand OnExecuteAction,FScriptingCommandInfo CommandInfo) {}
	public bool HandleCanExecuteAction(FCanExecuteCommand OnCanExecuteAction,FScriptingCommandInfo CommandInfo,bool ReturnValue) { return default; }
	public bool DefaultCanExecuteAction(sbyte SetName,bool ReturnValue) { return default; }
}
