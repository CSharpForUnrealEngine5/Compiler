#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimMontage.h")]
///<summary>Any property you're adding to AnimMontage and parent class has to be considered for Child Asset</summary>
public partial class UAnimMontage : UAnimCompositeBase {
// AnimMontage
	public EMontageBlendMode BlendModeIn;
	public EMontageBlendMode BlendModeOut;
	public FAlphaBlend BlendIn;
	public float BlendInTime_DEPRECATED;
	public FAlphaBlend BlendOut;
	public float BlendOutTime_DEPRECATED;
	public float BlendOutTriggerTime;
	public FAlphaBlendArgs GetBlendInArgs(FAlphaBlendArgs ReturnValue) { return default; }
	public FAlphaBlendArgs GetBlendOutArgs(FAlphaBlendArgs ReturnValue) { return default; }
	public float GetDefaultBlendInTime(float ReturnValue) { return default; }
	public float GetDefaultBlendOutTime(float ReturnValue) { return default; }
	public sbyte SyncGroup;
	public int SyncSlotIndex;
	public FMarkerSyncData MarkerData;
	public TArray<FCompositeSection> CompositeSections;
	public TArray<FSlotAnimationTrack> SlotAnimTracks;
	public TArray<FBranchingPoint> BranchingPoints_DEPRECATED;
	public bool bEnableRootMotionTranslation;
	public bool bEnableRootMotionRotation;
	public bool bEnableAutoBlendOut;
	public UBlendProfile BlendProfileIn;
	public UBlendProfile BlendProfileOut;
	public byte RootMotionRootLock;
	public UAnimSequence PreviewBasePose;
	public int GetSectionIndex(sbyte InSectionName,int ReturnValue) { return default; }
	public sbyte GetSectionName(int SectionIndex,sbyte ReturnValue) { return default; }
	public int GetNumSections(int ReturnValue) { return default; }
	public bool IsValidSectionName(sbyte InSectionName,bool ReturnValue) { return default; }
	public TArray<FBranchingPointMarker> BranchingPointMarkers;
	public TArray<int> BranchingPointStateNotifyIndices;
	public UObject CreateSlotAnimationAsDynamicMontage_WithBlendSettings(UObject Asset,sbyte SlotNodeName,FMontageBlendSettings BlendInSettings,FMontageBlendSettings BlendOutSettings,float InPlayRate=1.f,int LoopCount=1,float InBlendOutTriggerTime=-1.f,UObject ReturnValue) { return default; }
	public FTimeStretchCurve TimeStretchCurve;
	public sbyte TimeStretchCurveName;
}
