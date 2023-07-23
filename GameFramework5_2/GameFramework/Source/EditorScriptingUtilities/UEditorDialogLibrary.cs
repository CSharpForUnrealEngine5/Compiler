#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorDialogLibrary.h")]
///<summary>Utility class to create simple pop-up dialogs to notify the user of task completion,</summary>
public partial class UEditorDialogLibrary : UBlueprintFunctionLibrary {
// EditorDialogLibrary
	public byte ShowMessage(sbyte Title,sbyte Message,byte MessageType,byte DefaultValue=EAppReturnType,byte ReturnValue) { return default; }
	public bool ShowSuppressableWarningDialog(sbyte Title,sbyte Message,sbyte InIniSettingName,sbyte InIniSettingFileNameOverride=TEXT,bool bDefaultValue=true,bool ReturnValue) { return default; }
	public bool ShowObjectDetailsView(sbyte Title,UObject InOutObject,FEditorDialogLibraryObjectDetailsViewOptions Options=FEditorDialogLibraryObjectDetailsViewOptions,bool ReturnValue) { return default; }
	public bool ShowObjectsDetailsView(sbyte Title,TArray<UObject> InOutObjects,FEditorDialogLibraryObjectDetailsViewOptions Options=FEditorDialogLibraryObjectDetailsViewOptions,bool ReturnValue) { return default; }
}
