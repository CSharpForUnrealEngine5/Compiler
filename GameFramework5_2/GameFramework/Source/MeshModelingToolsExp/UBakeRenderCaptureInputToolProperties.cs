#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeRenderCaptureTool.h")]
public partial class UBakeRenderCaptureInputToolProperties : UInteractiveToolPropertySet {
// BakeRenderCaptureInputToolProperties
	public UStaticMesh TargetStaticMesh;
	public sbyte TargetUVLayer;
	public int GetTargetUVLayerIndex(int ReturnValue) { return default; }
	public TArray<sbyte> GetTargetUVLayerNamesFunc(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> TargetUVLayerNamesList;
}
