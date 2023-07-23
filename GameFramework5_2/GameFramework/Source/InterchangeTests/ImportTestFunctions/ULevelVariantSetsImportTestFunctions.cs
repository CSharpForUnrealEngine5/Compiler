#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/LevelVariantSetsImportTestFunctions.h")]
public partial class ULevelVariantSetsImportTestFunctions : UImportTestFunctionsBase {
// LevelVariantSetsImportTestFunctions
	public FInterchangeTestFunctionResult CheckLevelVariantSetsCount(TArray<UObject> LevelVariantSetsAssets,int ExpectedNumberOfLevelVariantSets,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckVariantSetsCount(UObject LevelVariantSets,int ExpectedNumberOfVariantSets,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckVariantsCount(UObject LevelVariantSets,sbyte VariantSetName,int ExpectedNumberOfVariants,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckBindingsCount(UObject LevelVariantSets,sbyte VariantSetName,sbyte VariantName,int ExpectedNumberOfBindings,FInterchangeTestFunctionResult ReturnValue) { return default; }
}
