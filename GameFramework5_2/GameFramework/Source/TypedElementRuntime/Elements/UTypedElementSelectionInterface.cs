#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Interfaces/TypedElementSelectionInterface.h")]
public partial class UTypedElementSelectionInterface : UInterface {
// TypedElementSelectionInterface
	public bool IsElementSelected(FScriptTypedElementHandle InElementHandle,FScriptTypedElementListProxy InSelectionSet,FTypedElementIsSelectedOptions InSelectionOptions,bool ReturnValue) { return default; }
	public bool CanSelectElement(FScriptTypedElementHandle InElementHandle,FTypedElementSelectionOptions InSelectionOptions,bool ReturnValue) { return default; }
	public bool CanDeselectElement(FScriptTypedElementHandle InElementHandle,FTypedElementSelectionOptions InSelectionOptions,bool ReturnValue) { return default; }
	public bool SelectElement(FScriptTypedElementHandle InElementHandle,FScriptTypedElementListProxy InSelectionSet,FTypedElementSelectionOptions InSelectionOptions,bool ReturnValue) { return default; }
	public bool DeselectElement(FScriptTypedElementHandle InElementHandle,FScriptTypedElementListProxy InSelectionSet,FTypedElementSelectionOptions InSelectionOptions,bool ReturnValue) { return default; }
	public bool AllowSelectionModifiers(FScriptTypedElementHandle InElementHandle,FScriptTypedElementListProxy InSelectionSet,bool ReturnValue) { return default; }
	public FScriptTypedElementHandle GetSelectionElement(FScriptTypedElementHandle InElementHandle,FScriptTypedElementListProxy InCurrentSelection,ETypedElementSelectionMethod InSelectionMethod,FScriptTypedElementHandle ReturnValue) { return default; }
}
