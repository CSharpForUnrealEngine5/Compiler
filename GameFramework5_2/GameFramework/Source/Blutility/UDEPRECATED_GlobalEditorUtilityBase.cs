#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GlobalEditorUtilityBase.h")]
public partial class UDEPRECATED_GlobalEditorUtilityBase : UObject {
// GlobalEditorUtilityBase
	public sbyte HelpText;
	public bool bDirtiedSelectionSet;
	public TArray<UObject> GetSelectionSet(TArray<UObject> ReturnValue) { return default; }
	public UObject GetActorReference(sbyte PathToActor,UObject ReturnValue) { return default; }
	public bool bAutoRunDefaultAction;
	public void OnDefaultActionClicked() {}
	public void ForEachSelectedActor() {}
	public FForEachActorIteratorSignature OnEachSelectedActor;
	public void ForEachSelectedAsset() {}
	public FForEachAssetIteratorSignature OnEachSelectedAsset;
	public TArray<UObject> GetSelectedAssets(TArray<UObject> ReturnValue) { return default; }
	public UObject GetEditorUserSettings(UObject ReturnValue) { return default; }
	public void ClearActorSelectionSet() {}
	public void SelectNothing() {}
	public void SetActorSelectionState(UObject Actor,bool bShouldBeSelected) {}
	public void GetSelectionBounds(FVector Origin,FVector BoxExtent,float SphereRadius) {}
	public void RenameAsset(UObject Asset,sbyte NewName) {}
}
