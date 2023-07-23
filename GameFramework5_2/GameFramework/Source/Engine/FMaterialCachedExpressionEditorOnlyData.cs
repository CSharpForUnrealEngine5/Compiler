#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialCachedData.h")]
public partial struct FMaterialCachedExpressionEditorOnlyData {
// MaterialCachedExpressionEditorOnlyData
	public FMaterialCachedParameterEntry EditorOnlyEntries;
	public FMaterialCachedParameterEditorEntry EditorEntries;
	public TArray<bool> StaticSwitchValues_DEPRECATED;
	public TArray<FStaticComponentMaskValue> StaticComponentMaskValues;
	public TArray<FVector2D> ScalarMinMaxValues;
	public TArray<TSoftObjectPtr<UCurveLinearColor>> ScalarCurveValues;
	public TArray<TSoftObjectPtr<UCurveLinearColorAtlas>> ScalarCurveAtlasValues;
	public TArray<FParameterChannelNames> VectorChannelNameValues;
	public TArray<bool> VectorUsedAsChannelMaskValues;
	public TArray<FParameterChannelNames> TextureChannelNameValues;
	public FMaterialLayersFunctionsEditorOnlyData MaterialLayers;
	public TArray<sbyte> AssetPaths;
	public TArray<sbyte> LandscapeLayerNames;
}
