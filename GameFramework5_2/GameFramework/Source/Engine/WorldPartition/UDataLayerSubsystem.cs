#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/DataLayer/DataLayerSubsystem.h")]
public partial class UDataLayerSubsystem : UWorldSubsystem {
// DataLayerSubsystem
	public UObject GetDataLayerInstanceFromAsset(UObject InDataLayerAsset,UObject ReturnValue) { return default; }
	public EDataLayerRuntimeState GetDataLayerInstanceRuntimeState(UObject InDataLayerAsset,EDataLayerRuntimeState ReturnValue) { return default; }
	public EDataLayerRuntimeState GetDataLayerInstanceEffectiveRuntimeState(UObject InDataLayerAsset,EDataLayerRuntimeState ReturnValue) { return default; }
	public void SetDataLayerInstanceRuntimeState(UObject InDataLayerAsset,EDataLayerRuntimeState InState,bool bInIsRecursive=false) {}
	public FOnDataLayerRuntimeStateChanged OnDataLayerRuntimeStateChanged;
	public void SetDataLayerState(FActorDataLayer InDataLayer,EDataLayerState InState) {}
	public void SetDataLayerStateByLabel(sbyte InDataLayerLabel,EDataLayerState InState) {}
	public EDataLayerState GetDataLayerState(FActorDataLayer InDataLayer,EDataLayerState ReturnValue) { return default; }
	public EDataLayerState GetDataLayerStateByLabel(sbyte InDataLayerLabel,EDataLayerState ReturnValue) { return default; }
	public TSet<sbyte> GetActiveDataLayerNames(TSet<sbyte> ReturnValue) { return default; }
	public TSet<sbyte> GetLoadedDataLayerNames(TSet<sbyte> ReturnValue) { return default; }
	public UObject GetDataLayer(FActorDataLayer InDataLayer,UObject ReturnValue) { return default; }
	public UObject GetDataLayerFromName(sbyte InDataLayerName,UObject ReturnValue) { return default; }
	public UObject GetDataLayerFromLabel(sbyte InDataLayerLabel,UObject ReturnValue) { return default; }
	public EDataLayerRuntimeState GetDataLayerRuntimeState(FActorDataLayer InDataLayer,EDataLayerRuntimeState ReturnValue) { return default; }
	public EDataLayerRuntimeState GetDataLayerRuntimeStateByLabel(sbyte InDataLayerLabel,EDataLayerRuntimeState ReturnValue) { return default; }
	public EDataLayerRuntimeState GetDataLayerEffectiveRuntimeState(FActorDataLayer InDataLayer,EDataLayerRuntimeState ReturnValue) { return default; }
	public EDataLayerRuntimeState GetDataLayerEffectiveRuntimeStateByLabel(sbyte InDataLayerLabel,EDataLayerRuntimeState ReturnValue) { return default; }
	public void SetDataLayerRuntimeState(FActorDataLayer InDataLayer,EDataLayerRuntimeState InState,bool bInIsRecursive=false) {}
	public void SetDataLayerRuntimeStateByLabel(sbyte InDataLayerLabel,EDataLayerRuntimeState InState,bool bInIsRecursive=false) {}
	public TSoftObjectPtr<UClass> DataLayerLoadingPolicyClass;
	public UDataLayerLoadingPolicy DataLayerLoadingPolicy;
}
