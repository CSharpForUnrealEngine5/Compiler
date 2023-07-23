#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Security/WebAPIAuthentication.h")]
public partial class UWebAPIOAuthSettings : UWebAPIAuthenticationSettings {
// WebAPIOAuthSettings
	public sbyte ClientId;
	public sbyte ClientSecret;
	public sbyte TokenType;
	public sbyte AccessToken;
	public FDateTime ExpiresOn;
	public sbyte AuthenticationServer;
	public TMap<sbyte,sbyte> AdditionalRequestQueryParameters;
	public TMap<sbyte,sbyte> AdditionalRequestBodyParameters;
}
