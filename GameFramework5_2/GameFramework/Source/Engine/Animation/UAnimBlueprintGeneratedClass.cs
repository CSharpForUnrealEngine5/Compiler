#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimBlueprintGeneratedClass.h")]
public partial class UAnimBlueprintGeneratedClass : UBlueprintGeneratedClass {
// AnimBlueprintGeneratedClass
	public TArray<FBakedAnimationStateMachine> BakedStateMachines;
	public USkeleton TargetSkeleton;
	public TArray<FAnimNotifyEvent> AnimNotifies;
	public TMap<sbyte,FCachedPoseIndices> OrderedSavedPoseIndicesMap;
	public TArray<sbyte> SyncGroupNames;
	public TArray<FExposedValueHandler> EvaluateGraphExposedInputs_DEPRECATED;
	public TMap<sbyte,FGraphAssetPlayerInformation> GraphAssetPlayerInformation;
	public TMap<sbyte,FAnimGraphBlendOptions> GraphBlendOptions;
	public TArray<FAnimNodeData> AnimNodeData;
	public TMap<UScriptStruct,FAnimNodeStructData> NodeTypeMap;
}
