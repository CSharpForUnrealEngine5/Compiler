#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CableComponent.h")]
///<summary>Component that allows you to specify custom triangle mesh geometry</summary>
public partial class UCableComponent : UMeshComponent {
// CableComponent
	public bool bAttachStart;
	public bool bAttachEnd;
	public FComponentReference AttachEndTo;
	public sbyte AttachEndToSocketName;
	public FVector EndLocation;
	public void SetAttachEndToComponent(UObject Component,sbyte SocketName=NAME_None) {}
	public void SetAttachEndTo(UObject Actor,sbyte ComponentProperty,sbyte SocketName=NAME_None) {}
	public UObject GetAttachedActor(UObject ReturnValue) { return default; }
	public UObject GetAttachedComponent(UObject ReturnValue) { return default; }
	public void GetCableParticleLocations(TArray<FVector> Locations) {}
	public float CableLength;
	public int NumSegments;
	public float SubstepTime;
	public int SolverIterations;
	public bool bEnableStiffness;
	public bool bUseSubstepping;
	public bool bSkipCableUpdateWhenNotVisible;
	public bool bSkipCableUpdateWhenNotOwnerRecentlyRendered;
	public bool bEnableCollision;
	public float CollisionFriction;
	public FVector CableForce;
	public float CableGravityScale;
	public float CableWidth;
	public int NumSides;
	public float TileMaterial;
}
