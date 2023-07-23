#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Groups/CommonButtonGroupBase.h")]
///<summary>Manages an arbitrary collection of CommonButton widgets.</summary>
public partial class UCommonButtonGroupBase : UCommonWidgetGroupBase {
// CommonButtonGroupBase
	public void SetSelectionRequired(bool bRequireSelection) {}
	public void DeselectAll() {}
	public void SelectNextButton(bool bAllowWrap=true) {}
	public void SelectPreviousButton(bool bAllowWrap=true) {}
	public void SelectButtonAtIndex(int ButtonIndex,bool bAllowSound=true) {}
	public int GetSelectedButtonIndex(int ReturnValue) { return default; }
	public int GetHoveredButtonIndex(int ReturnValue) { return default; }
	public int FindButtonIndex(UObject ButtonToFind,int ReturnValue) { return default; }
	public FSimpleButtonBaseGroupDelegate OnSelectedButtonBaseChanged;
	public FSimpleButtonBaseGroupDelegate OnHoveredButtonBaseChanged;
	public FSimpleButtonBaseGroupDelegate OnButtonBaseClicked;
	public FSimpleButtonBaseGroupDelegate OnButtonBaseDoubleClicked;
	public FOnSelectionCleared OnSelectionCleared;
	public UObject GetButtonBaseAtIndex(int Index,UObject ReturnValue) { return default; }
	public UObject GetSelectedButtonBase(UObject ReturnValue) { return default; }
	public bool HasAnyButtons(bool ReturnValue) { return default; }
	public int GetButtonCount(int ReturnValue) { return default; }
	public bool bSelectionRequired;
	public void OnSelectionStateChangedBase(UObject BaseButton,bool bIsSelected) {}
	public void OnHandleButtonBaseClicked(UObject BaseButton) {}
	public void OnHandleButtonBaseDoubleClicked(UObject BaseButton) {}
	public void OnButtonBaseHovered(UObject BaseButton) {}
	public void OnButtonBaseUnhovered(UObject BaseButton) {}
}
