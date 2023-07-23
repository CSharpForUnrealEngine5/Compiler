#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDTestsBlueprintLibrary.h")]
///<summary>Library of functions that can be used via Python scripting to help testing the other USD functionality</summary>
public partial class USDTestsBlueprintLibrary : UBlueprintFunctionLibrary {
// SDTestsBlueprintLibrary
	public bool RecompileBlueprintStageActor(UObject BlueprintDerivedStageActor,bool ReturnValue) { return default; }
	public void DirtyStageActorBlueprint(UObject BlueprintDerivedStageActor) {}
	public long GetSubtreeVertexCount(UObject StageActor,sbyte PrimPath,long ReturnValue) { return default; }
	public long GetSubtreeMaterialSlotCount(UObject StageActor,sbyte PrimPath,long ReturnValue) { return default; }
	public void SetUsdStageCpp(UObject StageActor,sbyte NewStageRootLayer) {}
	public void ClearTransactionHistory() {}
}
