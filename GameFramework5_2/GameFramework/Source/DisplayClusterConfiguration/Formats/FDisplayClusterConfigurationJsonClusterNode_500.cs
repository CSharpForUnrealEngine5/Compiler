#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Formats/JSON500/DisplayClusterConfigurationJsonTypes_500.h")]
public partial struct FDisplayClusterConfigurationJsonClusterNode_500 {
// DisplayClusterConfigurationJsonClusterNode_500
	public sbyte Host;
	public bool Sound;
	public bool FullScreen;
	public bool RenderHeadless;
	public int GraphicsAdapter;
	public bool TextureShare;
	public FDisplayClusterConfigurationJsonRectangle_500 Window;
	public TMap<sbyte,FDisplayClusterConfigurationJsonPostprocess_500> Postprocess;
	public TMap<sbyte,FDisplayClusterConfigurationJsonViewport_500> Viewports;
	public FDisplayClusterConfigurationFramePostProcess_OutputRemap_500 OutputRemap;
}
