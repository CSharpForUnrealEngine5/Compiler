#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGSpawnActor.h")]
public partial class UPCGSpawnActorSettings : UPCGBaseSubgraphSettings {
// PCGSpawnActorSettings
	public UClass TemplateActorClass;
	public TArray<sbyte> PostSpawnFunctionNames;
	public EPCGSpawnActorOption Option;
	public bool bForceDisableActorParsing;
	public EPCGSpawnActorGenerationTrigger bGenerationTrigger;
	public bool bInheritActorTags;
	public TArray<sbyte> TagsToAddOnActors;
	public AActor TemplateActor;
	public TArray<FPCGActorPropertyOverride> ActorOverrides;
}
