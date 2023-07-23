#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Types/TargetingSystemTypes.h")]
///<summary>@struct FTargetingDebugData</summary>
public partial struct FTargetingDebugData {
// TargetingDebugData
	public UTargetingPreset TargetingPreset;
	public TMap<sbyte,sbyte> DebugScratchPadStrings;
	public TArray<FTargetingDefaultResultData> CachedTargetResults;
}
