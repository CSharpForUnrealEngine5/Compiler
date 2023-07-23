#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonTabListWidgetBase.h")]
///<summary>Base class for a list of selectable tabs that correspondingly activate and display an arbitrary widget in a linked switcher</summary>
public partial class UCommonTabListWidgetBase : UCommonUserWidget {
// CommonTabListWidgetBase
	public void FOnTabSelected(sbyte TabId) {}
	public FOnTabSelected OnTabSelected;
	public void FOnTabButtonCreation(sbyte TabId,UObject TabButton) {}
	public FOnTabButtonCreation OnTabButtonCreation;
	public void FOnTabButtonRemoval(sbyte TabId,UObject TabButton) {}
	public FOnTabButtonRemoval OnTabButtonRemoval;
	public void FOnTabListRebuilt() {}
	public FOnTabListRebuilt OnTabListRebuilt;
	public sbyte GetActiveTab(sbyte ReturnValue) { return default; }
	public void SetLinkedSwitcher(UObject CommonSwitcher) {}
	public UObject GetLinkedSwitcher(UObject ReturnValue) { return default; }
	public bool RegisterTab(sbyte TabNameID,UClass ButtonWidgetType,UObject ContentWidget,int TabIndex=-1,bool ReturnValue) { return default; }
	public bool RemoveTab(sbyte TabNameID,bool ReturnValue) { return default; }
	public void RemoveAllTabs() {}
	public int GetTabCount(int ReturnValue) { return default; }
	public bool SelectTabByID(sbyte TabNameID,bool bSuppressClickFeedback=false,bool ReturnValue) { return default; }
	public sbyte GetSelectedTabId(sbyte ReturnValue) { return default; }
	public sbyte GetTabIdAtIndex(int Index,sbyte ReturnValue) { return default; }
	public void SetTabVisibility(sbyte TabNameID,ESlateVisibility NewVisibility) {}
	public void SetTabEnabled(sbyte TabNameID,bool bEnable) {}
	public void SetTabInteractionEnabled(sbyte TabNameID,bool bEnable) {}
	public void DisableTabWithReason(sbyte TabNameID,sbyte Reason) {}
	public void SetListeningForInput(bool bShouldListen) {}
	public UObject GetTabButtonBaseByID(sbyte TabNameID,UObject ReturnValue) { return default; }
	public void HandlePreLinkedSwitcherChanged_BP() {}
	public void HandlePostLinkedSwitcherChanged_BP() {}
	public void HandleTabCreation(sbyte TabNameID,UObject TabButton) {}
	public void HandleTabRemoval(sbyte TabNameID,UObject TabButton) {}
	public FDataTableRowHandle NextTabInputActionData;
	public FDataTableRowHandle PreviousTabInputActionData;
	public UInputAction NextTabEnhancedInputAction;
	public UInputAction PreviousTabEnhancedInputAction;
	public bool bAutoListenForInput;
	public bool bDeferRebuildingTabList;
	public void HandleTabButtonSelected(UObject SelectedTabButton,int ButtonIndex) {}
	public void HandlePreviousTabInputAction(bool bPassthrough) {}
	public void HandleNextTabInputAction(bool bPassthrough) {}
	public TWeakObjectPtr<UCommonAnimatedSwitcher> LinkedSwitcher;
	public UCommonButtonGroupBase TabButtonGroup;
	public TMap<sbyte,FCommonRegisteredTabInfo> RegisteredTabsByID;
}
