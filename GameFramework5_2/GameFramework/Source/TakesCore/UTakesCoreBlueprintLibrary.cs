#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TakesCoreBlueprintLibrary.h")]
public partial class UTakesCoreBlueprintLibrary : UBlueprintFunctionLibrary {
// TakesCoreBlueprintLibrary
	public int ComputeNextTakeNumber(sbyte Slate,int ReturnValue) { return default; }
	public TArray<FAssetData> FindTakes(sbyte Slate,int TakeNumber=0,TArray<FAssetData> ReturnValue) { return default; }
	public void FOnTakeRecorderSlateChanged(sbyte Slate) {}
	public void FOnTakeRecorderTakeNumberChanged(int TakeNumber) {}
	public void SetOnTakeRecorderSlateChanged(FOnTakeRecorderSlateChanged OnTakeRecorderSlateChanged) {}
	public void SetOnTakeRecorderTakeNumberChanged(FOnTakeRecorderTakeNumberChanged OnTakeRecorderTakeNumberChanged) {}
}
