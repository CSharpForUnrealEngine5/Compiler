#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimUtilities.h")]
public partial class UContextualAnimUtilities : UBlueprintFunctionLibrary {
// ContextualAnimUtilities
	public void BP_DrawDebugPose(UObject WorldContextObject,UObject Animation,float Time,FTransform LocalToWorldTransform,FLinearColor Color,float LifeTime,float Thickness) {}
	public bool BP_CreateContextualAnimSceneBindings(UObject SceneAsset,TMap<sbyte,FContextualAnimSceneBindingContext> Params,FContextualAnimSceneBindings OutBindings,bool ReturnValue) { return default; }
	public bool BP_CreateContextualAnimSceneBindingsForTwoActors(UObject SceneAsset,FContextualAnimSceneBindingContext Primary,FContextualAnimSceneBindingContext Secondary,FContextualAnimSceneBindings OutBindings,bool ReturnValue) { return default; }
	public void BP_Montage_GetSectionStartAndEndTime(UObject Montage,int SectionIndex,float OutStartTime,float OutEndTime) {}
	public float BP_Montage_GetSectionTimeLeftFromPos(UObject Montage,float Position,float ReturnValue) { return default; }
	public float BP_Montage_GetSectionLength(UObject Montage,int SectionIndex,float ReturnValue) { return default; }
	public void BP_SceneBindings_CalculateAnimSetPivots(FContextualAnimSceneBindings Bindings,TArray<FContextualAnimSetPivot> OutPivots) {}
	public void BP_SceneBindings_AddOrUpdateWarpTargetsForBindings(FContextualAnimSceneBindings Bindings) {}
	public TArray<FContextualAnimSceneBinding> BP_SceneBindings_GetBindings(FContextualAnimSceneBindings Bindings,TArray<FContextualAnimSceneBinding> ReturnValue) { return default; }
	public FContextualAnimSceneBinding BP_SceneBindings_GetBindingByRole(FContextualAnimSceneBindings Bindings,sbyte Role,FContextualAnimSceneBinding ReturnValue) { return default; }
	public FContextualAnimSceneBinding BP_SceneBindings_GetBindingByActor(FContextualAnimSceneBindings Bindings,UObject Actor,FContextualAnimSceneBinding ReturnValue) { return default; }
	public UObject BP_SceneBinding_GetAnimationFromBinding(FContextualAnimSceneBindings Bindings,FContextualAnimSceneBinding Binding,UObject ReturnValue) { return default; }
	public sbyte BP_SceneBinding_GetRoleFromBinding(FContextualAnimSceneBindings Bindings,FContextualAnimSceneBinding Binding,sbyte ReturnValue) { return default; }
	public UObject BP_SceneBindings_GetSceneAsset(FContextualAnimSceneBindings Bindings,UObject ReturnValue) { return default; }
	public void BP_SceneBindings_GetSectionAndAnimSetIndices(FContextualAnimSceneBindings Bindings,int SectionIdx,int AnimSetIdx) {}
	public FTransform BP_SceneBindings_GetAlignmentTransformForRoleRelativeToOtherRole(FContextualAnimSceneBindings Bindings,sbyte Role,sbyte RelativeToRole,float Time,FTransform ReturnValue) { return default; }
	public FTransform BP_SceneBindings_GetAlignmentTransformForRoleRelativeToPivot(FContextualAnimSceneBindings Bindings,sbyte Role,FContextualAnimSetPivot Pivot,float Time,FTransform ReturnValue) { return default; }
	public FTransform BP_SceneBindings_GetAlignmentTransformFromBinding(FContextualAnimSceneBindings Bindings,FContextualAnimSceneBinding Binding,FContextualAnimSetPivot Pivot,FTransform ReturnValue) { return default; }
	public FContextualAnimSceneBindingContext BP_SceneBindingContext_MakeFromActor(UObject Actor,FContextualAnimSceneBindingContext ReturnValue) { return default; }
	public FContextualAnimSceneBindingContext BP_SceneBindingContext_MakeFromActorWithExternalTransform(UObject Actor,FTransform ExternalTransform,FContextualAnimSceneBindingContext ReturnValue) { return default; }
	public UObject BP_SceneBindingContext_GetActor(FContextualAnimSceneBindingContext BindingContext,UObject ReturnValue) { return default; }
	public FTransform BP_SceneBindingContext_GetTransform(FContextualAnimSceneBindingContext BindingContext,FTransform ReturnValue) { return default; }
	public FVector BP_SceneBindingContext_GetVelocity(FContextualAnimSceneBindingContext BindingContext,FVector ReturnValue) { return default; }
	public UObject BP_SceneBinding_GetActor(FContextualAnimSceneBinding Binding,UObject ReturnValue) { return default; }
	public UObject BP_SceneBinding_GetSkeletalMesh(FContextualAnimSceneBinding Binding,UObject ReturnValue) { return default; }
}
