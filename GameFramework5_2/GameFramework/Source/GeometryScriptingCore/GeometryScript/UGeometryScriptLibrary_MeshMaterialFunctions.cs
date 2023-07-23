#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshMaterialFunctions.h")]
public partial class UGeometryScriptLibrary_MeshMaterialFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshMaterialFunctions
	public int GetMaxMaterialID(UObject TargetMesh,bool bHasMaterialIDs,int ReturnValue) { return default; }
	public UObject EnableMaterialIDs(UObject TargetMesh,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject ClearMaterialIDs(UObject TargetMesh,int ClearValue=0,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject RemapMaterialIDs(UObject TargetMesh,int FromMaterialID,int ToMaterialID,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public int GetTriangleMaterialID(UObject TargetMesh,int TriangleID,bool bIsValidTriangle,int ReturnValue) { return default; }
	public UObject GetMaterialIDsOfTriangles(UObject TargetMesh,FGeometryScriptIndexList TriangleIDList,FGeometryScriptIndexList MaterialIDList,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject GetAllTriangleMaterialIDs(UObject TargetMesh,FGeometryScriptIndexList MaterialIDList,bool bHasMaterialIDs,UObject ReturnValue) { return default; }
	public UObject GetTrianglesByMaterialID(UObject TargetMesh,int MaterialID,FGeometryScriptIndexList TriangleIDList,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject SetTriangleMaterialID(UObject TargetMesh,int TriangleID,int MaterialID,bool bIsValidTriangle,bool bDeferChangeNotifications=false,UObject ReturnValue) { return default; }
	public UObject SetAllTriangleMaterialIDs(UObject TargetMesh,FGeometryScriptIndexList TriangleMaterialIDList,bool bDeferChangeNotifications=false,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject SetMaterialIDOnTriangles(UObject TargetMesh,FGeometryScriptIndexList TriangleIDList,int MaterialID,bool bDeferChangeNotifications=false,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject SetMaterialIDForMeshSelection(UObject TargetMesh,FGeometryScriptMeshSelection Selection,int MaterialID,bool bDeferChangeNotifications=false,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject SetPolygroupMaterialID(UObject TargetMesh,FGeometryScriptGroupLayer GroupLayer,int PolygroupID,int MaterialID,bool bIsValidPolygroupID,bool bDeferChangeNotifications=false,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject DeleteTrianglesByMaterialID(UObject TargetMesh,int MaterialID,int NumDeleted,bool bDeferChangeNotifications=false,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject CompactMaterialIDs(UObject TargetMesh,TArray<UObject> SourceMaterialList,TArray<UObject> CompactedMaterialList,UObject Debug=nullptr,UObject ReturnValue) { return default; }
}
