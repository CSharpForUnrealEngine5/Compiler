#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SkinnedMeshComponent.h")]
///<summary>Skinned mesh component that supports bone skinned mesh rendering.</summary>
public partial class USkinnedMeshComponent : UMeshComponent {
// SkinnedMeshComponent
	public USkeletalMesh SkeletalMesh;
	public USkinnedAsset SkinnedAsset;
	public TWeakObjectPtr<USkinnedMeshComponent> LeaderPoseComponent;
	public TArray<ESkinCacheUsage> SkinCacheUsage;
	public bool bSetMeshDeformer;
	public UMeshDeformer MeshDeformer;
	public UMeshDeformerInstanceSettings MeshDeformerInstanceSettings;
	public UMeshDeformerInstance MeshDeformerInstance;
	public UObject GetMeshDeformerInstance(UObject ReturnValue) { return default; }
	public FColor WireframeColor_DEPRECATED;
	public UPhysicsAsset PhysicsAssetOverride;
	public int ForcedLodModel;
	public int MinLodModel;
	public float StreamingDistanceMultiplier;
	public TArray<FSkelMeshComponentLODInfo> LODInfo;
	public EVisibilityBasedAnimTickOption VisibilityBasedAnimTickOption;
	public bool bOverrideMinLod;
	public bool bUseBoundsFromLeaderPoseComponent;
	public bool bForceWireframe;
	public bool bDisplayBones_DEPRECATED;
	public bool bDisableMorphTarget;
	public bool bHideSkin;
	public bool bPerBoneMotionBlur;
	public bool bComponentUseFixedSkelBounds;
	public bool bConsiderAllBodiesForBounds;
	public bool bSyncAttachParentLOD;
	public bool bCanHighlightSelectedSections;
	public bool bRecentlyRendered;
	public bool bCastCapsuleDirectShadow;
	public bool bCastCapsuleIndirectShadow;
	public bool bCPUSkinning;
	public bool bEnableUpdateRateOptimizations;
	public bool bDisplayDebugUpdateRateOptimizations;
	public bool bRenderStatic;
	public bool bIgnoreLeaderPoseComponentLOD;
	public bool bCachedLocalBoundsUpToDate;
	public bool bCachedWorldSpaceBoundsUpToDate;
	public bool bForceMeshObjectUpdate;
	public bool bForceUpdateDynamicDataImmediately;
	public bool bFollowerShouldTickPose;
	public float CapsuleIndirectShadowMinVisibility;
	public void SetPhysicsAsset(UObject NewPhysicsAsset,bool bForceReInit=false) {}
	public int GetNumLODs(int ReturnValue) { return default; }
	public void SetMinLOD(int InNewMinLOD) {}
	public void SetForcedLOD(int InNewForcedLOD) {}
	public int GetForcedLOD(int ReturnValue) { return default; }
	public void SetCastCapsuleDirectShadow(bool bNewValue) {}
	public void SetCastCapsuleIndirectShadow(bool bNewValue) {}
	public void SetCapsuleIndirectShadowMinVisibility(float NewValue) {}
	public int GetNumBones(int ReturnValue) { return default; }
	public int GetBoneIndex(sbyte BoneName,int ReturnValue) { return default; }
	public sbyte GetBoneName(int BoneIndex,sbyte ReturnValue) { return default; }
	public sbyte GetSocketBoneName(sbyte InSocketName,sbyte ReturnValue) { return default; }
	public UObject GetSkeletalMesh_DEPRECATED(UObject ReturnValue) { return default; }
	public void SetSkinnedAssetAndUpdate(UObject NewMesh,bool bReinitPose=true) {}
	public UObject GetSkinnedAsset(UObject ReturnValue) { return default; }
	public void SetMeshDeformer(UObject InMeshDeformer) {}
	public void UnsetMeshDeformer() {}
	public sbyte GetParentBone(sbyte BoneName,sbyte ReturnValue) { return default; }
	public FTransform GetDeltaTransformFromRefPose(sbyte BoneName,sbyte BaseName=NAME_None,FTransform ReturnValue) { return default; }
	public bool GetTwistAndSwingAngleOfDeltaRotationFromRefPose(sbyte BoneName,float OutTwistAngle,float OutSwingAngle,bool ReturnValue) { return default; }
	public void SetVertexColorOverride_LinearColor(int LODIndex,TArray<FLinearColor> VertexColors) {}
	public void ClearVertexColorOverride(int LODIndex) {}
	public void SetSkinWeightOverride(int LODIndex,TArray<FSkelMeshSkinWeightInfo> SkinWeights) {}
	public void ClearSkinWeightOverride(int LODIndex) {}
	public bool SetSkinWeightProfile(sbyte InProfileName,bool ReturnValue) { return default; }
	public void ClearSkinWeightProfile() {}
	public void UnloadSkinWeightProfile(sbyte InProfileName) {}
	public sbyte GetCurrentSkinWeightProfileName(sbyte ReturnValue) { return default; }
	public bool IsUsingSkinWeightProfile(bool ReturnValue) { return default; }
	public int GetVertexOffsetUsage(int LODIndex,int ReturnValue) { return default; }
	public void SetVertexOffsetUsage(int LODIndex,int Usage) {}
	public void SetPreSkinningOffsets(int LODIndex,TArray<FVector> Offsets) {}
	public void SetPostSkinningOffsets(int LODIndex,TArray<FVector> Offsets) {}
	public int GetPredictedLODLevel(int ReturnValue) { return default; }
	public FBoxSphereBounds CachedWorldOrLocalSpaceBounds;
	public FMatrix CachedWorldToLocalTransform;
	public void SetLeaderPoseComponent(UObject NewLeaderBoneComponent,bool bForceUpdate=false,bool bInFollowerShouldTickPose=false) {}
	public bool BoneIsChildOf(sbyte BoneName,sbyte ParentBoneName,bool ReturnValue) { return default; }
	public FVector GetRefPosePosition(int BoneIndex,FVector ReturnValue) { return default; }
	public FTransform GetRefPoseTransform(int BoneIndex,FTransform ReturnValue) { return default; }
	public void TransformToBoneSpace(sbyte BoneName,FVector InPosition,FRotator InRotation,FVector OutPosition,FRotator OutRotation) {}
	public void TransformFromBoneSpace(sbyte BoneName,FVector InPosition,FRotator InRotation,FVector OutPosition,FRotator OutRotation) {}
	public sbyte FindClosestBone_K2(FVector TestLocation,FVector BoneLocation,float IgnoreScale=0.f,bool bRequirePhysicsAsset=false,sbyte ReturnValue) { return default; }
	public void HideBoneByName(sbyte BoneName,EPhysBodyOp PhysBodyOption) {}
	public void UnHideBoneByName(sbyte BoneName) {}
	public bool IsBoneHiddenByName(sbyte BoneName,bool ReturnValue) { return default; }
	public void ShowMaterialSection(int MaterialID,int SectionIndex,bool bShow,int LODIndex) {}
	public void ShowAllMaterialSections(int LODIndex) {}
	public bool IsMaterialSectionShown(int MaterialID,int LODIndex,bool ReturnValue) { return default; }
	public void SetRenderStatic(bool bNewValue) {}
}
