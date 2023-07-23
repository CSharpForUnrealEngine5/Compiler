#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialParameterCollection.h")]
///<summary>Asset class that contains a list of parameter names and their default values.</summary>
public partial class UMaterialParameterCollection : UObject {
// MaterialParameterCollection
	public FGuid StateId;
	public TArray<FCollectionScalarParameter> ScalarParameters;
	public TArray<FCollectionVectorParameter> VectorParameters;
	public TArray<sbyte> GetScalarParameterNames(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetVectorParameterNames(TArray<sbyte> ReturnValue) { return default; }
	public float GetScalarParameterDefaultValue(sbyte ParameterName,bool bParameterFound,float ReturnValue) { return default; }
	public FLinearColor GetVectorParameterDefaultValue(sbyte ParameterName,bool bParameterFound,FLinearColor ReturnValue) { return default; }
}
