#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MLDeformerInputInfo.h")]
///<summary>The neural network input information.</summary>
public partial class UMLDeformerInputInfo : UObject {
// MLDeformerInputInfo
	public FSoftObjectPath SkeletalMesh;
	public TArray<sbyte> BoneNameStrings_DEPRECATED;
	public TArray<sbyte> CurveNameStrings_DEPRECATED;
	public TArray<sbyte> BoneNames;
	public TArray<sbyte> CurveNames;
	public int NumBaseMeshVertices;
	public int NumTargetMeshVertices;
}
