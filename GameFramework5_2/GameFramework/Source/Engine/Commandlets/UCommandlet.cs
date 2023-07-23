#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Commandlets/Commandlet.h")]
public partial class UCommandlet : UObject {
// Commandlet
	public sbyte HelpDescription;
	public sbyte HelpUsage;
	public sbyte HelpWebLink;
	public TArray<sbyte> HelpParamNames;
	public TArray<sbyte> HelpParamDescriptions;
	public bool IsServer;
	public bool IsClient;
	public bool IsEditor;
	public bool LogToConsole;
	public bool ShowErrorCount;
	public bool ShowProgress;
	public bool FastExit;
}
