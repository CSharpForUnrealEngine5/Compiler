#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelEditorSubsystem.h")]
///<summary>ULevelEditorSubsystem</summary>
public partial class ULevelEditorSubsystem : UEditorSubsystem {
// LevelEditorSubsystem
	public void PilotLevelActor(UObject ActorToPilot,sbyte ViewportConfigKey=NAME_None) {}
	public void EjectPilotLevelActor(sbyte ViewportConfigKey=NAME_None) {}
	public UObject GetPilotLevelActor(sbyte ViewportConfigKey=NAME_None,UObject ReturnValue) { return default; }
	public void EditorPlaySimulate() {}
	public void EditorInvalidateViewports() {}
	public void EditorSetGameView(bool bGameView,sbyte ViewportConfigKey=NAME_None) {}
	public bool EditorGetGameView(sbyte ViewportConfigKey=NAME_None,bool ReturnValue) { return default; }
	public void EditorRequestEndPlay() {}
	public bool IsInPlayInEditor(bool ReturnValue) { return default; }
	public TArray<sbyte> GetViewportConfigKeys(TArray<sbyte> ReturnValue) { return default; }
	public sbyte GetActiveViewportConfigKey(sbyte ReturnValue) { return default; }
	public void SetAllowsCinematicControl(bool bAllow,sbyte ViewportConfigKey=NAME_None) {}
	public bool GetAllowsCinematicControl(sbyte ViewportConfigKey=NAME_None,bool ReturnValue) { return default; }
	public bool NewLevel(sbyte AssetPath,bool ReturnValue) { return default; }
	public bool NewLevelFromTemplate(sbyte AssetPath,sbyte TemplateAssetPath,bool ReturnValue) { return default; }
	public bool LoadLevel(sbyte AssetPath,bool ReturnValue) { return default; }
	public bool SaveCurrentLevel(bool ReturnValue) { return default; }
	public bool SaveAllDirtyLevels(bool ReturnValue) { return default; }
	public bool SetCurrentLevelByName(sbyte LevelName,bool ReturnValue) { return default; }
	public UObject GetCurrentLevel(UObject ReturnValue) { return default; }
	public UObject GetSelectionSet(UObject ReturnValue) { return default; }
	public bool BuildLightMaps(ELightingBuildQuality Quality=ELightingBuildQuality,bool bWithReflectionCaptures=false,bool ReturnValue) { return default; }
	public FOnLevelEditorPreSaveWorld OnPreSaveWorld;
	public FOnLevelEditorPostSaveWorld OnPostSaveWorld;
	public FOnLevelEditorEditorCameraMoved OnEditorCameraMoved;
	public FOnLevelEditorMapChanged OnMapChanged;
	public FOnLevelEditorMapOpened OnMapOpened;
}
