#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MobilePatchingLibrary.h")]
public partial class UMobilePendingContent : UMobileInstalledContent {
// MobilePendingContent
	public float GetDownloadSize(float ReturnValue) { return default; }
	public float GetRequiredDiskSpace(float ReturnValue) { return default; }
	public float GetTotalDownloadedSize(float ReturnValue) { return default; }
	public float GetDownloadSpeed(float ReturnValue) { return default; }
	public sbyte GetDownloadStatusText(sbyte ReturnValue) { return default; }
	public float GetInstallProgress(float ReturnValue) { return default; }
	public void StartInstall(FOnContentInstallSucceeded OnSucceeded,FOnContentInstallFailed OnFailed) {}
}
