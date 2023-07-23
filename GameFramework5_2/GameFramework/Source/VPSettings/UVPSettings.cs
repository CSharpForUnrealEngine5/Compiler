#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPSettings.h")]
public partial class UVPSettings : UObject {
// VPSettings
	public TArray<float> FocalLengthPresets;
	public TArray<float> AperturePresets;
	public TArray<float> DefaultShutterSpeedPresets;
	public TArray<float> DefaultISOPresets;
	public UObject GetVPSettings(UObject ReturnValue) { return default; }
	public bool bShowRoleInEditor;
	public sbyte DirectorName;
	public sbyte ShowName;
	public FGameplayTagContainer Roles;
}
