#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPISchema.h")]
///<summary>Describes the intermediate structure from which to generate code.</summary>
public partial class UWebAPISchema : UObject {
// WebAPISchema
	public sbyte APIName;
	public sbyte Version;
	public sbyte Host;
	public sbyte BaseUrl;
	public sbyte UserAgent;
	public sbyte DateTimeFormat;
	public TArray<sbyte> URISchemes;
	public UWebAPITypeRegistry TypeRegistry;
	public TArray<UWebAPIModelBase> Models;
	public TMap<sbyte,UWebAPIService> Services;
}
