#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenuEntry.h")]
public partial struct FToolMenuEntry {
// ToolMenuEntry
	public sbyte Name;
	public FToolMenuOwner Owner;
	public EMultiBlockType Type;
	public EUserInterfaceActionType UserInterfaceActionType;
	public sbyte TutorialHighlightName;
	public FToolMenuInsert InsertPosition;
	public bool bShouldCloseWindowAfterMenuSelection;
	public UToolMenuEntryScript ScriptObject;
	public sbyte StyleNameOverride;
	public bool bCommandIsKeybindOnly;
}
