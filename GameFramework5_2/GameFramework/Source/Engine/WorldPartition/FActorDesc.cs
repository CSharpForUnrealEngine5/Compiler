#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionBlueprintLibrary.h")]
///<summary>Snapshot of an actor descriptor, which represents the state of an actor on disk.</summary>
public partial struct FActorDesc {
// ActorDesc
	public FGuid Guid;
	public FSoftObjectPath Class;
	public sbyte Name;
	public sbyte Label;
	public FBox Bounds;
	public sbyte RuntimeGrid;
	public bool bIsSpatiallyLoaded;
	public bool bActorIsEditorOnly;
	public sbyte ActorPackage;
	public sbyte ActorPath;
}
