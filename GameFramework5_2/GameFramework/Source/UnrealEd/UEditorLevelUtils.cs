#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorLevelUtils.h")]
public partial class UEditorLevelUtils : UObject {
// EditorLevelUtils
	public UObject CreateNewStreamingLevel(UClass LevelStreamingClass,sbyte NewLevelPath=TEXT,bool bMoveSelectedActorsIntoNewLevel=false,UObject ReturnValue) { return default; }
	public void MakeLevelCurrent(UObject InStreamingLevel) {}
	public int MoveActorsToLevel(TArray<UObject> ActorsToMove,UObject DestStreamingLevel,bool bWarnAboutReferences=true,bool bWarnAboutRenaming=true,int ReturnValue) { return default; }
	public int MoveSelectedActorsToLevel(UObject DestLevel,bool bWarnAboutReferences=true,int ReturnValue) { return default; }
	public UObject K2_AddLevelToWorld(UObject World,sbyte LevelPackageName,UClass LevelStreamingClass,UObject ReturnValue) { return default; }
	public UObject K2_AddLevelToWorldWithTransform(UObject World,sbyte LevelPackageName,UClass LevelStreamingClass,FTransform LevelTransform,UObject ReturnValue) { return default; }
	public void SetLevelVisibility(UObject Level,bool bShouldBeVisible,bool bForceLayersVisible,ELevelVisibilityDirtyMode ModifyMode=ELevelVisibilityDirtyMode) {}
	public void SetLevelsVisibility(TArray<UObject> Levels,TArray<bool> bShouldBeVisible,bool bForceLayersVisible,ELevelVisibilityDirtyMode ModifyMode=ELevelVisibilityDirtyMode) {}
	public TArray<UObject> GetLevels(UObject World,TArray<UObject> ReturnValue) { return default; }
}
