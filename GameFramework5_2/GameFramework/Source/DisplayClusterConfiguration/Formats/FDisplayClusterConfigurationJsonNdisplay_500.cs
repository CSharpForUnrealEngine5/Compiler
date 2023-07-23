#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Formats/JSON500/DisplayClusterConfigurationJsonTypes_500.h")]
///<summary>"nDisplay" category structure</summary>
public partial struct FDisplayClusterConfigurationJsonNdisplay_500 {
// DisplayClusterConfigurationJsonNdisplay_500
	public sbyte Description;
	public sbyte Version;
	public sbyte AssetPath;
	public FDisplayClusterConfigurationJsonMisc_500 Misc;
	public FDisplayClusterConfigurationJsonScene_500 Scene;
	public FDisplayClusterConfigurationJsonCluster_500 Cluster;
	public TMap<sbyte,sbyte> CustomParameters;
	public FDisplayClusterConfigurationJsonDiagnostics_500 Diagnostics;
}
