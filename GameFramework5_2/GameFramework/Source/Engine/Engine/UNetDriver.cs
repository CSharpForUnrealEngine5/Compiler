#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/NetDriver.h")]
public partial class UNetDriver : UObject {
// NetDriver
	public sbyte NetConnectionClassName;
	public sbyte ReplicationDriverClassName;
	public sbyte ReplicationBridgeClassName;
	public int MaxDownloadSize;
	public bool bClampListenServerTickRate;
	public int NetServerMaxTickRate;
	public int MaxNetTickRate;
	public int MaxInternetClientRate;
	public int MaxClientRate;
	public float ServerTravelPause;
	public float SpawnPrioritySeconds;
	public float RelevantTimeout;
	public float KeepAliveTime;
	public float InitialConnectTimeout;
	public float ConnectionTimeout;
	public float TimeoutMultiplierForUnoptimizedBuilds;
	public UNetConnection ServerConnection;
	public TArray<UNetConnection> ClientConnections;
	public int RecentlyDisconnectedTrackingTime;
	public UWorld World;
	public UPackage WorldPackage;
	public UClass NetConnectionClass;
	public UClass ReplicationDriverClass;
	public UClass ReplicationBridgeClass;
	public sbyte NetDriverName;
	public TArray<FChannelDefinition> ChannelDefinitions;
	public TMap<sbyte,FChannelDefinition> ChannelDefinitionMap;
	public TArray<UChannel> ActorChannelPool;
	public bool bNoTimeouts;
	public bool bNeverApplyNetworkEmulationSettings;
	public UReplicationDriver ReplicationDriver;
}
