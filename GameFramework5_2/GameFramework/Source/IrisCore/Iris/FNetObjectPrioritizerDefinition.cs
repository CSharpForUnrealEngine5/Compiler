#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/ReplicationSystem/Prioritization/NetObjectPrioritizerDefinitions.h")]
///<summary>Prioritizer definition. Configurable via UNetObjectPrioritizerDefinitions.</summary>
public partial struct FNetObjectPrioritizerDefinition {
// NetObjectPrioritizerDefinition
	public sbyte PrioritizerName;
	public sbyte ClassName;
	public UClass Class;
	public sbyte ConfigClassName;
	public UClass ConfigClass;
}
