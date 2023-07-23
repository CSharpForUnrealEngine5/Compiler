#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshVertexColorFunctions.h")]
public partial class UGeometryScriptLibrary_MeshVertexColorFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshVertexColorFunctions
	public UObject SetMeshConstantVertexColor(UObject TargetMesh,FLinearColor Color,FGeometryScriptColorFlags Flags,bool bClearExisting=false,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject SetMeshSelectionVertexColor(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FLinearColor Color,FGeometryScriptColorFlags Flags,bool bCreateColorSeam=false,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject SetMeshPerVertexColors(UObject TargetMesh,FGeometryScriptColorList VertexColorList,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject GetMeshPerVertexColors(UObject TargetMesh,FGeometryScriptColorList ColorList,bool bIsValidColorSet,bool bHasVertexIDGaps,bool bBlendSplitVertexValues=true,UObject ReturnValue) { return default; }
	public UObject ConvertMeshVertexColorsSRGBToLinear(UObject TargetMesh,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject ConvertMeshVertexColorsLinearToSRGB(UObject TargetMesh,UObject Debug=nullptr,UObject ReturnValue) { return default; }
}
