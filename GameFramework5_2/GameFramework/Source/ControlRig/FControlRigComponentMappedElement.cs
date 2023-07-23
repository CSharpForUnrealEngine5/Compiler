#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigComponent.h")]
public partial struct FControlRigComponentMappedElement {
// ControlRigComponentMappedElement
	public FComponentReference ComponentReference;
	public int TransformIndex;
	public sbyte TransformName;
	public ERigElementType ElementType;
	public sbyte ElementName;
	public EControlRigComponentMapDirection Direction;
	public FTransform Offset;
	public float Weight;
	public EControlRigComponentSpace Space;
	public USceneComponent SceneComponent;
	public int ElementIndex;
	public int SubIndex;
}
