#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenusBlueprintLibrary.h")]
public partial class UToolMenuEntryExtensions : UObject {
// ToolMenuEntryExtensions
	public FScriptSlateIcon MakeScriptSlateIcon(sbyte StyleSetName,sbyte StyleName,sbyte SmallStyleName=NAME_None,FScriptSlateIcon ReturnValue) { return default; }
	public void BreakScriptSlateIcon(FScriptSlateIcon InValue,sbyte StyleSetName,sbyte StyleName,sbyte SmallStyleName) {}
	public FToolMenuStringCommand MakeStringCommand(EToolMenuStringCommandType Type,sbyte CustomType,sbyte String,FToolMenuStringCommand ReturnValue) { return default; }
	public void BreakStringCommand(FToolMenuStringCommand InValue,EToolMenuStringCommandType Type,sbyte CustomType,sbyte String) {}
	public FToolMenuOwner MakeToolMenuOwner(sbyte Name,FToolMenuOwner ReturnValue) { return default; }
	public void BreakToolMenuOwner(FToolMenuOwner InValue,sbyte Name) {}
	public void SetLabel(FToolMenuEntry Target,sbyte Label) {}
	public sbyte GetLabel(FToolMenuEntry Target,sbyte ReturnValue) { return default; }
	public void SetToolTip(FToolMenuEntry Target,sbyte ToolTip) {}
	public sbyte GetToolTip(FToolMenuEntry Target,sbyte ReturnValue) { return default; }
	public void SetIcon(FToolMenuEntry Target,sbyte StyleSetName,sbyte StyleName=NAME_None,sbyte SmallStyleName=NAME_None) {}
	public void SetStringCommand(FToolMenuEntry Target,EToolMenuStringCommandType Type,sbyte CustomType,sbyte String) {}
	public FToolMenuEntry InitMenuEntry(sbyte InOwner,sbyte InName,sbyte InLabel,sbyte InToolTip,EToolMenuStringCommandType CommandType,sbyte CustomCommandType,sbyte CommandString,FToolMenuEntry ReturnValue) { return default; }
}
