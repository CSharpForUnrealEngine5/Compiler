#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElement.h")]
public partial class ACompositingElement : AComposurePipelineBaseActor {
// CompositingElement
	public UComposureCompositingTargetComponent CompositingTarget;
	public UComposurePostProcessingPassProxy PostProcessProxy;
	public TArray<UCompositingElementInput> Inputs;
	public TArray<UCompositingElementTransform> TransformPasses;
	public TArray<UCompositingElementOutput> Outputs;
	public ESceneCameraLinkType CameraSource;
	public TLazyObjectPtr<ACameraActor> TargetCameraActor;
	public EInheritedSourceType ResolutionSource;
	public FIntPoint RenderResolution;
	public byte RenderFormat;
	public bool bUseSharedTargetPool;
	public int FreezeFrameMask;
	public EInheritedSourceType PreviewTransformSource;
	public UCompositingElementTransform PreviewTransform;
	public UClass DefaultInputType;
	public UClass DefaultTransformType;
	public UClass DefaultOutputType;
	public void SetElementName(sbyte NewName) {}
	public bool IsSubElement(bool ReturnValue) { return default; }
	public UObject GetElementParent(UObject ReturnValue) { return default; }
	public TArray<UObject> GetChildElements(TArray<UObject> ReturnValue) { return default; }
	public float GetOpacity(float ReturnValue) { return default; }
	public void SetOpacity(float NewOpacity) {}
	public void SetEditorColorPickingTarget(UObject PickingTarget) {}
	public void SetEditorColorPickerDisplayImage(UObject PickerDisplayImage) {}
	public UObject RenderCompElement(bool bCameraCutThisFrame,UObject ReturnValue) { return default; }
	public FDynamicOnTransformPassRendered OnTransformPassRendered_BP;
	public FDynamicOnFinalPassRendered OnFinalPassRendered_BP;
	public sbyte GetCompElementName(sbyte ReturnValue) { return default; }
	public UObject RequestNamedRenderTarget(sbyte ReferenceName,float RenderPercentage=1.f,ETargetUsageFlags UsageTag=ETargetUsageFlags,UObject ReturnValue) { return default; }
	public bool ReleaseOwnedTarget(UObject OwnedTarget,bool ReturnValue) { return default; }
	public UObject RenderCompositingMaterial(FCompositingMaterial CompMaterial,float RenderScale=1.f,sbyte ResultLookupName=NAME_None,ETargetUsageFlags UsageTag=ETargetUsageFlags,UObject ReturnValue) { return default; }
	public UObject RenderCompositingMaterialToTarget(FCompositingMaterial CompMaterial,UObject RenderTarget,sbyte ResultLookupName=NAME_None,UObject ReturnValue) { return default; }
	public UObject FindTargetCamera(UObject ReturnValue) { return default; }
	public void SetTargetCamera(UObject NewCameraActor) {}
	public void RegisterPassResult(sbyte ReferenceName,UObject PassResult,bool bSetAsLatestRenderResult=true) {}
	public UObject FindNamedRenderResult(sbyte PassName,bool bSearchSubElements=true,UObject ReturnValue) { return default; }
	public UObject GetLatestRenderResult(UObject ReturnValue) { return default; }
	public FIntPoint GetRenderResolution(FIntPoint ReturnValue) { return default; }
	public void SetRenderResolution(FIntPoint NewResolution) {}
	public UObject FindInputPass(UClass InputType,UObject PassResult,sbyte OptionalPassName=NAME_None,UObject ReturnValue) { return default; }
	public UObject FindTransformPass(UClass TransformType,UObject PassResult,sbyte OptionalPassName=NAME_None,UObject ReturnValue) { return default; }
	public UObject FindOutputPass(UClass OutputType,sbyte OptionalPassName=NAME_None,UObject ReturnValue) { return default; }
	public TArray<UObject> GetInputsList(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetTransformsList(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetOutputsList(TArray<UObject> ReturnValue) { return default; }
	public bool DeletePass(UObject PassToDelete,bool ReturnValue) { return default; }
	public UObject CreateNewInputPass(sbyte PassName,UClass InputType,UObject ReturnValue) { return default; }
	public UObject CreateNewTransformPass(sbyte PassName,UClass TransformType,UObject ReturnValue) { return default; }
	public UObject CreateNewOutputPass(sbyte PassName,UClass OutputType,UObject ReturnValue) { return default; }
	public UObject AddNewInputPass(sbyte PassName,UClass InputType,UObject ReturnValue) { return default; }
	public UObject AddNewTransformPass(sbyte PassName,UClass TransformType,UObject ReturnValue) { return default; }
	public UObject AddNewOutputPass(sbyte PassName,UClass OutputType,UObject ReturnValue) { return default; }
	public int GetRenderPriority(int ReturnValue) { return default; }
	public sbyte CompShotIdName;
	public ACompositingElement Parent;
	public TArray<ACompositingElement> ChildLayers;
	public UTexture DisabledMsgImage;
	public UTexture EmptyWarnImage;
	public UTexture SuspendedDbgImage;
	public UTexture CompilerErrImage;
	public bool bUsingDebugDisplayImage;
	public UTexture ColorPickerDisplayImage;
	public UTexture EditorPreviewImage;
	public UTextureRenderTarget2D ColorPickerTarget;
	public float OutputOpacity;
	public TMap<UCompositingElementInput,ECompPassConstructionType> UserConstructedInputs;
	public TMap<UCompositingElementTransform,ECompPassConstructionType> UserConstructedTransforms;
	public TMap<UCompositingElementOutput,ECompPassConstructionType> UserConstructedOutputs;
	public TArray<UCompositingElementInput> InternalInputs;
	public TArray<UCompositingElementTransform> InternalTransformPasses;
	public TArray<UCompositingElementOutput> InternalOutputs;
	public UAlphaTransformPass InternalAlphaPass;
}
