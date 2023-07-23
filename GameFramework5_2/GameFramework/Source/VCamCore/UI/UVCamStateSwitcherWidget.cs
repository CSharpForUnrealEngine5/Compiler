#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/Switcher/VCamStateSwitcherWidget.h")]
///<summary>A widget that has a set of states you can switch between using SetCurrentState.</summary>
public partial class UVCamStateSwitcherWidget : UVCamWidget {
// VCamStateSwitcherWidget
	public void K2_SetCurrentState(sbyte NewState) {}
	public bool SetCurrentState(sbyte NewState,bool bForceUpdate=false,bool bReinitializeConnections=true,bool ReturnValue) { return default; }
	public sbyte GetCurrentState(sbyte ReturnValue) { return default; }
	public TArray<sbyte> GetStates(TArray<sbyte> ReturnValue) { return default; }
	public bool GetStateInfo(sbyte State,FVCamWidgetConnectionState OutStateInfo,bool ReturnValue) { return default; }
	public FChangeConnectionStateEvent OnPreStateChanged;
	public FChangeConnectionStateEvent OnPostStateChanged;
	public TMap<sbyte,FVCamWidgetConnectionState> States;
	public sbyte CurrentState;
}
