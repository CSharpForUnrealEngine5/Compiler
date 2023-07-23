#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSelectionFunctions.h")]
public partial class UGeometryScriptLibrary_MeshSelectionFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshSelectionFunctions
	public void GetMeshSelectionInfo(FGeometryScriptMeshSelection Selection,EGeometryScriptMeshSelectionType SelectionType,int NumSelected) {}
	public void DebugPrintMeshSelection(FGeometryScriptMeshSelection Selection,bool bDisable=false) {}
	public UObject CreateSelectAllMeshSelection(UObject TargetMesh,FGeometryScriptMeshSelection Selection,EGeometryScriptMeshSelectionType SelectionType=EGeometryScriptMeshSelectionType,UObject ReturnValue) { return default; }
	public UObject ConvertMeshSelection(UObject TargetMesh,FGeometryScriptMeshSelection FromSelection,FGeometryScriptMeshSelection ToSelection,EGeometryScriptMeshSelectionType NewType=EGeometryScriptMeshSelectionType,bool bAllowPartialInclusion=true,UObject ReturnValue) { return default; }
	public void CombineMeshSelections(FGeometryScriptMeshSelection SelectionA,FGeometryScriptMeshSelection SelectionB,FGeometryScriptMeshSelection ResultSelection,EGeometryScriptCombineSelectionMode CombineMode=EGeometryScriptCombineSelectionMode) {}
	public UObject ConvertIndexArrayToMeshSelection(UObject TargetMesh,TArray<int> IndexArray,EGeometryScriptMeshSelectionType SelectionType,FGeometryScriptMeshSelection Selection,UObject ReturnValue) { return default; }
	public UObject ConvertIndexSetToMeshSelection(UObject TargetMesh,TSet<int> IndexSet,EGeometryScriptMeshSelectionType SelectionType,FGeometryScriptMeshSelection Selection,UObject ReturnValue) { return default; }
	public UObject ConvertMeshSelectionToIndexArray(UObject TargetMesh,FGeometryScriptMeshSelection Selection,TArray<int> IndexArray,EGeometryScriptMeshSelectionType SelectionType,UObject ReturnValue) { return default; }
	public UObject ConvertIndexListToMeshSelection(UObject TargetMesh,FGeometryScriptIndexList IndexList,EGeometryScriptMeshSelectionType SelectionType,FGeometryScriptMeshSelection Selection,UObject ReturnValue) { return default; }
	public UObject ConvertMeshSelectionToIndexList(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptIndexList IndexList,EGeometryScriptIndexType ResultListType,EGeometryScriptIndexType ConvertToType=EGeometryScriptIndexType,UObject ReturnValue) { return default; }
	public UObject SelectMeshElementsInBox(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FBox Box,EGeometryScriptMeshSelectionType SelectionType=EGeometryScriptMeshSelectionType,bool bInvert=false,int MinNumTrianglePoints=3,UObject ReturnValue) { return default; }
	public UObject SelectMeshElementsInSphere(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FVector SphereOrigin=FVector,double SphereRadius=100.0,EGeometryScriptMeshSelectionType SelectionType=EGeometryScriptMeshSelectionType,bool bInvert=false,int MinNumTrianglePoints=3,UObject ReturnValue) { return default; }
	public UObject SelectMeshElementsWithPlane(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FVector PlaneOrigin=FVector,FVector PlaneNormal=FVector,EGeometryScriptMeshSelectionType SelectionType=EGeometryScriptMeshSelectionType,bool bInvert=false,int MinNumTrianglePoints=3,UObject ReturnValue) { return default; }
	public UObject SelectMeshElementsByNormalAngle(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FVector Normal=FVector,double MaxAngleDeg=1.0,EGeometryScriptMeshSelectionType SelectionType=EGeometryScriptMeshSelectionType,bool bInvert=false,int MinNumTrianglePoints=3,UObject ReturnValue) { return default; }
	public UObject SelectMeshElementsInsideMesh(UObject TargetMesh,UObject SelectionMesh,FGeometryScriptMeshSelection Selection,FTransform SelectionMeshTransform,EGeometryScriptMeshSelectionType SelectionType=EGeometryScriptMeshSelectionType,bool bInvert=false,double ShellDistance=0.0,double WindingThreshold=0.5,int MinNumTrianglePoints=3,UObject ReturnValue) { return default; }
	public UObject InvertMeshSelection(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptMeshSelection NewSelection,bool bOnlyToConnected=false,UObject ReturnValue) { return default; }
	public UObject ExpandMeshSelectionToConnected(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptMeshSelection NewSelection,EGeometryScriptTopologyConnectionType ConnectionType=EGeometryScriptTopologyConnectionType,UObject ReturnValue) { return default; }
	public UObject ExpandContractMeshSelection(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptMeshSelection NewSelection,int Iterations=1,bool bContract=false,bool bOnlyExpandToFaceNeighbours=false,UObject ReturnValue) { return default; }
}
