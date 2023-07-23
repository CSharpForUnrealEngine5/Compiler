#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkBlueprintLibrary.h")]
public partial class ULiveLinkBlueprintLibrary : UBlueprintFunctionLibrary {
// LiveLinkBlueprintLibrary
	public bool GetPropertyValue(FLiveLinkBasicBlueprintData BasicData,sbyte PropertyName,float Value,bool ReturnValue) { return default; }
	public void GetCurves(FSubjectFrameHandle SubjectFrameHandle,TMap<sbyte,float> Curves) {}
	public int NumberOfTransforms(FSubjectFrameHandle SubjectFrameHandle,int ReturnValue) { return default; }
	public void TransformNames(FSubjectFrameHandle SubjectFrameHandle,TArray<sbyte> TransformNames) {}
	public void GetRootTransform(FSubjectFrameHandle SubjectFrameHandle,FLiveLinkTransform LiveLinkTransform) {}
	public void GetTransformByIndex(FSubjectFrameHandle SubjectFrameHandle,int TransformIndex,FLiveLinkTransform LiveLinkTransform) {}
	public void GetTransformByName(FSubjectFrameHandle SubjectFrameHandle,sbyte TransformName,FLiveLinkTransform LiveLinkTransform) {}
	public void GetMetadata(FSubjectFrameHandle SubjectFrameHandle,FSubjectMetadata Metadata) {}
	public void GetBasicData(FSubjectFrameHandle SubjectFrameHandle,FLiveLinkBasicBlueprintData BasicBlueprintData) {}
	public bool GetAnimationStaticData(FSubjectFrameHandle SubjectFrameHandle,FLiveLinkSkeletonStaticData AnimationStaticData,bool ReturnValue) { return default; }
	public bool GetAnimationFrameData(FSubjectFrameHandle SubjectFrameHandle,FLiveLinkAnimationFrameData AnimationFrameData,bool ReturnValue) { return default; }
	public void TransformName(FLiveLinkTransform LiveLinkTransform,sbyte Name) {}
	public void ParentBoneSpaceTransform(FLiveLinkTransform LiveLinkTransform,FTransform Transform) {}
	public void ComponentSpaceTransform(FLiveLinkTransform LiveLinkTransform,FTransform Transform) {}
	public bool HasParent(FLiveLinkTransform LiveLinkTransform,bool ReturnValue) { return default; }
	public void GetParent(FLiveLinkTransform LiveLinkTransform,FLiveLinkTransform Parent) {}
	public int ChildCount(FLiveLinkTransform LiveLinkTransform,int ReturnValue) { return default; }
	public void GetChildren(FLiveLinkTransform LiveLinkTransform,TArray<FLiveLinkTransform> Children) {}
	public bool IsSourceStillValid(FLiveLinkSourceHandle SourceHandle,bool ReturnValue) { return default; }
	public bool RemoveSource(FLiveLinkSourceHandle SourceHandle,bool ReturnValue) { return default; }
	public sbyte GetSourceStatus(FLiveLinkSourceHandle SourceHandle,sbyte ReturnValue) { return default; }
	public sbyte GetSourceType(FLiveLinkSourceHandle SourceHandle,sbyte ReturnValue) { return default; }
	public sbyte GetSourceMachineName(FLiveLinkSourceHandle SourceHandle,sbyte ReturnValue) { return default; }
	public sbyte GetSourceTypeFromGuid(FGuid SourceGuid,sbyte ReturnValue) { return default; }
	public TArray<FLiveLinkSubjectName> GetLiveLinkEnabledSubjectNames(bool bIncludeVirtualSubject,TArray<FLiveLinkSubjectName> ReturnValue) { return default; }
	public TArray<FLiveLinkSubjectKey> GetLiveLinkSubjects(bool bIncludeDisabledSubject,bool bIncludeVirtualSubject,TArray<FLiveLinkSubjectKey> ReturnValue) { return default; }
	public bool IsSpecificLiveLinkSubjectEnabled(FLiveLinkSubjectKey SubjectKey,bool bForThisFrame,bool ReturnValue) { return default; }
	public bool IsLiveLinkSubjectEnabled(FLiveLinkSubjectName SubjectName,bool ReturnValue) { return default; }
	public void SetLiveLinkSubjectEnabled(FLiveLinkSubjectKey SubjectKey,bool bEnabled) {}
	public UClass GetSpecificLiveLinkSubjectRole(FLiveLinkSubjectKey SubjectKey,UClass ReturnValue) { return default; }
	public UClass GetLiveLinkSubjectRole(FLiveLinkSubjectName SubjectName,UClass ReturnValue) { return default; }
	public bool EvaluateLiveLinkFrame(FLiveLinkSubjectRepresentation SubjectRepresentation,FLiveLinkBaseBlueprintData OutBlueprintData,bool ReturnValue) { return default; }
	public bool EvaluateLiveLinkFrameWithSpecificRole(FLiveLinkSubjectName SubjectName,UClass Role,FLiveLinkBaseBlueprintData OutBlueprintData,bool ReturnValue) { return default; }
	public bool EvaluateLiveLinkFrameAtWorldTimeOffset(FLiveLinkSubjectName SubjectName,UClass Role,float WorldTimeOffset,FLiveLinkBaseBlueprintData OutBlueprintData,bool ReturnValue) { return default; }
	public bool EvaluateLiveLinkFrameAtSceneTime(FLiveLinkSubjectName SubjectName,UClass Role,FTimecode SceneTime,FLiveLinkBaseBlueprintData OutBlueprintData,bool ReturnValue) { return default; }
}
