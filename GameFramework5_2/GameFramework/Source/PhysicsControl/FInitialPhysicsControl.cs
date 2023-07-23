#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsControlActor.h")]
///<summary>Structure that determines a Physics Control used during initialization of the physics control actor</summary>
public partial struct FInitialPhysicsControl {
// InitialPhysicsControl
	public AActor ParentActor;
	public sbyte ParentMeshComponentName;
	public sbyte ParentBoneName;
	public AActor ChildActor;
	public sbyte ChildMeshComponentName;
	public sbyte ChildBoneName;
	public FPhysicsControlData ControlData;
	public FPhysicsControlMultiplier ControlMultiplier;
	public FPhysicsControlTarget ControlTarget;
	public FPhysicsControlSettings ControlSettings;
}
