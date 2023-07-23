#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNode_LinkedAnimGraph.h")]
public partial struct FAnimNode_LinkedAnimGraph {
// AnimNode_LinkedAnimGraph
	public TArray<FPoseLink> InputPoses;
	public TArray<sbyte> InputPoseNames;
	public UClass InstanceClass;
	public sbyte Tag_DEPRECATED;
	public UBlendProfile PendingBlendOutProfile;
	public UBlendProfile PendingBlendInProfile;
	public bool bReceiveNotifiesFromLinkedInstances;
	public bool bPropagateNotifiesToLinkedInstances;
}
