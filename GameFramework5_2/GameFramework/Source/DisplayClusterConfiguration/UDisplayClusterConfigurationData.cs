#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes.h")]
///<summary>/</summary>
public partial class UDisplayClusterConfigurationData : UDisplayClusterConfigurationData_Base {
// DisplayClusterConfigurationData
	public UObject GetViewport(sbyte NodeId,sbyte ViewportId,UObject ReturnValue) { return default; }
	public bool AssignPostprocess(sbyte NodeId,sbyte PostprocessId,sbyte Type,TMap<sbyte,sbyte> Parameters,int Order=-1,bool ReturnValue) { return default; }
	public bool RemovePostprocess(sbyte NodeId,sbyte PostprocessId,bool ReturnValue) { return default; }
	public bool GetPostprocess(sbyte NodeId,sbyte PostprocessId,FDisplayClusterConfigurationPostprocess OutPostprocess,bool ReturnValue) { return default; }
	public bool GetProjectionPolicy(sbyte NodeId,sbyte ViewportId,FDisplayClusterConfigurationProjection OutProjection,bool ReturnValue) { return default; }
	public void GetReferencedMeshNames(TArray<sbyte> OutMeshNames) {}
	public FDisplayClusterConfigurationInfo Info;
	public UDisplayClusterConfigurationScene Scene;
	public UDisplayClusterConfigurationCluster Cluster;
	public TMap<sbyte,sbyte> CustomParameters;
	public FDisplayClusterConfigurationDiagnostics Diagnostics;
	public FDisplayClusterConfigurationRenderFrame RenderFrameSettings;
	public FDisplayClusterConfigurationICVFX_StageSettings StageSettings;
	public bool bFollowLocalPlayerCamera;
	public bool bExitOnEsc;
	public bool bOverrideViewportsFromExternalConfig;
	public FDisplayClusterConfigurationGlobalMediaSettings MediaSettings;
	public sbyte PathToConfig;
	public sbyte ImportedPath;
	public FDisplayClusterEditorPropertyReference DefaultFrameSizeRef;
}
