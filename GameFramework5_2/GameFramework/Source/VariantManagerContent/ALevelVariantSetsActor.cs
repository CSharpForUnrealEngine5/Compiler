#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelVariantSetsActor.h")]
public partial class ALevelVariantSetsActor : AActor {
// LevelVariantSetsActor
	public UObject GetLevelVariantSets(bool bLoad=false,UObject ReturnValue) { return default; }
	public void SetLevelVariantSets(UObject InVariantSets) {}
	public bool SwitchOnVariantByName(sbyte VariantSetName,sbyte VariantName,bool ReturnValue) { return default; }
	public bool SwitchOnVariantByIndex(int VariantSetIndex,int VariantIndex,bool ReturnValue) { return default; }
	public FSoftObjectPath LevelVariantSets;
	public TMap<UBlueprintGeneratedClass,ULevelVariantSetsFunctionDirector> DirectorInstances;
}
