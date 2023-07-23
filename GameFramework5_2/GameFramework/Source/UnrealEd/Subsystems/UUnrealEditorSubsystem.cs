#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Subsystems/UnrealEditorSubsystem.h")]
///<summary>UUnrealEditorSubsystem</summary>
public partial class UUnrealEditorSubsystem : UEditorSubsystem {
// UnrealEditorSubsystem
	public bool GetLevelViewportCameraInfo(FVector CameraLocation,FRotator CameraRotation,bool ReturnValue) { return default; }
	public void SetLevelViewportCameraInfo(FVector CameraLocation,FRotator CameraRotation) {}
	public UObject GetEditorWorld(UObject ReturnValue) { return default; }
	public UObject GetGameWorld(UObject ReturnValue) { return default; }
}
