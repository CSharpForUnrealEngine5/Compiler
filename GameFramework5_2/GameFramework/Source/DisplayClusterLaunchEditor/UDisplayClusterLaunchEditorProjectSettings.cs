#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterLaunchEditorProjectSettings.h")]
public partial class UDisplayClusterLaunchEditorProjectSettings : UObject {
// DisplayClusterLaunchEditorProjectSettings
	public bool bCloseEditorOnLaunch;
	public bool bConnectToMultiUser;
	public sbyte ExplicitSessionName;
	public bool bEnableUnrealInsights;
	public bool bEnableStatNamedEvents;
	public FDirectoryPath ExplicitTraceFileSaveDirectory;
	public FSoftObjectPath ConsoleVariablesPreset;
	public TSet<sbyte> AdditionalConsoleVariables;
	public TSet<sbyte> AdditionalConsoleCommands;
	public TSet<sbyte> CommandLineArguments;
	public sbyte LogFileName;
	public TArray<FDisplayClusterLaunchLoggingConstruct> Logging;
}
