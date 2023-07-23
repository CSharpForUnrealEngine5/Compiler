#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorTutorial.h")]
///<summary>An asset used to build a stage-by-stage tutorial in the editor</summary>
public partial class UEditorTutorial : UObject {
// EditorTutorial
	public sbyte Title;
	public int SortOrder;
	public sbyte Icon;
	public UTexture2D Texture;
	public sbyte Category;
	public FTutorialContent SummaryContent;
	public TArray<FTutorialStage> Stages;
	public FSoftClassPath PreviousTutorial;
	public FSoftClassPath NextTutorial;
	public UObject GetActorReference(sbyte PathToActor,UObject ReturnValue) { return default; }
	public bool bIsStandalone;
	public FSoftObjectPath AssetToUse;
	public sbyte ImportPath;
	public bool bHideInBrowser;
	public sbyte SearchTags;
	public void OnTutorialStageStarted(sbyte StageName) {}
	public void OnTutorialStageEnded(sbyte StageName) {}
	public void OnTutorialLaunched() {}
	public void OnTutorialClosed() {}
	public void GoToNextTutorialStage() {}
	public void GoToPreviousTutorialStage() {}
	public void BeginTutorial(UObject TutorialToStart,bool bRestart) {}
	public void OpenAsset(UObject Asset) {}
	public void SetEngineFolderVisibilty(bool bNewVisibility) {}
	public bool GetEngineFolderVisibilty(bool ReturnValue) { return default; }
}
