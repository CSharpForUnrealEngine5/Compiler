#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/HUD.h")]
///<summary>Base class of the heads-up display. This has a canvas and a debug canvas on which primitives can be drawn.</summary>
public partial class AHUD : AActor {
// HUD
	public APlayerController PlayerOwner;
	public bool bLostFocusPaused;
	public bool bShowHUD;
	public bool bShowDebugInfo;
	public int CurrentTargetIndex;
	public bool bShowHitBoxDebugInfo;
	public bool bShowOverlays;
	public bool bEnableDebugTextShadow;
	public TArray<AActor> PostRenderedActors;
	public TArray<sbyte> DebugDisplay;
	public TArray<sbyte> ToggledDebugCategories;
	public UCanvas Canvas;
	public UCanvas DebugCanvas;
	public TArray<FDebugTextInfo> DebugTextList;
	public void ShowHUD() {}
	public void ShowDebug(sbyte DebugType=NAME_None) {}
	public void ShowDebugToggleSubCategory(sbyte Category) {}
	public void ShowDebugForReticleTargetToggle(UClass DesiredClass) {}
	public UClass ShowDebugTargetDesiredClass;
	public AActor ShowDebugTargetActor;
	public void AddDebugText(sbyte DebugText,UObject SrcActor,float Duration,FVector Offset,FVector DesiredOffset,FColor TextColor,bool bSkipOverwriteCheck,bool bAbsoluteLocation,bool bKeepAttachedToActor,UObject InFont,float FontScale,bool bDrawShadow) {}
	public void RemoveAllDebugStrings() {}
	public void RemoveDebugText(UObject SrcActor,bool bLeaveDurationText) {}
	public void ReceiveDrawHUD(int SizeX,int SizeY) {}
	public void ReceiveHitBoxClick(sbyte BoxName) {}
	public void ReceiveHitBoxRelease(sbyte BoxName) {}
	public void ReceiveHitBoxBeginCursorOver(sbyte BoxName) {}
	public void ReceiveHitBoxEndCursorOver(sbyte BoxName) {}
	public void GetTextSize(sbyte Text,float OutWidth,float OutHeight,UObject Font=NULL,float Scale=1.f) {}
	public void DrawText(sbyte Text,FLinearColor TextColor,float ScreenX,float ScreenY,UObject Font=NULL,float Scale=1.f,bool bScalePosition=false) {}
	public void DrawLine(float StartScreenX,float StartScreenY,float EndScreenX,float EndScreenY,FLinearColor LineColor,float LineThickness=0.f) {}
	public void DrawRect(FLinearColor RectColor,float ScreenX,float ScreenY,float ScreenW,float ScreenH) {}
	public void DrawTexture(UObject Texture,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float TextureU,float TextureV,float TextureUWidth,float TextureVHeight,FLinearColor TintColor=FLinearColor,EBlendMode BlendMode=BLEND_Translucent,float Scale=1.f,bool bScalePosition=false,float Rotation=0.f,FVector2D RotPivot=FVector2D) {}
	public void DrawTextureSimple(UObject Texture,float ScreenX,float ScreenY,float Scale=1.f,bool bScalePosition=false) {}
	public void DrawMaterial(UObject Material,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float MaterialU,float MaterialV,float MaterialUWidth,float MaterialVHeight,float Scale=1.f,bool bScalePosition=false,float Rotation=0.f,FVector2D RotPivot=FVector2D) {}
	public void DrawMaterialSimple(UObject Material,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float Scale=1.f,bool bScalePosition=false) {}
	public void DrawMaterialTriangle(UObject Material,FVector2D V0_Pos,FVector2D V1_Pos,FVector2D V2_Pos,FVector2D V0_UV,FVector2D V1_UV,FVector2D V2_UV,FLinearColor V0_Color=FLinearColor,FLinearColor V1_Color=FLinearColor,FLinearColor V2_Color=FLinearColor) {}
	public FVector Project(FVector Location,bool bClampToZeroPlane=true,FVector ReturnValue) { return default; }
	public void Deproject(float ScreenX,float ScreenY,FVector WorldPosition,FVector WorldDirection) {}
	public void GetActorsInSelectionRectangle(UClass ClassFilter,FVector2D FirstPoint,FVector2D SecondPoint,TArray<UObject> OutActors,bool bIncludeNonCollidingComponents=true,bool bActorMustBeFullyEnclosed=false) {}
	public void AddHitBox(FVector2D Position,FVector2D Size,sbyte InName,bool bConsumesInput,int Priority=0) {}
	public UObject GetOwningPlayerController(UObject ReturnValue) { return default; }
	public UObject GetOwningPawn(UObject ReturnValue) { return default; }
	public void NextDebugTarget() {}
	public void PreviousDebugTarget() {}
}
