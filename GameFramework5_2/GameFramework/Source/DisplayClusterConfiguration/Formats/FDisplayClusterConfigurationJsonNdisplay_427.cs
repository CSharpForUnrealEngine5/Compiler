#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Formats/JSON427/DisplayClusterConfigurationJsonTypes_427.h")]
///<summary>"nDisplay" category structure</summary>
public partial struct FDisplayClusterConfigurationJsonNdisplay_427 {
// DisplayClusterConfigurationJsonNdisplay_427
	public sbyte Description;
	public sbyte Version;
	public sbyte AssetPath;
	public FDisplayClusterConfigurationJsonMisc_427 Misc;
	public FDisplayClusterConfigurationJsonScene_427 Scene;
	public FDisplayClusterConfigurationJsonCluster_427 Cluster;
	public TMap<sbyte,sbyte> CustomParameters;
	public FDisplayClusterConfigurationJsonDiagnostics_427 Diagnostics;
}
