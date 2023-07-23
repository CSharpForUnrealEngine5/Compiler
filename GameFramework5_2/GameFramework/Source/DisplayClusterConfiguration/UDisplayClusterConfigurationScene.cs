#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes.h")]
public partial class UDisplayClusterConfigurationScene : UDisplayClusterConfigurationData_Base {
// DisplayClusterConfigurationScene
	public TMap<sbyte,UDisplayClusterConfigurationSceneComponentXform> Xforms;
	public TMap<sbyte,UDisplayClusterConfigurationSceneComponentScreen> Screens;
	public TMap<sbyte,UDisplayClusterConfigurationSceneComponentCamera> Cameras;
}
