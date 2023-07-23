#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ShotgridEngine.h")]
///<summary>Wrapper for the Python Shotgrid Engine</summary>
public partial class UShotgridEngine : UObject {
// ShotgridEngine
	public UObject GetInstance(UObject ReturnValue) { return default; }
	public void OnEngineInitialized() {}
	public TArray<FShotgridMenuItem> GetShotgridMenuItems(TArray<FShotgridMenuItem> ReturnValue) { return default; }
	public void ExecuteCommand(sbyte CommandName) {}
	public void Shutdown() {}
	public TArray<UObject> GetReferencedAssets(UObject Actor,TArray<UObject> ReturnValue) { return default; }
	public sbyte GetShotgridWorkDir(sbyte ReturnValue) { return default; }
	public TArray<FAssetData> SelectedAssets;
	public TArray<AActor> SelectedActors;
	public TArray<UObject> GetSelectedActors(TArray<UObject> ReturnValue) { return default; }
}
