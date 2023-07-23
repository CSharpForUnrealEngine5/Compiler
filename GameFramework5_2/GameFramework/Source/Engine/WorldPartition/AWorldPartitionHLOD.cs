#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/HLOD/HLODActor.h")]
public partial class AWorldPartitionHLOD : AActor {
// WorldPartitionHLOD
	public TArray<FHLODSubActor> HLODSubActors;
	public UHLODLayer SubActorsHLODLayer;
	public FBox HLODBounds;
	public double MinVisibleDistance;
	public uint HLODHash;
	public TMap<sbyte,long> HLODStats;
	public uint LODLevel;
	public bool bRequireWarmup;
	public TSoftObjectPtr<UWorldPartitionRuntimeCell> SourceCell_DEPRECATED;
	public sbyte SourceCellName_DEPRECATED;
	public FGuid SourceCellGuid;
}
