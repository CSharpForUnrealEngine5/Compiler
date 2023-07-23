#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenus.h")]
public partial class UToolMenus : UObject {
// ToolMenus
	public UObject Get(UObject ReturnValue) { return default; }
	public UObject RegisterMenu(sbyte Name,sbyte Parent=NAME_None,EMultiBoxType Type=EMultiBoxType,bool bWarnIfAlreadyRegistered=true,UObject ReturnValue) { return default; }
	public UObject ExtendMenu(sbyte Name,UObject ReturnValue) { return default; }
	public UObject FindMenu(sbyte Name,UObject ReturnValue) { return default; }
	public bool IsMenuRegistered(sbyte Name,bool ReturnValue) { return default; }
	public bool RefreshMenuWidget(sbyte Name,bool ReturnValue) { return default; }
	public void RefreshAllWidgets() {}
	public bool AddMenuEntryObject(UObject MenuEntryObject,bool ReturnValue) { return default; }
	public void UnregisterOwnerByName(sbyte InOwnerName) {}
	public void SetSectionLabel(sbyte MenuName,sbyte SectionName,sbyte Label) {}
	public void SetSectionPosition(sbyte MenuName,sbyte SectionName,sbyte OtherSectionName,EToolMenuInsertType PositionType) {}
	public void RemoveEntry(sbyte MenuName,sbyte Section,sbyte Name) {}
	public void RemoveSection(sbyte MenuName,sbyte Section) {}
	public void RemoveMenu(sbyte MenuName) {}
	public UObject FindContext(FToolMenuContext InContext,UClass InClass,UObject ReturnValue) { return default; }
	public TArray<FCustomizedToolMenu> CustomizedMenus;
	public TMap<sbyte,sbyte> MenuSubstitutionsDuringGenerate;
	public TMap<sbyte,UToolMenu> Menus;
}
