#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargetProfile.h")]
public partial struct FRetargetProfile {
// RetargetProfile
	public bool bApplyTargetRetargetPose;
	public sbyte TargetRetargetPoseName;
	public bool bApplySourceRetargetPose;
	public sbyte SourceRetargetPoseName;
	public bool bApplyChainSettings;
	public TMap<sbyte,FTargetChainSettings> ChainSettings;
	public bool bApplyRootSettings;
	public FTargetRootSettings RootSettings;
	public bool bApplyGlobalSettings;
	public FRetargetGlobalSettings GlobalSettings;
}
