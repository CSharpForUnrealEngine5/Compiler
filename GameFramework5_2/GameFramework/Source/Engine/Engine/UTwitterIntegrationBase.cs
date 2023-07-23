#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TwitterIntegrationBase.h")]
public partial class UTwitterIntegrationBase : UPlatformInterfaceBase {
// TwitterIntegrationBase
	public void Init() {}
	public bool CanShowTweetUI(bool ReturnValue) { return default; }
	public bool ShowTweetUI(sbyte InitialMessage,sbyte URL,sbyte Picture,bool ReturnValue) { return default; }
	public bool AuthorizeAccounts(bool ReturnValue) { return default; }
	public int GetNumAccounts(int ReturnValue) { return default; }
	public sbyte GetAccountName(int AccountIndex,sbyte ReturnValue) { return default; }
	public bool TwitterRequest(sbyte URL,TArray<sbyte> ParamKeysAndValues,ETwitterRequestMethod RequestMethod,int AccountIndex,bool ReturnValue) { return default; }
}
