#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionResaveActorsBuilder.h")]
///<summary>Example Command Line: ProjectName MapName -run=WorldPartitionBuilderCommandlet -SCCProvider=Perforce -Builder=WorldPartitionResaveActorsBuilder [-ActorClassName=StaticMeshActor] [-SwitchActorPackagingSchemeToReduced] [-ActorTags=(Tag1,Tag2,...)] [-ActorProperties=((Property1,Value1),(Property2,Value2),...)]</summary>
public partial class UWorldPartitionResaveActorsBuilder : UWorldPartitionBuilder {
// WorldPartitionResaveActorsBuilder
	public sbyte ActorClassName;
	public sbyte ActorClassesFromFile;
	public bool bReportOnly;
	public bool bResaveDirtyActorDescsOnly;
	public bool bDiffDirtyActorDescs;
	public bool bSwitchActorPackagingSchemeToReduced;
	public bool bEnableActorFolders;
	public TSet<sbyte> ActorTags;
	public TMap<sbyte,sbyte> ActorProperties;
}
