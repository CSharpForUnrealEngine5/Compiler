#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearch/AnimNode_MotionMatching.h")]
public partial struct FAnimNode_MotionMatching {
// AnimNode_MotionMatching
	public FPoseLink Source;
	public UPoseSearchSearchableAsset Searchable;
	public FGameplayTagContainer ActiveTagsContainer;
	public FTrajectorySampleRange Trajectory;
	public FMotionMatchingSettings Settings;
	public bool bResetOnBecomingRelevant;
	public bool bForceInterrupt;
	public bool bDebugDraw;
	public bool bDebugDrawQuery;
	public bool bDebugDrawMatch;
	public bool bIgnoreForRelevancyTest;
}
