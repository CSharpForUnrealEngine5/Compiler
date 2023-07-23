#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Canvas.h")]
///<summary>A drawing canvas.</summary>
public partial class UCanvas : UObject {
// Canvas
	public float OrgX;
	public float OrgY;
	public float ClipX;
	public float ClipY;
	public FColor DrawColor;
	public bool bCenterX;
	public bool bCenterY;
	public bool bNoSmooth;
	public int SizeX;
	public int SizeY;
	public FPlane ColorModulate;
	public UTexture2D DefaultTexture;
	public UTexture2D GradientTexture0;
	public UReporterGraph ReporterGraph;
	public void K2_DrawLine(FVector2D ScreenPositionA=FVector2D,FVector2D ScreenPositionB=FVector2D,float Thickness=1.0f,FLinearColor RenderColor=FLinearColor) {}
	public void K2_DrawTexture(UObject RenderTexture,FVector2D ScreenPosition,FVector2D ScreenSize,FVector2D CoordinatePosition,FVector2D CoordinateSize=FVector2D,FLinearColor RenderColor=FLinearColor,EBlendMode BlendMode=BLEND_Translucent,float Rotation=0.f,FVector2D PivotPoint=FVector2D) {}
	public void K2_DrawMaterial(UObject RenderMaterial,FVector2D ScreenPosition,FVector2D ScreenSize,FVector2D CoordinatePosition,FVector2D CoordinateSize=FVector2D,float Rotation=0.f,FVector2D PivotPoint=FVector2D) {}
	public void K2_DrawText(UObject RenderFont,sbyte RenderText,FVector2D ScreenPosition,FVector2D Scale=FVector2D,FLinearColor RenderColor=FLinearColor,float Kerning=0.0f,FLinearColor ShadowColor=FLinearColor,FVector2D ShadowOffset=FVector2D,bool bCentreX=false,bool bCentreY=false,bool bOutlined=false,FLinearColor OutlineColor=FLinearColor) {}
	public void K2_DrawBorder(UObject BorderTexture,UObject BackgroundTexture,UObject LeftBorderTexture,UObject RightBorderTexture,UObject TopBorderTexture,UObject BottomBorderTexture,FVector2D ScreenPosition,FVector2D ScreenSize,FVector2D CoordinatePosition,FVector2D CoordinateSize=FVector2D,FLinearColor RenderColor=FLinearColor,FVector2D BorderScale=FVector2D,FVector2D BackgroundScale=FVector2D,float Rotation=0.0f,FVector2D PivotPoint=FVector2D,FVector2D CornerSize=FVector2D) {}
	public void K2_DrawBox(FVector2D ScreenPosition,FVector2D ScreenSize,float Thickness=1.0f,FLinearColor RenderColor=FLinearColor) {}
	public void K2_DrawTriangle(UObject RenderTexture,TArray<FCanvasUVTri> Triangles) {}
	public void K2_DrawMaterialTriangle(UObject RenderMaterial,TArray<FCanvasUVTri> Triangles) {}
	public void K2_DrawPolygon(UObject RenderTexture,FVector2D ScreenPosition,FVector2D Radius=FVector2D,int NumberOfSides=3,FLinearColor RenderColor=FLinearColor) {}
	public FVector K2_Project(FVector WorldLocation,FVector ReturnValue) { return default; }
	public void K2_Deproject(FVector2D ScreenPosition,FVector WorldOrigin,FVector WorldDirection) {}
	public FVector2D K2_StrLen(UObject RenderFont,sbyte RenderText,FVector2D ReturnValue) { return default; }
	public FVector2D K2_TextSize(UObject RenderFont,sbyte RenderText,FVector2D Scale=FVector2D,FVector2D ReturnValue) { return default; }
}
