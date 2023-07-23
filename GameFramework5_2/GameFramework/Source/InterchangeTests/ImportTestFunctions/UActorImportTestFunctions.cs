#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/ActorImportTestFunctions.h")]
public partial class UActorImportTestFunctions : UImportTestFunctionsBase {
// ActorImportTestFunctions
	public FInterchangeTestFunctionResult CheckImportedActorCount(TArray<UObject> Actors,int ExpectedNumberOfImportedActors,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckActorClassCount(TArray<UObject> Actors,UClass Class,int ExpectedNumberOfActors,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckActorClass(UObject Actor,UClass ExpectedClass,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckActorPropertyValue(UObject Actor,sbyte PropertyName,bool bUseRegexToMatchValue,sbyte ExpectedValue,FInterchangeTestFunctionResult ReturnValue) { return default; }
	public FInterchangeTestFunctionResult CheckComponentPropertyValue(UObject Actor,sbyte ComponentName,sbyte PropertyName,bool bUseRegexToMatchValue,sbyte ExpectedValue,FInterchangeTestFunctionResult ReturnValue) { return default; }
}
