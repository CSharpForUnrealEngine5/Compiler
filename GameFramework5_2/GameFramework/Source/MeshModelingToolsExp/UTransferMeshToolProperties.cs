#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TransferMeshTool.h")]
///<summary>Standard properties of the Transfer operation</summary>
public partial class UTransferMeshToolProperties : UInteractiveToolPropertySet {
// TransferMeshToolProperties
	public bool bTransferMaterials;
	public sbyte SourceLOD;
	public sbyte TargetLOD;
	public bool bIsStaticMeshSource;
	public TArray<sbyte> GetSourceLODNamesFunc(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> SourceLODNamesList;
	public TArray<sbyte> GetTargetLODNamesFunc(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> TargetLODNamesList;
	public bool bIsStaticMeshTarget;
}
