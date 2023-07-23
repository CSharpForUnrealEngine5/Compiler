#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkComponent.h")]
///<summary>An actor component to enable accessing LiveLink data in Blueprints.</summary>
public partial class ULiveLinkComponent : UActorComponent {
// LiveLinkComponent
	public FLiveLinkTickSignature OnLiveLinkUpdated;
	public void GetAvailableSubjectNames(TArray<sbyte> SubjectNames) {}
	public void GetSubjectData(sbyte SubjectName,bool bSuccess,FSubjectFrameHandle SubjectFrameHandle) {}
	public void GetSubjectDataAtWorldTime(sbyte SubjectName,float WorldTime,bool bSuccess,FSubjectFrameHandle SubjectFrameHandle) {}
	public void GetSubjectDataAtSceneTime(sbyte SubjectName,FTimecode SceneTime,bool bSuccess,FSubjectFrameHandle SubjectFrameHandle) {}
}
