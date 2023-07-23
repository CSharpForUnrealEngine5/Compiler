#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InstancePackers/PCGInstancePackerBase.h")]
public partial class UPCGInstancePackerBase : UObject {
// PCGInstancePackerBase
	public void PackInstances(FPCGContext Context,UObject InSpatialData,FPCGMeshInstanceList InstanceList,FPCGPackedCustomData OutPackedCustomData) {}
	public bool AddTypeToPacking(int TypeId,FPCGPackedCustomData OutPackedCustomData,bool ReturnValue) { return default; }
	public void PackCustomDataFromAttributes(FPCGMeshInstanceList InstanceList,UObject Metadata,TArray<sbyte> AttributeNames,FPCGPackedCustomData OutPackedCustomData) {}
}
