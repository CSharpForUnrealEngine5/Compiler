#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes.h")]
public partial class UDisplayClusterConfigurationClusterNode : UDisplayClusterConfigurationData_Base {
// DisplayClusterConfigurationClusterNode
	public void GetViewportIds(TArray<sbyte> OutViewportIds) {}
	public UObject GetViewport(sbyte ViewportId,UObject ReturnValue) { return default; }
	public void GetReferencedMeshNames(TArray<sbyte> OutMeshNames) {}
	public sbyte Host;
	public bool bIsSoundEnabled;
	public bool bIsFullscreen;
	public FDisplayClusterConfigurationRectangle WindowRect;
	public FDisplayClusterConfigurationFramePostProcess_OutputRemap OutputRemap;
	public bool bRenderHeadless;
	public int GraphicsAdapter;
	public bool bEnableTextureShare;
	public bool bFixedAspectRatio;
	public TMap<sbyte,UDisplayClusterConfigurationViewport> Viewports;
	public TMap<sbyte,FDisplayClusterConfigurationPostprocess> Postprocess;
	public FDisplayClusterConfigurationMedia Media;
	public bool bIsVisible;
	public bool bIsUnlocked;
	public FDisplayClusterConfigurationExternalImage PreviewImage;
}
