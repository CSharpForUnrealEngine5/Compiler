#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnalyticsMulticastSettings.h")]
public partial class UAnalyticsMulticastSettings : UAnalyticsSettingsBase {
// AnalyticsMulticastSettings
	public TArray<sbyte> ReleaseMulticastProviders;
	public TArray<sbyte> DebugMulticastProviders;
	public TArray<sbyte> TestMulticastProviders;
	public TArray<sbyte> DevelopmentMulticastProviders;
}
