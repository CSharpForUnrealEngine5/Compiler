#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Variant.h")]
public partial class UVariant : UObject {
// Variant
	public UObject GetParent(UObject ReturnValue) { return default; }
	public void SetDisplayText(sbyte NewDisplayText) {}
	public sbyte GetDisplayText(sbyte ReturnValue) { return default; }
	public int GetNumActors(int ReturnValue) { return default; }
	public UObject GetActor(int ActorIndex,UObject ReturnValue) { return default; }
	public void SwitchOn() {}
	public bool IsActive(bool ReturnValue) { return default; }
	public void SetThumbnailFromTexture(UObject NewThumbnail) {}
	public void SetThumbnailFromFile(sbyte FilePath) {}
	public void SetThumbnailFromCamera(UObject WorldContextObject,FTransform CameraTransform,float FOVDegrees=50.0f,float MinZ=50.0f,float Gamma=2.2f) {}
	public void SetThumbnailFromEditorViewport() {}
	public UObject GetThumbnail(UObject ReturnValue) { return default; }
	public TArray<UObject> GetDependents(UObject LevelVariantSets,bool bOnlyEnabledDependencies,TArray<UObject> ReturnValue) { return default; }
	public int AddDependency(FVariantDependency Dependency,int ReturnValue) { return default; }
	public FVariantDependency GetDependency(int Index,FVariantDependency ReturnValue) { return default; }
	public void SetDependency(int Index,FVariantDependency Dependency) {}
	public void DeleteDependency(int Index) {}
	public int GetNumDependencies(int ReturnValue) { return default; }
	public TArray<FVariantDependency> Dependencies;
	public sbyte DisplayText_DEPRECATED;
	public TArray<UVariantObjectBinding> ObjectBindings;
	public UTexture2D Thumbnail;
}
