#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionWarpingComponent.h")]
public partial class UMotionWarpingUtilities : UBlueprintFunctionLibrary {
// MotionWarpingUtilities
	public FTransform ExtractRootMotionFromAnimation(UObject Animation,float StartTime,float EndTime,FTransform ReturnValue) { return default; }
	public void GetMotionWarpingWindowsFromAnimation(UObject Animation,TArray<FMotionWarpingWindowData> OutWindows) {}
	public void GetMotionWarpingWindowsForWarpTargetFromAnimation(UObject Animation,sbyte WarpTargetName,TArray<FMotionWarpingWindowData> OutWindows) {}
}
