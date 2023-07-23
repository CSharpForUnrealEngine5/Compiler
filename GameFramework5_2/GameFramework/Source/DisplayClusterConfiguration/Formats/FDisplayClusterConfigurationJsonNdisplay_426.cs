#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Formats/JSON426/DisplayClusterConfigurationJsonTypes_426.h")]
///<summary>"nDisplay" category structure</summary>
public partial struct FDisplayClusterConfigurationJsonNdisplay_426 {
// DisplayClusterConfigurationJsonNdisplay_426
	public sbyte Description;
	public sbyte Version;
	public sbyte AssetPath;
	public FDisplayClusterConfigurationJsonScene_426 Scene;
	public FDisplayClusterConfigurationJsonCluster_426 Cluster;
	public TMap<sbyte,sbyte> CustomParameters;
	public FDisplayClusterConfigurationJsonDiagnostics_426 Diagnostics;
}
