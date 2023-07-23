#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Formats/JSON426/DisplayClusterConfigurationJsonTypes_426.h")]
public partial struct FDisplayClusterConfigurationJsonClusterNode_426 {
// DisplayClusterConfigurationJsonClusterNode_426
	public sbyte Host;
	public bool Sound;
	public bool FullScreen;
	public FDisplayClusterConfigurationJsonRectangle_426 Window;
	public TMap<sbyte,FDisplayClusterConfigurationJsonPostprocess_426> Postprocess;
	public TMap<sbyte,FDisplayClusterConfigurationJsonViewport_426> Viewports;
}
