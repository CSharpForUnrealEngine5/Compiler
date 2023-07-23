#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimSceneAsset.h")]
public partial class UContextualAnimSceneAsset : UDataAsset {
// ContextualAnimSceneAsset
	public TArray<sbyte> GetRoles(TArray<sbyte> ReturnValue) { return default; }
	public void GetAlignmentPointsForSecondaryRole(EContextualAnimPointType Type,int SectionIdx,FContextualAnimSceneBindingContext Primary,TArray<FContextualAnimPoint> OutResult) {}
	public void GetAlignmentPointsForSecondaryRoleConsideringSelectionCriteria(EContextualAnimPointType Type,int SectionIdx,FContextualAnimSceneBindingContext Primary,FContextualAnimSceneBindingContext Querier,EContextualAnimCriterionToConsider CriterionToConsider,TArray<FContextualAnimPoint> OutResult) {}
	public UObject BP_FindAnimationForRole(int SectionIdx,int AnimSetIdx,sbyte Role,UObject ReturnValue) { return default; }
	public int BP_FindAnimSetIndexByAnimation(int SectionIdx,UObject Animation,int ReturnValue) { return default; }
	public FTransform BP_GetAlignmentTransformForRoleRelativeToPivot(int SectionIdx,int AnimSetIdx,sbyte Role,float Time,FTransform ReturnValue) { return default; }
	public FTransform BP_GetIKTargetTransformForRoleAtTime(int SectionIdx,int AnimSetIdx,sbyte Role,sbyte TrackName,float Time,FTransform ReturnValue) { return default; }
	public void BP_GetStartAndEndTimeForWarpSection(int SectionIdx,int AnimSetIdx,sbyte Role,sbyte WarpSectionName,float OutStartTime,float OutEndTime) {}
	public bool Query(sbyte Role,FContextualAnimQueryResult OutResult,FContextualAnimQueryParams QueryParams,FTransform ToWorldTransform,bool ReturnValue) { return default; }
	public UContextualAnimRolesAsset RolesAsset;
	public sbyte PrimaryRole;
	public TArray<FContextualAnimActorPreviewData> OverridePreviewData;
	public TArray<FContextualAnimSceneSection> Sections;
	public float Radius;
	public UClass SceneInstanceClass;
	public bool bDisableCollisionBetweenActors;
	public int SampleRate;
}
