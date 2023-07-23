#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_AimOffsetLookAt.h")]
///<summary>This node uses a source transform of a socket on the skeletal mesh to automatically calculate</summary>
public partial struct FAnimNode_AimOffsetLookAt {
// AnimNode_AimOffsetLookAt
	public FPoseLink BasePose;
	public int LODThreshold;
	public sbyte SourceSocketName;
	public sbyte PivotSocketName;
	public FVector LookAtLocation;
	public FVector SocketAxis;
	public float Alpha;
}
