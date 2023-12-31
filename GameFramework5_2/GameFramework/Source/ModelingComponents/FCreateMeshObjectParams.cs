#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ModelingObjectsCreationAPI.h")]
///<summary>FCreateMeshObjectParams is a collection of input data intended to be passed to</summary>
public partial struct FCreateMeshObjectParams {
// CreateMeshObjectParams
	public UPrimitiveComponent SourceComponent;
	public ECreateObjectTypeHint TypeHint;
	public UClass TypeHintClass;
	public int TypeHintExtended;
	public UWorld TargetWorld;
	public FTransform Transform;
	public string BaseName;
	public TArray<UMaterialInterface> Materials;
	public TArray<UMaterialInterface> AssetMaterials;
	public bool bEnableCollision;
	public byte CollisionMode;
	public bool bEnableRaytracingSupport;
	public bool bEnableRecomputeNormals;
	public bool bEnableRecomputeTangents;
	public bool bEnableNanite;
	public float NaniteProxyTrianglePercent_DEPRECATED;
	public FMeshNaniteSettings NaniteSettings;
}
