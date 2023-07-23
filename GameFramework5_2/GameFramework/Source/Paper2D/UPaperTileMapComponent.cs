#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PaperTileMapComponent.h")]
///<summary>A component that handles rendering and collision for a single instance of a UPaperTileMap asset.</summary>
public partial class UPaperTileMapComponent : UMeshComponent {
// PaperTileMapComponent
	public int MapWidth_DEPRECATED;
	public int MapHeight_DEPRECATED;
	public int TileWidth_DEPRECATED;
	public int TileHeight_DEPRECATED;
	public UPaperTileSet DefaultLayerTileSet_DEPRECATED;
	public UMaterialInterface Material_DEPRECATED;
	public TArray<UPaperTileLayer> TileLayers_DEPRECATED;
	public FLinearColor TileMapColor;
	public int UseSingleLayerIndex;
	public bool bUseSingleLayer;
	public UPaperTileMap TileMap;
	public bool bShowPerTileGridWhenSelected;
	public bool bShowPerLayerGridWhenSelected;
	public bool bShowOutlineWhenUnselected;
	public bool bShowPerTileGridWhenUnselected;
	public bool bShowPerLayerGridWhenUnselected;
	public void CreateNewTileMap(int MapWidth=4,int MapHeight=4,int TileWidth=32,int TileHeight=32,float PixelsPerUnrealUnit=1.0f,bool bCreateLayer=true) {}
	public bool OwnsTileMap(bool ReturnValue) { return default; }
	public bool SetTileMap(UObject NewTileMap,bool ReturnValue) { return default; }
	public void GetMapSize(int MapWidth,int MapHeight,int NumLayers) {}
	public FPaperTileInfo GetTile(int X,int Y,int Layer,FPaperTileInfo ReturnValue) { return default; }
	public void SetTile(int X,int Y,int Layer,FPaperTileInfo NewValue) {}
	public void ResizeMap(int NewWidthInTiles,int NewHeightInTiles) {}
	public UObject AddNewLayer(UObject ReturnValue) { return default; }
	public FLinearColor GetTileMapColor(FLinearColor ReturnValue) { return default; }
	public void SetTileMapColor(FLinearColor NewColor) {}
	public FLinearColor GetLayerColor(int Layer=0,FLinearColor ReturnValue) { return default; }
	public void SetLayerColor(FLinearColor NewColor,int Layer=0) {}
	public void MakeTileMapEditable() {}
	public FVector GetTileCornerPosition(int TileX,int TileY,int LayerIndex=0,bool bWorldSpace=false,FVector ReturnValue) { return default; }
	public FVector GetTileCenterPosition(int TileX,int TileY,int LayerIndex=0,bool bWorldSpace=false,FVector ReturnValue) { return default; }
	public void GetTilePolygon(int TileX,int TileY,TArray<FVector> Points,int LayerIndex=0,bool bWorldSpace=false) {}
	public void SetDefaultCollisionThickness(float Thickness,bool bRebuildCollision=true) {}
	public void SetLayerCollision(int Layer=0,bool bHasCollision=true,bool bOverrideThickness=true,float CustomThickness=50.0f,bool bOverrideOffset=false,float CustomOffset=0.0f,bool bRebuildCollision=true) {}
	public void RebuildCollision() {}
}
