#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IKRigDefinition.h")]
public partial struct FBoneChain {
// BoneChain
	public sbyte ChainName;
	public FBoneReference StartBone;
	public FBoneReference EndBone;
	public sbyte IKGoalName;
}
