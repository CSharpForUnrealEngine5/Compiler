#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundscapeSubsystem.h")]
public partial class USoundscapeSubsystem : UGameInstanceSubsystem {
// SoundscapeSubsystem
	public void SetState(FGameplayTag SoundscapeState) {}
	public void ClearState(FGameplayTag SoundscapeState) {}
	public void RestartSoundscape() {}
	public bool AddPaletteCollection(sbyte PaletteCollectionName,FSoundscapePaletteCollection PaletteCollection,bool ReturnValue) { return default; }
	public bool RemovePaletteCollection(sbyte PaletteCollectionName,bool ReturnValue) { return default; }
	public TSet<USoundscapePalette> LoadedPaletteCollectionSet;
	public TMap<sbyte,FSoundscapePaletteCollection> UnloadedPaletteCollections;
	public TMap<USoundscapePalette,UActiveSoundscapePalette> ActivePalettes;
	public void AddColorPointCollection(sbyte ColorPointCollectionName,FSoundscapeColorPointCollection ColorPointCollection) {}
	public bool RemoveColorPointCollection(sbyte ColorPointCollectionName,bool ReturnValue) { return default; }
	public int CheckColorPointDensity(FVector Location,FGameplayTag ColorPoint,int ReturnValue) { return default; }
	public TArray<USoundscapeColorPointHashMapCollection> ColorPointHashMapCollections;
	public USoundscapeColorPointHashMap ColorPointHashMapLOD1;
	public USoundscapeColorPointHashMap ColorPointHashMapLOD2;
	public USoundscapeColorPointHashMap ColorPointHashMapLOD3;
	public USoundscapeColorPointHashMap ActiveColorPointHashMap;
}
