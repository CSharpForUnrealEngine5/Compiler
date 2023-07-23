#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationBlueprintFunctionLibrary.h")]
public partial class UAutomationBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// AutomationBlueprintFunctionLibrary
	public void FinishLoadingBeforeScreenshot() {}
	public void TakeAutomationScreenshot(UObject WorldContextObject,FLatentActionInfo LatentInfo,sbyte Name,sbyte Notes,FAutomationScreenshotOptions Options) {}
	public void TakeAutomationScreenshotAtCamera(UObject WorldContextObject,FLatentActionInfo LatentInfo,UObject Camera,sbyte NameOverride,sbyte Notes,FAutomationScreenshotOptions Options) {}
	public void TakeAutomationScreenshotOfUI(UObject WorldContextObject,FLatentActionInfo LatentInfo,sbyte Name,FAutomationScreenshotOptions Options) {}
	public void EnableStatGroup(UObject WorldContextObject,sbyte GroupName) {}
	public void DisableStatGroup(UObject WorldContextObject,sbyte GroupName) {}
	public float GetStatIncAverage(sbyte StatName,float ReturnValue) { return default; }
	public float GetStatIncMax(sbyte StatName,float ReturnValue) { return default; }
	public float GetStatExcAverage(sbyte StatName,float ReturnValue) { return default; }
	public float GetStatExcMax(sbyte StatName,float ReturnValue) { return default; }
	public float GetStatCallCount(sbyte StatName,float ReturnValue) { return default; }
	public bool AreAutomatedTestsRunning(bool ReturnValue) { return default; }
	public void AutomationWaitForLoading(UObject WorldContextObject,FLatentActionInfo LatentInfo,FAutomationWaitForLoadingOptions Options) {}
	public UObject TakeHighResScreenshot(int ResX,int ResY,sbyte Filename,UObject Camera=nullptr,bool bMaskEnabled=false,bool bCaptureHDR=false,EComparisonTolerance ComparisonTolerance=EComparisonTolerance,sbyte ComparisonNotes=TEXT,float Delay=0.0,UObject ReturnValue) { return default; }
	public bool CompareImageAgainstReference(sbyte ImageFilePath,sbyte ComparisonName=TEXT,EComparisonTolerance ComparisonTolerance=EComparisonTolerance,sbyte ComparisonNotes=TEXT,UObject WorldContextObject=nullptr,bool ReturnValue) { return default; }
	public void AddTestTelemetryData(sbyte DataPoint,float Measurement,sbyte Context=TEXT) {}
	public void SetTestTelemetryStorage(sbyte StorageName) {}
	public FAutomationScreenshotOptions GetDefaultScreenshotOptionsForGameplay(EComparisonTolerance Tolerance=EComparisonTolerance,float Delay=0.2,FAutomationScreenshotOptions ReturnValue) { return default; }
	public FAutomationScreenshotOptions GetDefaultScreenshotOptionsForRendering(EComparisonTolerance Tolerance=EComparisonTolerance,float Delay=0.2,FAutomationScreenshotOptions ReturnValue) { return default; }
	public void AddExpectedLogError(sbyte ExpectedPatternString,int Occurrences=1,bool ExactMatch=false) {}
	public void SetScalabilityQualityLevelRelativeToMax(UObject WorldContextObject,int Value=1) {}
	public void SetScalabilityQualityToEpic(UObject WorldContextObject) {}
	public void SetScalabilityQualityToLow(UObject WorldContextObject) {}
	public void SetEditorViewportViewMode(EViewModeIndex Index) {}
	public void SetEditorViewportVisualizeBuffer(sbyte BufferName) {}
}
