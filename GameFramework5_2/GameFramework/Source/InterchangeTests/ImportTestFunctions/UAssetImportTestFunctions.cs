#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/AssetImportTestFunctions.h")]
public partial class UAssetImportTestFunctions : UImportTestFunctionsBase {
// AssetImportTestFunctions
	public FInterchangeTestFunctionResult CheckImportedMetadataCount(UObject Object,int ExpectedNumberOfMetadataForThisObject,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckMetadataExist(UObject Object,sbyte ExpectedMetadataKey,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckMetadataValue(UObject Object,sbyte ExpectedMetadataKey,sbyte ExpectedMetadataValue,FInterchangeTestFunctionResult ReturnValue) { return default; }
}
