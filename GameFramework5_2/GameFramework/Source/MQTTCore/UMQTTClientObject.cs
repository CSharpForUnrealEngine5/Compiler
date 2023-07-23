#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MQTTClientObject.h")]
public partial class UMQTTClientObject : UObject {
// MQTTClientObject
	public void FOnConnectDelegate(EMQTTConnectReturnCode ReturnCode) {}
	public void FOnDisconnectDelegate() {}
	public void FOnPublishDelegate() {}
	public void FOnSubscribeDelegate(EMQTTSubscribeReturnCode ReturnCode) {}
	public void FOnUnsubscribeDelegate() {}
	public void FOnMessageDelegate(FMQTTClientMessage Message) {}
	public void Connect(FOnConnectDelegate InOnConnect) {}
	public void Disconnect(FOnDisconnectDelegate InOnDisconnect) {}
	public void Publish(sbyte InTopic,TArray<byte> InPayload,EMQTTQualityOfService InQoS=EMQTTQualityOfService,bool bInRetain=false) {}
	public UObject Subscribe(sbyte InTopic,EMQTTQualityOfService InQoS=EMQTTQualityOfService,UObject ReturnValue) { return default; }
	public TArray<UObject> SubscribeMany(TArray<sbyte> InTopics,TArray<EMQTTQualityOfService> InQoS,TArray<UObject> ReturnValue) { return default; }
	public void Unsubscribe(sbyte InTopic) {}
	public sbyte GetClientId(sbyte ReturnValue) { return default; }
	public FMQTTURL GetURL(FMQTTURL ReturnValue) { return default; }
	public FOnConnectDelegate OnConnectDelegate;
	public FOnDisconnectDelegate OnDisconnectDelegate;
	public FOnMessageDelegate OnMessageDelegate;
	public TArray<UMQTTSubscriptionObject> Subscriptions;
}
