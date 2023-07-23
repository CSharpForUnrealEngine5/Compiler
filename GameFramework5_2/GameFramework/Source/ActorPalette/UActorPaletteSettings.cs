#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorPaletteSettings.h")]
///<summary>Settings/preferences for Actor Palettes</summary>
public partial class UActorPaletteSettings : UDeveloperSettings {
// ActorPaletteSettings
	public TArray<FActorPaletteMapEntry> SettingsPerLevel;
	public TArray<sbyte> RecentlyUsedList;
	public TArray<sbyte> MostRecentLevelByTab;
	public TArray<sbyte> FavoritesList;
	public int NumRecentLevelsToKeep;
}
