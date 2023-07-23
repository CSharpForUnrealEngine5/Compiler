#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Formats/JSON427/DisplayClusterConfigurationJsonTypes_427.h")]
public partial struct FDisplayClusterConfigurationJsonClusterNode_427 {
// DisplayClusterConfigurationJsonClusterNode_427
	public sbyte Host;
	public bool Sound;
	public bool FullScreen;
	public FDisplayClusterConfigurationJsonRectangle_427 Window;
	public TMap<sbyte,FDisplayClusterConfigurationJsonPostprocess_427> Postprocess;
	public TMap<sbyte,FDisplayClusterConfigurationJsonViewport_427> Viewports;
	public FDisplayClusterConfigurationFramePostProcess_OutputRemap_427 OutputRemap;
}
