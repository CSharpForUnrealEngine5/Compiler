#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WebAPIDeveloperSettings.h")]
///<summary>The base class of any auto generated WebAPI settings object.</summary>
public partial class UWebAPIDeveloperSettings : UDeveloperSettings {
// WebAPIDeveloperSettings
	public sbyte Host;
	public sbyte BaseUrl;
	public sbyte UserAgent;
	public sbyte DateTimeFormat;
	public bool bOverrideScheme;
	public sbyte URISchemeOverride;
	public TArray<sbyte> URISchemes;
	public bool bLogRequests;
	public TArray<UWebAPIAuthenticationSettings> AuthenticationSettings;
}
