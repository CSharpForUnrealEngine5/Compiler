#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/ListUtilityFunctions.h")]
public partial class UGeometryScriptLibrary_ListUtilityFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_ListUtilityFunctions
	public int GetIndexListLength(FGeometryScriptIndexList IndexList,int ReturnValue) { return default; }
	public int GetIndexListLastIndex(FGeometryScriptIndexList IndexList,int ReturnValue) { return default; }
	public int GetIndexListItem(FGeometryScriptIndexList IndexList,int Index,bool bIsValidIndex,int ReturnValue) { return default; }
	public void SetIndexListItem(FGeometryScriptIndexList IndexList,int Index,int NewValue,bool bIsValidIndex) {}
	public void ConvertIndexListToArray(FGeometryScriptIndexList IndexList,TArray<int> IndexArray) {}
	public void ConvertArrayToIndexList(TArray<int> IndexArray,FGeometryScriptIndexList IndexList,EGeometryScriptIndexType IndexType=EGeometryScriptIndexType) {}
	public void DuplicateIndexList(FGeometryScriptIndexList IndexList,FGeometryScriptIndexList DuplicateList) {}
	public void ClearIndexList(FGeometryScriptIndexList IndexList,int ClearValue=0) {}
	public int GetTriangleListLength(FGeometryScriptTriangleList TriangleList,int ReturnValue) { return default; }
	public int GetTriangleListLastTriangle(FGeometryScriptTriangleList TriangleList,int ReturnValue) { return default; }
	public FIntVector GetTriangleListItem(FGeometryScriptTriangleList TriangleList,int Triangle,bool bIsValidTriangle,FIntVector ReturnValue) { return default; }
	public void ConvertTriangleListToArray(FGeometryScriptTriangleList TriangleList,TArray<FIntVector> TriangleArray) {}
	public void ConvertArrayToTriangleList(TArray<FIntVector> TriangleArray,FGeometryScriptTriangleList TriangleList) {}
	public int GetScalarListLength(FGeometryScriptScalarList ScalarList,int ReturnValue) { return default; }
	public int GetScalarListLastIndex(FGeometryScriptScalarList ScalarList,int ReturnValue) { return default; }
	public double GetScalarListItem(FGeometryScriptScalarList ScalarList,int Index,bool bIsValidIndex,double ReturnValue) { return default; }
	public void SetScalarListItem(FGeometryScriptScalarList ScalarList,int Index,double NewValue,bool bIsValidIndex) {}
	public void ConvertScalarListToArray(FGeometryScriptScalarList ScalarList,TArray<double> ScalarArray) {}
	public void ConvertArrayToScalarList(TArray<double> VectorArray,FGeometryScriptScalarList ScalarList) {}
	public void DuplicateScalarList(FGeometryScriptScalarList ScalarList,FGeometryScriptScalarList DuplicateList) {}
	public void ClearScalarList(FGeometryScriptScalarList ScalarList,double ClearValue=0.0) {}
	public int GetVectorListLength(FGeometryScriptVectorList VectorList,int ReturnValue) { return default; }
	public int GetVectorListLastIndex(FGeometryScriptVectorList VectorList,int ReturnValue) { return default; }
	public FVector GetVectorListItem(FGeometryScriptVectorList VectorList,int Index,bool bIsValidIndex,FVector ReturnValue) { return default; }
	public void SetVectorListItem(FGeometryScriptVectorList VectorList,int Index,FVector NewValue,bool bIsValidIndex) {}
	public void ConvertVectorListToArray(FGeometryScriptVectorList VectorList,TArray<FVector> VectorArray) {}
	public void ConvertArrayToVectorList(TArray<FVector> VectorArray,FGeometryScriptVectorList VectorList) {}
	public void DuplicateVectorList(FGeometryScriptVectorList VectorList,FGeometryScriptVectorList DuplicateList) {}
	public void ClearVectorList(FGeometryScriptVectorList VectorList,FVector ClearValue=FVector) {}
	public int GetUVListLength(FGeometryScriptUVList UVList,int ReturnValue) { return default; }
	public int GetUVListLastIndex(FGeometryScriptUVList UVList,int ReturnValue) { return default; }
	public FVector2D GetUVListItem(FGeometryScriptUVList UVList,int Index,bool bIsValidIndex,FVector2D ReturnValue) { return default; }
	public void SetUVListItem(FGeometryScriptUVList UVList,int Index,FVector2D NewUV,bool bIsValidIndex) {}
	public void ConvertUVListToArray(FGeometryScriptUVList UVList,TArray<FVector2D> UVArray) {}
	public void ConvertArrayToUVList(TArray<FVector2D> UVArray,FGeometryScriptUVList UVList) {}
	public void DuplicateUVList(FGeometryScriptUVList UVList,FGeometryScriptUVList DuplicateList) {}
	public void ClearUVList(FGeometryScriptUVList UVList,FVector2D ClearUV) {}
	public int GetColorListLength(FGeometryScriptColorList ColorList,int ReturnValue) { return default; }
	public int GetColorListLastIndex(FGeometryScriptColorList ColorList,int ReturnValue) { return default; }
	public FLinearColor GetColorListItem(FGeometryScriptColorList ColorList,int Index,bool bIsValidIndex,FLinearColor ReturnValue) { return default; }
	public void SetColorListItem(FGeometryScriptColorList ColorList,int Index,FLinearColor NewColor,bool bIsValidIndex) {}
	public void ConvertColorListToArray(FGeometryScriptColorList ColorList,TArray<FLinearColor> ColorArray) {}
	public void ConvertArrayToColorList(TArray<FLinearColor> ColorArray,FGeometryScriptColorList ColorList) {}
	public void DuplicateColorList(FGeometryScriptColorList ColorList,FGeometryScriptColorList DuplicateList) {}
	public void ClearColorList(FGeometryScriptColorList ColorList,FLinearColor ClearColor) {}
	public void ExtractColorListChannel(FGeometryScriptColorList ColorList,FGeometryScriptScalarList ScalarList,int ChannelIndex=0) {}
	public void ExtractColorListChannels(FGeometryScriptColorList ColorList,FGeometryScriptVectorList VectorList,int XChannelIndex=0,int YChannelIndex=1,int ZChannelIndex=2) {}
}
