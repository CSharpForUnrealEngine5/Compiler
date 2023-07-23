#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenuEntryScript.h")]
public partial class UToolMenuEntryScript : UObject {
// ToolMenuEntryScript
	public void Execute(FToolMenuContext Context) {}
	public bool CanExecute(FToolMenuContext Context,bool ReturnValue) { return default; }
	public ECheckBoxState GetCheckState(FToolMenuContext Context,ECheckBoxState ReturnValue) { return default; }
	public bool IsVisible(FToolMenuContext Context,bool ReturnValue) { return default; }
	public sbyte GetLabel(FToolMenuContext Context,sbyte ReturnValue) { return default; }
	public sbyte GetToolTip(FToolMenuContext Context,sbyte ReturnValue) { return default; }
	public FScriptSlateIcon GetIcon(FToolMenuContext Context,FScriptSlateIcon ReturnValue) { return default; }
	public void ConstructMenuEntry(UObject Menu,sbyte SectionName,FToolMenuContext Context) {}
	public void RegisterMenuEntry() {}
	public void InitEntry(sbyte OwnerName,sbyte Menu,sbyte Section,sbyte Name,sbyte Label=FText,sbyte ToolTip=FText) {}
	public FToolMenuEntryScriptData Data;
}
