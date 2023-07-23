#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorTutorial.h")]
///<summary>A single tutorial stage, containing the optional main content & a number of widgets with content attached</summary>
public partial struct FTutorialStage {
// TutorialStage
	public sbyte Name;
	public FTutorialContent Content;
	public TArray<FTutorialWidgetContent> WidgetContent;
	public sbyte NextButtonText;
	public sbyte BackButtonText;
	public TArray<sbyte> PlatformsToTest;
	public bool bInvertPlatformTest;
}
