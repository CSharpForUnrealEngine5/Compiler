#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMultiMeshAttributeMapsTool.h")]
public partial class UBakeMultiMeshInputToolProperties : UInteractiveToolPropertySet {
// BakeMultiMeshInputToolProperties
	public UStaticMesh TargetStaticMesh;
	public USkeletalMesh TargetSkeletalMesh;
	public AActor TargetDynamicMesh;
	public sbyte TargetUVLayer;
	public TArray<FBakeMultiMeshDetailProperties> SourceMeshes;
	public float ProjectionDistance;
	public TArray<sbyte> GetTargetUVLayerNamesFunc(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> TargetUVLayerNamesList;
}
