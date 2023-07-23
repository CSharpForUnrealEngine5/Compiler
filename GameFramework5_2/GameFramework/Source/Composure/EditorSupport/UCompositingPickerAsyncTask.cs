#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorSupport/CompositingEditorSupportLibrary.h")]
public partial class UCompositingPickerAsyncTask : UBlueprintAsyncActionBase {
// CompositingPickerAsyncTask
	public UObject OpenCompositingPicker(UObject PickerTarget,UObject DisplayImage,sbyte WindowTitle,bool bAverageColorOnDrag=true,bool bUseImplicitGamma=true,UObject ReturnValue) { return default; }
	public FOnPixelPicked OnPick;
	public FOnPixelPicked OnCancel;
	public FOnPixelPicked OnAccept;
	public UTextureRenderTarget2D PickerTarget;
	public UTexture PickerDisplayImage;
}
