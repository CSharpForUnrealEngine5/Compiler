#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VariantManagerTestActor.h")]
public partial class AVariantManagerTestActor : AActor {
// VariantManagerTestActor
	public EVariantManagerTestEnum EnumWithNoDefault;
	public EVariantManagerTestEnum EnumWithSecondDefault;
	public byte CapturedByteProperty;
	public int CapturedIntProperty;
	public float CapturedFloatProperty;
	public bool bCapturedBoolProperty;
	public UObject CapturedObjectProperty;
	public object /*CapturedInterfaceProperty*/ CapturedInterfaceProperty;
	public sbyte CapturedNameProperty;
	public sbyte CapturedStrProperty;
	public sbyte CapturedTextProperty;
	public FRotator CapturedRotatorProperty;
	public FColor CapturedColorProperty;
	public FLinearColor CapturedLinearColorProperty;
	public FVector CapturedVectorProperty;
	public FQuat CapturedQuatProperty;
	public FVector4 CapturedVector4Property;
	public FVector2D CapturedVector2DProperty;
	public FIntPoint CapturedIntPointProperty;
	public TArray<UObject> CapturedUObjectArrayProperty;
	public TArray<FVector> CapturedVectorArrayProperty;
}
