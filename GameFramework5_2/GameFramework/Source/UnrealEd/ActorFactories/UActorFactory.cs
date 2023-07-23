#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorFactories/ActorFactory.h")]
public partial class UActorFactory : UObject {
// ActorFactory
	public sbyte DisplayName;
	public int MenuPriority;
	public sbyte NewActorClassName;
	public UClass NewActorClass;
	public bool bShowInEditorQuickMenu;
	public bool bUseSurfaceOrientation;
	public bool bUsePlacementExtent;
	public FVector SpawnPositionOffset;
}
