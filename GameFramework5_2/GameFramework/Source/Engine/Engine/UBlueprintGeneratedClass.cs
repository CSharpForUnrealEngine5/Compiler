#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/BlueprintGeneratedClass.h")]
public partial class UBlueprintGeneratedClass : UClass {
// BlueprintGeneratedClass
	public int NumReplicatedProperties;
	public bool bHasNativizedParent_DEPRECATED;
	public bool bHasCookedComponentInstancingData;
	public bool bIsSparseClassDataSerializable;
	public TArray<UDynamicBlueprintBinding> DynamicBindingObjects;
	public TArray<UActorComponent> ComponentTemplates;
	public TArray<UTimelineTemplate> Timelines;
	public TArray<FBPComponentClassOverride> ComponentClassOverrides;
	public USimpleConstructionScript SimpleConstructionScript;
	public UInheritableComponentHandler InheritableComponentHandler;
	public UStructProperty UberGraphFramePointerProperty_DEPRECATED;
	public UFunction UberGraphFunction;
	public TArray<FEventGraphFastCallPair> FastCallPairs_DEPRECATED;
	public UObject OverridenArchetypeForCDO;
	public TMap<sbyte,FGuid> PropertyGuids;
	public TArray<UFunction> CalledFunctions;
	public TMap<sbyte,FGuid> CookedPropertyGuids;
	public TMap<sbyte,FBlueprintCookedComponentInstancingData> CookedComponentInstancingData;
	public UClassCookedMetaData CachedCookedMetaDataPtr;
}
