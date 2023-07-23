#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusFunctionLibrary.h")]
public partial struct FHmdUserProfile {
// HmdUserProfile
	public sbyte Name;
	public sbyte Gender;
	public float PlayerHeight;
	public float EyeHeight;
	public float IPD;
	public FVector2D NeckToEyeDistance;
	public TArray<FHmdUserProfileField> ExtraFields;
}
