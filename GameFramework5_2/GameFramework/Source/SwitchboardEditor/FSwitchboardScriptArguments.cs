#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SwitchboardTypes.h")]
///<summary>Structure that holds the parameters to the sb_script_new_config.py script that will be passed to Switchboard when auto-creating a new config.</summary>
public partial struct FSwitchboardScriptArguments {
// SwitchboardScriptArguments
	public sbyte ConfigName;
	public sbyte EngineDir;
	public sbyte ProjectPath;
	public sbyte Map;
	public sbyte DisplayClusterConfigPath;
	public int NumEditorDevices;
	public bool bUseLocalhost;
	public bool bAutoConnect;
	public bool bAutoDeleteScriptArgsFile;
}
