#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigComponent.h")]
///<summary>A component that hosts an animation ControlRig, manages control components and marshals data between the two</summary>
public partial class UControlRigComponent : UPrimitiveComponent {
// ControlRigComponent
	public UClass ControlRigClass;
	public FControlRigComponentDelegate OnPreInitializeDelegate;
	public FControlRigComponentDelegate OnPostInitializeDelegate;
	public FControlRigComponentDelegate OnPreConstructionDelegate;
	public FControlRigComponentDelegate OnPostConstructionDelegate;
	public FControlRigComponentDelegate OnPreForwardsSolveDelegate;
	public FControlRigComponentDelegate OnPostForwardsSolveDelegate;
	public UObject GetControlRig(UObject ReturnValue) { return default; }
	public bool CanExecute(bool ReturnValue) { return default; }
	public float GetAbsoluteTime(float ReturnValue) { return default; }
	public void OnPreInitialize(UObject Component) {}
	public void OnPostInitialize(UObject Component) {}
	public void OnPreConstruction(UObject Component) {}
	public void OnPostConstruction(UObject Component) {}
	public void OnPreForwardsSolve(UObject Component) {}
	public void OnPostForwardsSolve(UObject Component) {}
	public void Initialize() {}
	public void Update(float DeltaTime=0.f) {}
	public TArray<FControlRigComponentMappedElement> UserDefinedElements;
	public TArray<FControlRigComponentMappedElement> MappedElements;
	public void ClearMappedElements() {}
	public void SetMappedElements(TArray<FControlRigComponentMappedElement> NewMappedElements) {}
	public void AddMappedElements(TArray<FControlRigComponentMappedElement> NewMappedElements) {}
	public void AddMappedComponents(TArray<FControlRigComponentMappedComponent> Components) {}
	public void AddMappedSkeletalMesh(UObject SkeletalMeshComponent,TArray<FControlRigComponentMappedBone> Bones,TArray<FControlRigComponentMappedCurve> Curves) {}
	public void AddMappedCompleteSkeletalMesh(UObject SkeletalMeshComponent) {}
	public void SetBoneInitialTransformsFromSkeletalMesh(UObject InSkeletalMesh) {}
	public bool bEnableLazyEvaluation;
	public float LazyEvaluationPositionThreshold;
	public float LazyEvaluationRotationThreshold;
	public float LazyEvaluationScaleThreshold;
	public bool bResetTransformBeforeTick;
	public bool bResetInitialsBeforeConstruction;
	public bool bUpdateRigOnTick;
	public bool bUpdateInEditor;
	public bool bDrawBones;
	public bool bShowDebugDrawing;
	public TArray<sbyte> GetElementNames(ERigElementType ElementType=ERigElementType,TArray<sbyte> ReturnValue) { return default; }
	public bool DoesElementExist(sbyte Name,ERigElementType ElementType=ERigElementType,bool ReturnValue) { return default; }
	public FTransform GetBoneTransform(sbyte BoneName,EControlRigComponentSpace Space=EControlRigComponentSpace,FTransform ReturnValue) { return default; }
	public FTransform GetInitialBoneTransform(sbyte BoneName,EControlRigComponentSpace Space=EControlRigComponentSpace,FTransform ReturnValue) { return default; }
	public void SetBoneTransform(sbyte BoneName,FTransform Transform,EControlRigComponentSpace Space=EControlRigComponentSpace,float Weight=1.f,bool bPropagateToChildren=true) {}
	public void SetInitialBoneTransform(sbyte BoneName,FTransform InitialTransform,EControlRigComponentSpace Space=EControlRigComponentSpace,bool bPropagateToChildren=false) {}
	public bool GetControlBool(sbyte ControlName,bool ReturnValue) { return default; }
	public float GetControlFloat(sbyte ControlName,float ReturnValue) { return default; }
	public int GetControlInt(sbyte ControlName,int ReturnValue) { return default; }
	public FVector2D GetControlVector2D(sbyte ControlName,FVector2D ReturnValue) { return default; }
	public FVector GetControlPosition(sbyte ControlName,EControlRigComponentSpace Space=EControlRigComponentSpace,FVector ReturnValue) { return default; }
	public FRotator GetControlRotator(sbyte ControlName,EControlRigComponentSpace Space=EControlRigComponentSpace,FRotator ReturnValue) { return default; }
	public FVector GetControlScale(sbyte ControlName,EControlRigComponentSpace Space=EControlRigComponentSpace,FVector ReturnValue) { return default; }
	public FTransform GetControlTransform(sbyte ControlName,EControlRigComponentSpace Space=EControlRigComponentSpace,FTransform ReturnValue) { return default; }
	public void SetControlBool(sbyte ControlName,bool Value) {}
	public void SetControlFloat(sbyte ControlName,float Value) {}
	public void SetControlInt(sbyte ControlName,int Value) {}
	public void SetControlVector2D(sbyte ControlName,FVector2D Value) {}
	public void SetControlPosition(sbyte ControlName,FVector Value,EControlRigComponentSpace Space=EControlRigComponentSpace) {}
	public void SetControlRotator(sbyte ControlName,FRotator Value,EControlRigComponentSpace Space=EControlRigComponentSpace) {}
	public void SetControlScale(sbyte ControlName,FVector Value,EControlRigComponentSpace Space=EControlRigComponentSpace) {}
	public void SetControlTransform(sbyte ControlName,FTransform Value,EControlRigComponentSpace Space=EControlRigComponentSpace) {}
	public FTransform GetControlOffset(sbyte ControlName,EControlRigComponentSpace Space=EControlRigComponentSpace,FTransform ReturnValue) { return default; }
	public void SetControlOffset(sbyte ControlName,FTransform OffsetTransform,EControlRigComponentSpace Space=EControlRigComponentSpace) {}
	public FTransform GetSpaceTransform(sbyte SpaceName,EControlRigComponentSpace Space=EControlRigComponentSpace,FTransform ReturnValue) { return default; }
	public FTransform GetInitialSpaceTransform(sbyte SpaceName,EControlRigComponentSpace Space=EControlRigComponentSpace,FTransform ReturnValue) { return default; }
	public void SetInitialSpaceTransform(sbyte SpaceName,FTransform InitialTransform,EControlRigComponentSpace Space=EControlRigComponentSpace) {}
	public void SetControlRigClass(UClass InControlRigClass) {}
	public void SetObjectBinding(UObject InObjectToBind) {}
	public UControlRig ControlRig;
}
