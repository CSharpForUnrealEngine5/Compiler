#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Framework/TypedElementSelectionSet.h")]
///<summary>A wrapper around an element list that ensures mutation goes via the selection</summary>
public partial class UTypedElementSelectionSet : UObject {
// TypedElementSelectionSet
	public bool ClearSelection(FTypedElementSelectionOptions InSelectionOptions,bool ReturnValue) { return default; }
	public int GetNumSelectedElements(int ReturnValue) { return default; }
	public bool HasSelectedElements(UClass InBaseInterfaceType=nullptr,bool ReturnValue) { return default; }
	public int CountSelectedElements(UClass InBaseInterfaceType=nullptr,int ReturnValue) { return default; }
	public bool HasSelectedObjects(UClass InRequiredClass=nullptr,bool ReturnValue) { return default; }
	public int CountSelectedObjects(UClass InRequiredClass=nullptr,int ReturnValue) { return default; }
	public TArray<UObject> GetSelectedObjects(UClass InRequiredClass=nullptr,TArray<UObject> ReturnValue) { return default; }
	public UObject GetTopSelectedObject(UClass InRequiredClass=nullptr,UObject ReturnValue) { return default; }
	public UObject GetBottomSelectedObject(UClass InRequiredClass=nullptr,UObject ReturnValue) { return default; }
	public FTypedElementSelectionSetState GetCurrentSelectionState(FTypedElementSelectionSetState ReturnValue) { return default; }
	public void RestoreSelectionState(FTypedElementSelectionSetState InSelectionState) {}
	public bool IsElementSelected(FScriptTypedElementHandle InElementHandle,FTypedElementIsSelectedOptions InSelectionOptions,bool ReturnValue) { return default; }
	public bool CanSelectElement(FScriptTypedElementHandle InElementHandle,FTypedElementSelectionOptions InSelectionOptions,bool ReturnValue) { return default; }
	public bool CanDeselectElement(FScriptTypedElementHandle InElementHandle,FTypedElementSelectionOptions InSelectionOptions,bool ReturnValue) { return default; }
	public bool SelectElement(FScriptTypedElementHandle InElementHandle,FTypedElementSelectionOptions InSelectionOptions,bool ReturnValue) { return default; }
	public bool SelectElements(TArray<FScriptTypedElementHandle> InElementHandles,FTypedElementSelectionOptions InSelectionOptions,bool ReturnValue) { return default; }
	public bool DeselectElement(FScriptTypedElementHandle InElementHandle,FTypedElementSelectionOptions InSelectionOptions,bool ReturnValue) { return default; }
	public bool DeselectElements(TArray<FScriptTypedElementHandle> InElementHandles,FTypedElementSelectionOptions InSelectionOptions,bool ReturnValue) { return default; }
	public bool SetSelection(TArray<FScriptTypedElementHandle> InElementHandles,FTypedElementSelectionOptions InSelectionOptions,bool ReturnValue) { return default; }
	public bool AllowSelectionModifiers(FScriptTypedElementHandle InElementHandle,bool ReturnValue) { return default; }
	public FScriptTypedElementHandle GetSelectionElement(FScriptTypedElementHandle InElementHandle,ETypedElementSelectionMethod InSelectionMethod,FScriptTypedElementHandle ReturnValue) { return default; }
	public TArray<FScriptTypedElementHandle> K2_GetSelectedElementHandles(UClass InBaseInterfaceType=nullptr,TArray<FScriptTypedElementHandle> ReturnValue) { return default; }
	public void FOnPreChangeDynamic(UObject SelectionSet) {}
	public FOnPreChangeDynamic OnPreSelectionChange;
	public void FOnChangeDynamic(UObject SelectionSet) {}
	public FOnChangeDynamic OnSelectionChange;
}
