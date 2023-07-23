#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Commandlets/WorldPartitionConvertCommandlet.h")]
public partial class UWorldPartitionConvertCommandlet : UCommandlet {
// WorldPartitionConvertCommandlet
	public UClass EditorHashClass;
	public UClass RuntimeHashClass;
	public TArray<sbyte> ExcludedLevels;
	public bool bConvertActorsNotReferencedByLevelScript;
	public FVector WorldOrigin;
	public FVector WorldExtent;
	public sbyte HLODLayerAssetsPath;
	public sbyte DefaultHLODLayerName;
	public sbyte DefaultHLODLayerAsset;
	public sbyte FoliageTypePath;
	public TArray<FHLODLayerActorMapping> HLODLayersForActorClasses;
	public TMap<sbyte,UHLODLayer> HLODLayers;
	public uint LandscapeGridSize;
	public sbyte DataLayerAssetFolder;
	public UDataLayerFactory DataLayerFactory;
}
