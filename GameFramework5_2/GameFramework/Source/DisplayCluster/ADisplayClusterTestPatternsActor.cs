#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterTestPatternsActor.h")]
///<summary>Test patterns actor</summary>
public partial class ADisplayClusterTestPatternsActor : AActor {
// DisplayClusterTestPatternsActor
	public UPostProcessComponent PostProcessComponent;
	public TMap<sbyte,UMaterial> CalibrationPatterns;
	public TMap<sbyte,FPostProcessSettings> ViewportPPSettings;
}
