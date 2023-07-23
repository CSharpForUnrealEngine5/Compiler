#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/MaterialImportTestFunctions.h")]
public partial class UMaterialImportTestFunctions : UImportTestFunctionsBase {
// MaterialImportTestFunctions
	public FInterchangeTestFunctionResult CheckImportedMaterialCount(TArray<UObject> MaterialInterfaces,int ExpectedNumberOfImportedMaterials,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckImportedMaterialInstanceCount(TArray<UObject> MaterialInterfaces,int ExpectedNumberOfImportedMaterialInstances,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckShadingModel(UObject MaterialInterface,EMaterialShadingModel ExpectedShadingModel,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckBlendMode(UObject MaterialInterface,EBlendMode ExpectedBlendMode,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckIsTwoSided(UObject MaterialInterface,bool ExpectedIsTwoSided,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckOpacityMaskClipValue(UObject MaterialInterface,float ExpectedOpacityMaskClipValue,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckScalarParameter(UObject MaterialInterface,sbyte ParameterName,float ExpectedParameterValue,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckVectorParameter(UObject MaterialInterface,sbyte ParameterName,FLinearColor ExpectedParameterValue,FInterchangeTestFunctionResult ReturnValue) { return default; }
}
