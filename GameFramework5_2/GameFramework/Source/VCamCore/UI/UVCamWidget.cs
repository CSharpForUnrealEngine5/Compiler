#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/VCamWidget.h")]
///<summary>* A wrapper widget class that contains a set of VCam Connections</summary>
public partial class UVCamWidget : UUserWidget {
// VCamWidget
	public TMap<sbyte,FVCamConnection> Connections;
	public bool bRegisterForInput;
	public UInputMappingContext InputMappingContext;
	public int InputContextPriority;
	public void FConnectionsReinitializedDelegate_Blueprint() {}
	public FConnectionsReinitializedDelegate_Blueprint OnPostConnectionsReinitializedDelegate_Blueprint;
	public void OnConnectionUpdated(sbyte ConnectionName,bool bDidConnectSuccessfully,sbyte ModifierConnectionPointName,UObject ConnectedModifier,UObject ConnectedAction) {}
	public void PostConnectionsInitialized() {}
	public bool ReinitializeConnections(bool ReturnValue) { return default; }
	public void UpdateConnectionTargets(TMap<sbyte,FVCamConnectionTargetSettings> NewConnectionTargets,bool bReinitializeOnSuccessfulUpdate,EConnectionUpdateResult Result) {}
	public void OnInitializeConnections(UObject VCam) {}
	public UVCamComponent VCamComponent;
}
