#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimStateTransitionNode.h")]
public partial class UAnimStateTransitionNode : UAnimStateNodeBase {
// AnimStateTransitionNode
	public UEdGraph BoundGraph;
	public UEdGraph CustomTransitionGraph;
	public int PriorityOrder;
	public float CrossfadeDuration;
	public byte CrossfadeMode_DEPRECATED;
	public EAlphaBlendOption BlendMode;
	public UCurveFloat CustomBlendCurve;
	public UBlendProfile BlendProfile;
	public bool bAutomaticRuleBasedOnSequencePlayerInState;
	public sbyte SyncGroupNameToRequireValidMarkersRule;
	public byte LogicType;
	public FAnimNotifyEvent TransitionStart;
	public FAnimNotifyEvent TransitionEnd;
	public FAnimNotifyEvent TransitionInterrupt;
	public bool Bidirectional;
	public bool bSharedRules;
	public bool bSharedCrossfade;
	public sbyte SharedRulesName;
	public FGuid SharedRulesGuid;
	public FLinearColor SharedColor;
	public sbyte SharedCrossfadeName;
	public FGuid SharedCrossfadeGuid;
	public int SharedCrossfadeIdx;
}
