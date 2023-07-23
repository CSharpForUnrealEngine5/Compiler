#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepOperation.h")]
///<summary>Base class for all Dataprep editing operations</summary>
public partial class UDataprepEditingOperation : UDataprepOperation {
// DataprepEditingOperation
	public UObject AddAsset(UObject Asset,sbyte AssetName,UObject ReturnValue) { return default; }
	public UObject CreateAsset(UClass AssetClass,sbyte AssetName,UObject ReturnValue) { return default; }
	public UObject CreateActor(UClass ActorClass,sbyte ActorName,UObject ReturnValue) { return default; }
	public void RemoveObject(UObject Object,bool bLocalContext=false) {}
	public void RemoveObjects(TArray<UObject> Objects,bool bLocalContext=false) {}
	public void DeleteObject(UObject Objects) {}
	public void DeleteObjects(TArray<UObject> Objects) {}
}
