#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialInterface.h")]
public partial class UMaterialInterface : UObject {
// MaterialInterface
	public UMaterialInterfaceEditorOnlyData EditorOnlyData;
	public USubsurfaceProfile SubsurfaceProfile;
	public FLightmassMaterialInterfaceSettings LightmassSettings;
	public bool bTextureStreamingDataSorted;
	public int TextureStreamingDataVersion;
	public TArray<FMaterialTextureInfo> TextureStreamingData;
	public TArray<UAssetUserData> AssetUserData;
	public TArray<FMaterialTextureInfo> TextureStreamingDataMissingEntries;
	public FSoftObjectPath PreviewMesh;
	public UThumbnailInfo ThumbnailInfo;
	public TMap<sbyte,bool> LayerParameterExpansion;
	public TMap<sbyte,bool> ParameterOverviewExpansion;
	public UAssetImportData AssetImportData;
	public FGuid LightingGuid;
	public UObject GetBaseMaterial(UObject ReturnValue) { return default; }
	public UObject GetPhysicalMaterial(UObject ReturnValue) { return default; }
	public UObject GetPhysicalMaterialMask(UObject ReturnValue) { return default; }
	public UObject GetPhysicalMaterialFromMap(int Index,UObject ReturnValue) { return default; }
	public FMaterialParameterInfo GetParameterInfo(EMaterialParameterAssociation Association,sbyte ParameterName,UObject LayerFunction,FMaterialParameterInfo ReturnValue) { return default; }
	public EBlendMode GetBlendMode(EBlendMode ReturnValue) { return default; }
	public void SetForceMipLevelsToBeResident(bool OverrideForceMiplevelsToBeResident,bool bForceMiplevelsToBeResidentValue,float ForceDuration,int CinematicTextureGroups=0,bool bFastResponse=false) {}
}
