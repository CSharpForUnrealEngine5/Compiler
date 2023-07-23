#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargeter.h")]
public partial class UIKRetargeter : UObject {
// IKRetargeter
	public FTargetChainSettings GetChainUsingGoalFromRetargetAsset(UObject RetargetAsset,sbyte IKGoalName,FTargetChainSettings ReturnValue) { return default; }
	public FTargetChainSettings GetChainSettingsFromRetargetAsset(UObject RetargetAsset,sbyte TargetChainName,sbyte OptionalProfileName,FTargetChainSettings ReturnValue) { return default; }
	public FTargetChainSettings GetChainSettingsFromRetargetProfile(FRetargetProfile RetargetProfile,sbyte TargetChainName,FTargetChainSettings ReturnValue) { return default; }
	public void GetRootSettingsFromRetargetAsset(UObject RetargetAsset,sbyte OptionalProfileName,FTargetRootSettings OutSettings) {}
	public FTargetRootSettings GetRootSettingsFromRetargetProfile(FRetargetProfile RetargetProfile,FTargetRootSettings ReturnValue) { return default; }
	public void GetGlobalSettingsFromRetargetAsset(UObject RetargetAsset,sbyte OptionalProfileName,FRetargetGlobalSettings OutSettings) {}
	public FRetargetGlobalSettings GetGlobalSettingsFromRetargetProfile(FRetargetProfile RetargetProfile,FRetargetGlobalSettings ReturnValue) { return default; }
	public void SetGlobalSettingsInRetargetProfile(FRetargetProfile RetargetProfile,FRetargetGlobalSettings GlobalSettings) {}
	public void SetRootSettingsInRetargetProfile(FRetargetProfile RetargetProfile,FTargetRootSettings RootSettings) {}
	public void SetChainSettingsInRetargetProfile(FRetargetProfile RetargetProfile,FTargetChainSettings ChainSettings,sbyte TargetChainName) {}
	public void SetChainFKSettingsInRetargetProfile(FRetargetProfile RetargetProfile,FTargetChainFKSettings FKSettings,sbyte TargetChainName) {}
	public void SetChainIKSettingsInRetargetProfile(FRetargetProfile RetargetProfile,FTargetChainIKSettings IKSettings,sbyte TargetChainName) {}
	public void SetChainSpeedPlantSettingsInRetargetProfile(FRetargetProfile RetargetProfile,FTargetChainSpeedPlantSettings SpeedPlantSettings,sbyte TargetChainName) {}
	public TSoftObjectPtr<UIKRigDefinition> SourceIKRigAsset;
	public TSoftObjectPtr<USkeletalMesh> SourcePreviewMesh;
	public TSoftObjectPtr<UIKRigDefinition> TargetIKRigAsset;
	public TSoftObjectPtr<USkeletalMesh> TargetPreviewMesh;
	public bool bRetargetRoot_DEPRECATED;
	public bool bRetargetFK_DEPRECATED;
	public bool bRetargetIK_DEPRECATED;
	public float TargetActorOffset_DEPRECATED;
	public float TargetActorScale_DEPRECATED;
	public FVector TargetMeshOffset;
	public float TargetMeshScale;
	public FVector SourceMeshOffset;
	public bool bDebugDraw;
	public bool bDrawFinalGoals;
	public bool bDrawSourceLocations;
	public float ChainDrawSize;
	public float ChainDrawThickness;
	public float BoneDrawSize;
	public UObject Controller;
	public TSet<USkeletalMesh> MeshesAskedToFixRootHeightFor;
	public TArray<FRetargetChainMap> ChainMapping_DEPRECATED;
	public TArray<URetargetChainSettings> ChainSettings;
	public URetargetRootSettings RootSettings;
	public UIKRetargetGlobalSettings GlobalSettings;
	public TMap<sbyte,FRetargetProfile> Profiles;
	public sbyte CurrentProfile;
	public TMap<sbyte,FIKRetargetPose> SourceRetargetPoses;
	public TMap<sbyte,FIKRetargetPose> TargetRetargetPoses;
	public sbyte CurrentSourceRetargetPose;
	public sbyte CurrentTargetRetargetPose;
	public TMap<sbyte,FIKRetargetPose> RetargetPoses_DEPRECATED;
	public sbyte CurrentRetargetPose_DEPRECATED;
}
