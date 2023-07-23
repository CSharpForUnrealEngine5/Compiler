#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/BrowserBinding.h")]
public partial class UBrowserBinding : UObject {
// BrowserBinding
	public void DialogSuccessCallback(FWebJSFunction DialogJSCallback) {}
	public void DialogFailCallback(FWebJSFunction DialogJSCallback) {}
	public void OnDroppedCallback(FWebJSFunction OnDroppedJSCallback) {}
	public void OnDropDiscardedCallback(FWebJSFunction OnDropDiscardedJSCallback) {}
	public void OnExitCallback(FWebJSFunction OnExitJSCallback) {}
	public void SaveAuthToken(sbyte Value) {}
	public sbyte GetAuthToken(sbyte ReturnValue) { return default; }
	public void SendSuccess(sbyte Value) {}
	public void SendFailure(sbyte Message) {}
	public void ShowDialog(sbyte Type,sbyte Url) {}
	public void DragStarted(TArray<sbyte> ImageUrl,TArray<sbyte> IDs,TArray<sbyte> Types) {}
	public void ShowLoginDialog(sbyte LoginUrl,sbyte ResponseCodeUrl) {}
	public void OpenExternalUrl(sbyte Url) {}
	public void ExportDataToMSPlugin(sbyte Data) {}
	public sbyte GetProjectPath(sbyte ReturnValue) { return default; }
	public void Logout() {}
	public void StartNodeProcess() {}
	public void RestartNodeProcess() {}
	public void OpenMegascansPluginSettings() {}
}
