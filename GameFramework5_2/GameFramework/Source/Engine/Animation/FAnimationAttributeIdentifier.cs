#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimData/AttributeIdentifier.h")]
///<summary>Script-friendly structure for identifying an attribute (curve).</summary>
public partial struct FAnimationAttributeIdentifier {
// AnimationAttributeIdentifier
	public sbyte Name;
	public sbyte BoneName;
	public int BoneIndex;
	public UScriptStruct ScriptStruct;
	public FSoftObjectPath ScriptStructPath;
}
