#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AppleARKitFaceMeshComponent.h")]
///<summary>This component is updated by the ARSystem with face data on devices that have support for it</summary>
public partial class UAppleARKitFaceMeshComponent : UProceduralMeshComponent {
// AppleARKitFaceMeshComponent
	public void CreateMesh(TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector2D> UV0) {}
	public void SetBlendShapes(TMap<EARFaceBlendShape,float> InBlendShapes) {}
	public void SetBlendShapeAmount(EARFaceBlendShape BlendShape,float Amount) {}
	public float GetFaceBlendShapeAmount(EARFaceBlendShape BlendShape,float ReturnValue) { return default; }
	public void UpdateMeshFromBlendShapes() {}
	public void UpdateMesh(TArray<FVector> Vertices) {}
	public void SetAutoBind(bool bAutoBind) {}
	public int GetLastUpdateFrameNumber(int ReturnValue) { return default; }
	public float GetLastUpdateTimestamp(float ReturnValue) { return default; }
	public void PublishViaLiveLink(sbyte SubjectName) {}
	public FTransform GetTransform(FTransform ReturnValue) { return default; }
	public bool bWantsMeshUpdates;
	public bool bWantsCollision;
	public bool bAutoBindToLocalFaceMesh;
	public EARFaceComponentTransformMixing TransformSetting;
	public bool bFlipTrackedRotation;
	public UMaterialInterface FaceMaterial;
	public sbyte LiveLinkSubjectName;
	public TArray<FNetQuantizeFaceCurve> RemoteCurves;
	public void OnRep_RemoteCurves() {}
	public void ServerUpdateFaceCurves(TArray<FNetQuantizeFaceCurve> ClientCurves) {}
}
