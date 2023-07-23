#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VRScoutingInteractor.h")]
///<summary>Represents the interactor in the world</summary>
public partial class UVRScoutingInteractor : UVREditorInteractor {
// VRScoutingInteractor
	public void SetGizmoMode(EGizmoHandleTypes InGizmoMode) {}
	public EGizmoHandleTypes GetGizmoMode(EGizmoHandleTypes ReturnValue) { return default; }
	public TArray<UObject> GetSelectedActors(TArray<UObject> ReturnValue) { return default; }
	public UStaticMeshComponent FlyingIndicatorComponent;
	public UObject GetInputComponent(UObject ReturnValue) { return default; }
	public void SetReceivesEditorInput(bool bInValue) {}
	public bool GetReceivesEditorInput(bool ReturnValue) { return default; }
	public UInputComponent EditorOnlyInputComponent;
	public bool bReceivesEditorInput;
}
