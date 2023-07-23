#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimationSettings.h")]
///<summary>Default animation settings.</summary>
public partial class UAnimationSettings : UDeveloperSettings {
// AnimationSettings
	public int CompressCommandletVersion;
	public TArray<sbyte> KeyEndEffectorsMatchNameArray;
	public bool ForceRecompression;
	public bool bForceBelowThreshold;
	public bool bFirstRecompressUsingCurrentOrDefault;
	public bool bRaiseMaxErrorToExisting;
	public bool bEnablePerformanceLog;
	public bool bStripAnimationDataOnDedicatedServer;
	public bool bTickAnimationOnSkeletalMeshInit;
	public FTimecodeCustomAttributeNameSettings BoneTimecodeCustomAttributeNameSettings;
	public TArray<FCustomAttributeSetting> BoneCustomAttributesNames;
	public TArray<sbyte> GetBoneCustomAttributeNamesToImport(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> BoneNamesWithCustomAttributes;
	public TMap<sbyte,ECustomAttributeBlendType> AttributeBlendModes;
	public ECustomAttributeBlendType DefaultAttributeBlendMode;
	public TArray<sbyte> TransformAttributeNames;
	public TArray<TSoftObjectPtr<UUserDefinedStruct>> UserDefinedStructAttributes;
	public TArray<FMirrorFindReplaceExpression> MirrorFindReplaceExpressions;
	public FFrameRate DefaultFrameRate;
}
