#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPIOperation.h")]
public partial class UWebAPIOperation : UObject {
// WebAPIOperation
	public FWebAPITypeNameVariant Name;
	public bool bGenerate;
	public UWebAPIService Service;
	public sbyte Description;
	public bool bIsDeprecated;
	public sbyte Verb;
	public sbyte Path;
	public TArray<sbyte> RequestContentTypes;
	public TArray<sbyte> ResponseContentTypes;
	public UWebAPIOperationRequest Request;
	public TArray<UWebAPIOperationResponse> Responses;
	public TArray<UWebAPIOperationError> Errors;
	public sbyte GeneratedCodeText;
}
