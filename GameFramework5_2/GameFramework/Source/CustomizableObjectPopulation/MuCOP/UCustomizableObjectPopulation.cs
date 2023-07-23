#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOP/CustomizableObjectPopulation.h")]
public partial class UCustomizableObjectPopulation : UObject {
// CustomizableObjectPopulation
	public sbyte Name;
	public TArray<FClassWeightPair> ClassWeights;
	public int GeneratePopulation(TArray<UObject> OutInstances,int NumInstancesToGenerate=1,int ReturnValue) { return default; }
	public bool RegeneratePopulation(int Seed,TArray<UObject> OutInstances,int NumInstancesToGenerate=1,bool ReturnValue) { return default; }
	public UCustomizableObjectPopulationGenerator Generator;
}
