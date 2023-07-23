#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionLevelStreamingPolicy.h")]
public partial class UWorldPartitionLevelStreamingPolicy : UWorldPartitionStreamingPolicy {
// WorldPartitionLevelStreamingPolicy
	public TMap<sbyte,sbyte> ActorToCellRemapping;
	public TMap<sbyte,sbyte> SubObjectsToCellRemapping;
}
