#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObjectSystem.h")]
public partial class UCustomizableObjectSystem : UObject {
// CustomizableObjectSystem
	public UObject GetInstance(UObject ReturnValue) { return default; }
	public TArray<FPendingReleaseSkeletalMeshInfo> PendingReleaseSkeletalMesh;
	public UDefaultImageProvider DefaultImageProvider;
	public sbyte GetPluginVersion(sbyte ReturnValue) { return default; }
	public int GetNumInstances(int ReturnValue) { return default; }
	public int GetNumPendingInstances(int ReturnValue) { return default; }
	public int GetTotalInstances(int ReturnValue) { return default; }
	public int GetTextureMemoryUsed(int ReturnValue) { return default; }
	public int GetAverageBuildTime(int ReturnValue) { return default; }
	public void SetReleaseMutableTexturesImmediately(bool bReleaseTextures) {}
	public UCustomizableInstanceLODManagementBase DefaultInstanceLODManagement;
	public UCustomizableInstanceLODManagementBase CurrentInstanceLODManagement;
	public TArray<UTexture2D> ProtectedCachedTextures;
}
