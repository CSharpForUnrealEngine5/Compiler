#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenu.h")]
public partial class UToolMenu : UToolMenuBase {
// ToolMenu
	public void InitMenu(FToolMenuOwner Owner,sbyte Name,sbyte Parent=NAME_None,EMultiBoxType Type=EMultiBoxType) {}
	public void AddSectionScript(sbyte SectionName,sbyte Label=FText,sbyte InsertName=NAME_None,EToolMenuInsertType InsertType=EToolMenuInsertType) {}
	public void AddDynamicSectionScript(sbyte SectionName,UObject Object) {}
	public void AddMenuEntry(sbyte SectionName,FToolMenuEntry Args) {}
	public void AddMenuEntryObject(UObject InObject) {}
	public UObject AddSubMenuScript(sbyte Owner,sbyte SectionName,sbyte Name,sbyte Label,sbyte ToolTip=FText,UObject ReturnValue) { return default; }
	public sbyte MenuName;
	public sbyte MenuParent;
	public sbyte StyleName;
	public sbyte TutorialHighlightName;
	public EMultiBoxType MenuType;
	public bool bShouldCleanupContextOnDestroy;
	public bool bShouldCloseWindowAfterMenuSelection;
	public bool bCloseSelfOnly;
	public bool bSearchable;
	public bool bToolBarIsFocusable;
	public bool bToolBarForceSmallIcons;
	public bool bPreventCustomization;
	public FToolMenuOwner MenuOwner;
	public FToolMenuContext Context;
	public TArray<FToolMenuSection> Sections;
	public UToolMenu SubMenuParent;
	public sbyte SubMenuSourceEntryName;
}
