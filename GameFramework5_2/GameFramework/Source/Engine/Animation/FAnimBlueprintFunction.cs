#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimClassInterface.h")]
///<summary>Describes the input and output of an anim blueprint 'function'</summary>
public partial struct FAnimBlueprintFunction {
// AnimBlueprintFunction
	public sbyte Name;
	public sbyte Group;
	public int OutputPoseNodeIndex;
	public TArray<sbyte> InputPoseNames;
	public TArray<int> InputPoseNodeIndices;
	public bool bImplemented;
}
