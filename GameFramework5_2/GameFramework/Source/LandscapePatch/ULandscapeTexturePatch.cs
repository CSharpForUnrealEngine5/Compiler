#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeTexturePatch.h")]
public partial class ULandscapeTexturePatch : ULandscapePatchComponent {
// LandscapeTexturePatch
	public FTransform GetPatchToWorldTransform(FTransform ReturnValue) { return default; }
	public FVector2D GetUnscaledCoverage(FVector2D ReturnValue) { return default; }
	public void SetUnscaledCoverage(FVector2D Coverage) {}
	public FVector2D GetFullUnscaledWorldSize(FVector2D ReturnValue) { return default; }
	public FVector2D GetResolution(FVector2D ReturnValue) { return default; }
	public void SetResolution(FVector2D ResolutionIn) {}
	public bool GetInitResolutionFromLandscape(float ResolutionMultiplier,FVector2D ResolutionOut,bool ReturnValue) { return default; }
	public void SetFalloff(float FalloffIn) {}
	public void SetBlendMode(ELandscapeTexturePatchBlendMode BlendModeIn) {}
	public ELandscapeTexturePatchSourceMode GetHeightSourceMode(ELandscapeTexturePatchSourceMode ReturnValue) { return default; }
	public void SetHeightSourceMode(ELandscapeTexturePatchSourceMode NewMode) {}
	public void SetHeightTextureAsset(UObject TextureIn) {}
	public UObject GetHeightRenderTarget(UObject ReturnValue) { return default; }
	public void SetHeightRenderTargetFormat(ETextureRenderTargetFormat Format) {}
	public void SetUseAlphaChannelForHeight(bool bUse) {}
	public void SetHeightEncodingMode(ELandscapeTextureHeightPatchEncoding EncodingMode) {}
	public void ResetHeightEncodingMode(ELandscapeTextureHeightPatchEncoding EncodingMode) {}
	public void SetHeightEncodingSettings(FLandscapeTexturePatchEncodingSettings Settings) {}
	public void SetZeroHeightMeaning(ELandscapeTextureHeightPatchZeroHeightMeaning ZeroHeightMeaningIn) {}
	public void AddWeightPatch(sbyte InWeightmapLayerName,ELandscapeTexturePatchSourceMode SourceMode,bool bUseAlphaChannel) {}
	public void RemoveWeightPatch(sbyte InWeightmapLayerName) {}
	public void RemoveAllWeightPatches() {}
	public void DisableAllWeightPatches() {}
	public TArray<sbyte> GetAllWeightPatchLayerNames(TArray<sbyte> ReturnValue) { return default; }
	public ELandscapeTexturePatchSourceMode GetWeightPatchSourceMode(sbyte InWeightmapLayerName,ELandscapeTexturePatchSourceMode ReturnValue) { return default; }
	public void SetWeightPatchSourceMode(sbyte InWeightmapLayerName,ELandscapeTexturePatchSourceMode NewMode) {}
	public void SetWeightPatchTextureAsset(sbyte InWeightmapLayerName,UObject TextureIn) {}
	public UObject GetWeightPatchRenderTarget(sbyte InWeightmapLayerName,UObject ReturnValue) { return default; }
	public void SetUseAlphaChannelForWeightPatch(sbyte InWeightmapLayerName,bool bUseAlphaChannel) {}
	public void SetWeightPatchBlendModeOverride(sbyte InWeightmapLayerName,ELandscapeTexturePatchBlendMode BlendMode) {}
	public void ClearWeightPatchBlendModeOverride(sbyte InWeightmapLayerName) {}
	public int ResolutionX;
	public int ResolutionY;
	public FVector2D UnscaledPatchCoverage;
	public ELandscapeTexturePatchBlendMode BlendMode;
	public ELandscapeTexturePatchFalloffMode FalloffMode;
	public float Falloff;
	public ELandscapeTexturePatchSourceMode HeightSourceMode;
	public ELandscapeTexturePatchSourceMode DetailPanelHeightSourceMode;
	public ULandscapeHeightTextureBackedRenderTarget HeightInternalData;
	public UTexture HeightTextureAsset;
	public bool bUseTextureAlphaForHeight;
	public ELandscapeTextureHeightPatchEncoding HeightEncoding;
	public FLandscapeTexturePatchEncodingSettings HeightEncodingSettings;
	public ELandscapeTextureHeightPatchZeroHeightMeaning ZeroHeightMeaning;
	public bool bApplyComponentZScale;
	public TArray<ULandscapeWeightPatchTextureInfo> WeightPatches;
	public int NumWeightPatches;
	public void ReinitializeHeight() {}
	public void ReinitializeWeights() {}
	public void SnapToLandscape() {}
	public bool bBaseResolutionOffLandscape;
	public float ResolutionMultiplier;
	public int InitTextureSizeX;
	public int InitTextureSizeY;
	public byte HeightRenderTargetFormat;
}
