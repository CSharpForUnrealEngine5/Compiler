#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/AutomationTestSettings.h")]
///<summary>Structure for defining an external tool</summary>
public partial struct FExternalToolDefinition {
// ExternalToolDefinition
	public sbyte ToolName;
	public FFilePath ExecutablePath;
	public sbyte CommandLineOptions;
	public FDirectoryPath WorkingDirectory;
	public sbyte ScriptExtension;
	public FDirectoryPath ScriptDirectory;
}
