#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneDataLayerSection.h")]
public partial class UMovieSceneDataLayerSection : UMovieSceneSection {
// MovieSceneDataLayerSection
	public EDataLayerRuntimeState GetDesiredState(EDataLayerRuntimeState ReturnValue) { return default; }
	public void SetDesiredState(EDataLayerRuntimeState InDesiredState) {}
	public EDataLayerRuntimeState GetPrerollState(EDataLayerRuntimeState ReturnValue) { return default; }
	public void SetPrerollState(EDataLayerRuntimeState InPrerollState) {}
	public bool GetFlushOnUnload(bool ReturnValue) { return default; }
	public void SetFlushOnUnload(bool bFlushOnUnload) {}
	public TArray<UObject> GetDataLayerAssets(TArray<UObject> ReturnValue) { return default; }
	public void SetDataLayerAssets(TArray<UObject> InDataLayerAssets) {}
	public TArray<FActorDataLayer> GetDataLayers(TArray<FActorDataLayer> ReturnValue) { return default; }
	public void SetDataLayers(TArray<FActorDataLayer> InDataLayers) {}
	public TArray<FActorDataLayer> DataLayers;
	public TArray<UDataLayerAsset> DataLayerAssets;
	public EDataLayerRuntimeState DesiredState;
	public EDataLayerRuntimeState PrerollState;
	public bool bFlushOnUnload;
}
