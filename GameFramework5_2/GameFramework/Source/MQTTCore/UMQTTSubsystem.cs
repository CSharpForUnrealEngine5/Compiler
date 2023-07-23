#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MQTTSubsystem.h")]
///<summary>Provides persistent access to clients</summary>
public partial class UMQTTSubsystem : UEngineSubsystem {
// MQTTSubsystem
	public UObject GetOrCreateClient_WithProjectURL(UObject InParent,UObject ReturnValue) { return default; }
	public UObject GetOrCreateClient(UObject InParent,FMQTTURL InURL,UObject ReturnValue) { return default; }
	public sbyte GetPayloadString(FMQTTClientMessage InClientMessage,sbyte ReturnValue) { return default; }
	public bool GetPayloadJson(UObject InParent,FMQTTClientMessage InClientMessage,FJsonObjectWrapper OutJson,bool ReturnValue) { return default; }
	public TMap<FGuid,UMQTTClientObject> Clients;
}
