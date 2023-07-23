#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VariantSet.h")]
public partial class UVariantSet : UObject {
// VariantSet
	public UObject GetParent(UObject ReturnValue) { return default; }
	public void SetDisplayText(sbyte NewDisplayText) {}
	public sbyte GetDisplayText(sbyte ReturnValue) { return default; }
	public int GetNumVariants(int ReturnValue) { return default; }
	public UObject GetVariant(int VariantIndex,UObject ReturnValue) { return default; }
	public UObject GetVariantByName(sbyte VariantName,UObject ReturnValue) { return default; }
	public void SetThumbnailFromTexture(UObject NewThumbnail) {}
	public void SetThumbnailFromFile(sbyte FilePath) {}
	public void SetThumbnailFromCamera(UObject WorldContextObject,FTransform CameraTransform,float FOVDegrees=50.0f,float MinZ=50.0f,float Gamma=2.2f) {}
	public void SetThumbnailFromEditorViewport() {}
	public UObject GetThumbnail(UObject ReturnValue) { return default; }
	public sbyte DisplayText_DEPRECATED;
	public bool bExpanded;
	public TArray<UVariant> Variants;
	public UTexture2D Thumbnail;
}
