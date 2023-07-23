#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxImportUI.h")]
public partial class UFbxImportUI : UObject {
// FbxImportUI
	public bool bIsObjImport;
	public byte OriginalImportType;
	public byte MeshTypeToImport;
	public bool bOverrideFullName;
	public bool bImportAsSkeletal;
	public bool bImportMesh;
	public USkeleton Skeleton;
	public bool bCreatePhysicsAsset;
	public UPhysicsAsset PhysicsAsset;
	public bool bAutoComputeLodDistances;
	public float LodDistance0;
	public float LodDistance1;
	public float LodDistance2;
	public float LodDistance3;
	public float LodDistance4;
	public float LodDistance5;
	public float LodDistance6;
	public float LodDistance7;
	public int MinimumLodNumber;
	public int LodNumber;
	public bool bImportAnimations;
	public sbyte OverrideAnimationName;
	public bool bImportRigidMesh;
	public bool bImportMaterials;
	public bool bImportTextures;
	public bool bResetToFbxOnMaterialConflict;
	public UFbxStaticMeshImportData StaticMeshImportData;
	public UFbxSkeletalMeshImportData SkeletalMeshImportData;
	public UFbxAnimSequenceImportData AnimSequenceImportData;
	public UFbxTextureImportData TextureImportData;
	public bool bAutomatedImportShouldDetectType;
	public void ResetToDefault() {}
	public sbyte FileVersion;
	public sbyte FileCreator;
	public sbyte FileCreatorApplication;
	public sbyte FileUnits;
	public sbyte FileAxisDirection;
	public sbyte FileSampleRate;
	public sbyte AnimStartFrame;
	public sbyte AnimEndFrame;
}
