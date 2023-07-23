#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeToolCommon.h")]
public partial class UBakeInputMeshProperties : UInteractiveToolPropertySet {
// BakeInputMeshProperties
	public UStaticMesh TargetStaticMesh;
	public USkeletalMesh TargetSkeletalMesh;
	public AActor TargetDynamicMesh;
	public sbyte TargetUVLayer;
	public bool bHasTargetUVLayer;
	public UStaticMesh SourceStaticMesh;
	public USkeletalMesh SourceSkeletalMesh;
	public AActor SourceDynamicMesh;
	public bool bHideSourceMesh;
	public UTexture2D SourceNormalMap;
	public sbyte SourceNormalMapUVLayer;
	public EBakeNormalSpace SourceNormalSpace;
	public bool bHasSourceNormalMap;
	public float ProjectionDistance;
	public bool bProjectionInWorldSpace;
	public TArray<sbyte> GetTargetUVLayerNamesFunc(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> TargetUVLayerNamesList;
	public TArray<sbyte> GetSourceUVLayerNamesFunc(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> SourceUVLayerNamesList;
}
