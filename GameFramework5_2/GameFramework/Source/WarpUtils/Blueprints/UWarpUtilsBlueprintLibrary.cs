#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprints/WarpUtilsBlueprintLibrary.h")]
public partial class UWarpUtilsBlueprintLibrary : UBlueprintFunctionLibrary {
// WarpUtilsBlueprintLibrary
	public bool SavePFM(sbyte File,int TexWidth,int TexHeight,TArray<FVector> Vertices,bool ReturnValue) { return default; }
	public bool SavePFMEx(sbyte File,int TexWidth,int TexHeight,TArray<FVector> Vertices,TArray<bool> TilesValidityFlags,bool ReturnValue) { return default; }
	public bool GeneratePFM(sbyte File,FVector StartLocation,FRotator StartRotation,UObject PFMOrigin,int TilesHorizontal,int TilesVertical,float ColumnAngle,float TileSizeHorizontal,float TileSizeVertical,int TilePixelsHorizontal,int TilePixelsVertical,bool AddMargin,bool ReturnValue) { return default; }
	public bool GeneratePFMEx(sbyte File,FVector StartLocation,FRotator StartRotation,UObject PFMOrigin,int TilesHorizontal,int TilesVertical,float ColumnAngle,float TileSizeHorizontal,float TileSizeVertical,int TilePixelsHorizontal,int TilePixelsVertical,bool AddMargin,TArray<bool> TilesValidityFlags,bool ReturnValue) { return default; }
}
