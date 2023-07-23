#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetGuidLibrary.h")]
public partial class UKismetGuidLibrary : UBlueprintFunctionLibrary {
// KismetGuidLibrary
	public bool EqualEqual_GuidGuid(FGuid A,FGuid B,bool ReturnValue) { return default; }
	public bool NotEqual_GuidGuid(FGuid A,FGuid B,bool ReturnValue) { return default; }
	public bool IsValid_Guid(FGuid InGuid,bool ReturnValue) { return default; }
	public void Invalidate_Guid(FGuid InGuid) {}
	public FGuid NewGuid(FGuid ReturnValue) { return default; }
	public sbyte Conv_GuidToString(FGuid InGuid,sbyte ReturnValue) { return default; }
	public void Parse_StringToGuid(sbyte GuidString,FGuid OutGuid,bool Success) {}
}
