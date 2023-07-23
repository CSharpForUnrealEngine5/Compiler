#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WebBrowser.h")]
public partial class UWebBrowser : UWidget {
// WebBrowser
	public void FOnUrlChanged(sbyte Text) {}
	public void FOnBeforePopup(sbyte URL,sbyte Frame) {}
	public void FOnConsoleMessage(sbyte Message,sbyte Source,int Line) {}
	public void LoadURL(sbyte NewURL) {}
	public void LoadString(sbyte Contents,sbyte DummyURL) {}
	public void ExecuteJavascript(sbyte ScriptText) {}
	public sbyte GetTitleText(sbyte ReturnValue) { return default; }
	public sbyte GetUrl(sbyte ReturnValue) { return default; }
	public FOnUrlChanged OnUrlChanged;
	public FOnBeforePopup OnBeforePopup;
	public FOnConsoleMessage OnConsoleMessage;
	public sbyte InitialURL;
	public bool bSupportsTransparency;
}
