#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DirectLinkTestLibrary.h")]
public partial class UDirectLinkTestLibrary : UBlueprintFunctionLibrary {
// DirectLinkTestLibrary
	public bool TestParameters(bool ReturnValue) { return default; }
	public bool StartReceiver(bool ReturnValue) { return default; }
	public bool SetupReceiver(bool ReturnValue) { return default; }
	public bool StopReceiver(bool ReturnValue) { return default; }
	public bool StartSender(bool ReturnValue) { return default; }
	public bool SetupSender(bool ReturnValue) { return default; }
	public bool StopSender(bool ReturnValue) { return default; }
	public bool SendScene(sbyte InFilePath,bool ReturnValue) { return default; }
	public bool DumpReceivedScene(bool ReturnValue) { return default; }
	public int MakeEndpoint(sbyte NiceName,bool bVerbose=true,int ReturnValue) { return default; }
	public bool DeleteEndpoint(int EndpointId,bool ReturnValue) { return default; }
	public bool AddPublicSource(int EndpointId,sbyte SourceName,bool ReturnValue) { return default; }
	public bool AddPublicDestination(int EndpointId,sbyte DestName,bool ReturnValue) { return default; }
	public bool DeleteAllEndpoint(bool ReturnValue) { return default; }
}
