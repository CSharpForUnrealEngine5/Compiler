#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PythonScriptPluginSettings.h")]
///<summary>Configure the Python plug-in.</summary>
public partial class UPythonScriptPluginSettings : UDeveloperSettings {
// PythonScriptPluginSettings
	public TArray<sbyte> StartupScripts;
	public TArray<FDirectoryPath> AdditionalPaths;
	public bool bIsolateInterpreterEnvironment;
	public bool bDeveloperMode;
	public bool bRemoteExecution;
	public sbyte RemoteExecutionMulticastGroupEndpoint;
	public sbyte RemoteExecutionMulticastBindAddress;
	public int RemoteExecutionSendBufferSizeBytes;
	public int RemoteExecutionReceiveBufferSizeBytes;
	public byte RemoteExecutionMulticastTtl;
}
