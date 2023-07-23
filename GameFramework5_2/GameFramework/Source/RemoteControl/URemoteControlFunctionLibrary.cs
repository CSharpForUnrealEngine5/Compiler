#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlFunctionLibrary.h")]
public partial class URemoteControlFunctionLibrary : UBlueprintFunctionLibrary {
// RemoteControlFunctionLibrary
	public bool ExposeProperty(UObject Preset,UObject SourceObject,sbyte Property,FRemoteControlOptionalExposeArgs Args,bool ReturnValue) { return default; }
	public bool ExposeFunction(UObject Preset,UObject SourceObject,sbyte Function,FRemoteControlOptionalExposeArgs Args,bool ReturnValue) { return default; }
	public bool ExposeActor(UObject Preset,UObject Actor,FRemoteControlOptionalExposeArgs Args,bool ReturnValue) { return default; }
	public bool ApplyColorWheelDelta(UObject TargetObject,sbyte PropertyName,FColorWheelColor DeltaValue,FColorWheelColor ReferenceColor,bool bIsInteractive,bool ReturnValue) { return default; }
	public bool ApplyColorGradingWheelDelta(UObject TargetObject,sbyte PropertyName,FColorGradingWheelColor DeltaValue,FColorGradingWheelColor ReferenceColor,bool bIsInteractive,float MinValue=0.f,float MaxValue=2.f,bool ReturnValue) { return default; }
}
