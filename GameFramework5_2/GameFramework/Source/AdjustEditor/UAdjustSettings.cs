#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AdjustSettings.h")]
public partial class UAdjustSettings : UAnalyticsSettingsBase {
// AdjustSettings
	public bool bSandboxNondistribution;
	public bool bSandboxDistribution;
	public sbyte AppToken;
	public byte LogLevel;
	public sbyte DefaultTracker;
	public sbyte ProcessName;
	public bool bEventBuffering;
	public bool bSendInBackground;
	public float DelayStart;
	public TArray<FAdjustEventMapping> EventMap;
}
