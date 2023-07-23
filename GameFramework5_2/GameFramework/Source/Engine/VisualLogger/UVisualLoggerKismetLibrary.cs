#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VisualLogger/VisualLoggerKismetLibrary.h")]
public partial class UVisualLoggerKismetLibrary : UBlueprintFunctionLibrary {
// VisualLoggerKismetLibrary
	public void EnableRecording(bool bEnabled) {}
	public void RedirectVislog(UObject SourceOwner,UObject DestinationOwner) {}
	public void LogText(UObject WorldContextObject,sbyte Text,sbyte LogCategory=TEXT,bool bAddToMessageLog=false) {}
	public void LogLocation(UObject WorldContextObject,FVector Location,sbyte Text,FLinearColor ObjectColor=FLinearColor,float Radius=10,sbyte LogCategory=TEXT,bool bAddToMessageLog=false) {}
	public void LogBox(UObject WorldContextObject,FBox BoxShape,sbyte Text,FLinearColor ObjectColor=FLinearColor,sbyte LogCategory=TEXT,bool bAddToMessageLog=false) {}
	public void LogSegment(UObject WorldContextObject,FVector SegmentStart,FVector SegmentEnd,sbyte Text,FLinearColor ObjectColor=FLinearColor,float Thickness=0.f,sbyte CategoryName=TEXT,bool bAddToMessageLog=false) {}
}
