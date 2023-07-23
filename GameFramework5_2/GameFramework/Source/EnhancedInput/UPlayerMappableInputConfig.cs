#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PlayerMappableInputConfig.h")]
///<summary>UPlayerMappableInputConfig</summary>
public partial class UPlayerMappableInputConfig : UPrimaryDataAsset {
// PlayerMappableInputConfig
	public TArray<FEnhancedActionKeyMapping> GetPlayerMappableKeys(TArray<FEnhancedActionKeyMapping> ReturnValue) { return default; }
	public FEnhancedActionKeyMapping GetMappingByName(sbyte MappingName,FEnhancedActionKeyMapping ReturnValue) { return default; }
	public TArray<FEnhancedActionKeyMapping> GetKeysBoundToAction(UObject InAction,TArray<FEnhancedActionKeyMapping> ReturnValue) { return default; }
	public void ResetToDefault() {}
	public sbyte ConfigName;
	public sbyte ConfigDisplayName;
	public bool bIsDeprecated;
	public UObject Metadata;
	public TMap<UInputMappingContext,int> Contexts;
	public TMap<UInputMappingContext,int> GetMappingContexts(TMap<UInputMappingContext,int> ReturnValue) { return default; }
	public sbyte GetConfigName(sbyte ReturnValue) { return default; }
	public sbyte GetDisplayName(sbyte ReturnValue) { return default; }
	public bool IsDeprecated(bool ReturnValue) { return default; }
	public UObject GetMetadata(UObject ReturnValue) { return default; }
}
