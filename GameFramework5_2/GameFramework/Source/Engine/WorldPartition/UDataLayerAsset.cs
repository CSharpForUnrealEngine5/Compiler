#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/DataLayer/DataLayerAsset.h")]
public partial class UDataLayerAsset : UObject {
// DataLayerAsset
	public EDataLayerType GetType(EDataLayerType ReturnValue) { return default; }
	public bool IsRuntime(bool ReturnValue) { return default; }
	public FColor GetDebugColor(FColor ReturnValue) { return default; }
	public EDataLayerType DataLayerType;
	public FColor DebugColor;
}
