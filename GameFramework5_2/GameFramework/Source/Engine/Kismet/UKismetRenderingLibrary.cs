#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetRenderingLibrary.h")]
public partial class UKismetRenderingLibrary : UBlueprintFunctionLibrary {
// KismetRenderingLibrary
	public void ClearRenderTarget2D(UObject WorldContextObject,UObject TextureRenderTarget,FLinearColor ClearColor=FLinearColor) {}
	public UObject CreateRenderTarget2D(UObject WorldContextObject,int Width=256,int Height=256,ETextureRenderTargetFormat Format=RTF_RGBA16f,FLinearColor ClearColor=FLinearColor,bool bAutoGenerateMipMaps=false,bool bSupportUAVs=false,UObject ReturnValue) { return default; }
	public UObject CreateRenderTarget2DArray(UObject WorldContextObject,int Width=256,int Height=256,int Slices=1,ETextureRenderTargetFormat Format=RTF_RGBA16f,FLinearColor ClearColor=FLinearColor,bool bAutoGenerateMipMaps=false,bool bSupportUAVs=false,UObject ReturnValue) { return default; }
	public UObject CreateRenderTargetVolume(UObject WorldContextObject,int Width=16,int Height=16,int Depth=16,ETextureRenderTargetFormat Format=RTF_RGBA16f,FLinearColor ClearColor=FLinearColor,bool bAutoGenerateMipMaps=false,bool bSupportUAVs=false,UObject ReturnValue) { return default; }
	public void ReleaseRenderTarget2D(UObject TextureRenderTarget) {}
	public void ResizeRenderTarget2D(UObject TextureRenderTarget,int Width=256,int Height=256) {}
	public void DrawMaterialToRenderTarget(UObject WorldContextObject,UObject TextureRenderTarget,UObject Material) {}
	public UObject RenderTargetCreateStaticTexture2DEditorOnly(UObject RenderTarget,sbyte Name="Texture",TextureCompressionSettings CompressionSettings=TC_Default,TextureMipGenSettings MipSettings=TMGS_FromTextureGroup,UObject ReturnValue) { return default; }
	public void ConvertRenderTargetToTexture2DEditorOnly(UObject WorldContextObject,UObject RenderTarget,UObject Texture) {}
	public void ExportRenderTarget(UObject WorldContextObject,UObject TextureRenderTarget,sbyte FilePath,sbyte FileName) {}
	public FColor ReadRenderTargetPixel(UObject WorldContextObject,UObject TextureRenderTarget,int X,int Y,FColor ReturnValue) { return default; }
	public FColor ReadRenderTargetUV(UObject WorldContextObject,UObject TextureRenderTarget,float U,float V,FColor ReturnValue) { return default; }
	public bool ReadRenderTarget(UObject WorldContextObject,UObject TextureRenderTarget,TArray<FColor> OutSamples,bool bNormalize=true,bool ReturnValue) { return default; }
	public FLinearColor ReadRenderTargetRawPixel(UObject WorldContextObject,UObject TextureRenderTarget,int X,int Y,bool bNormalize=true,FLinearColor ReturnValue) { return default; }
	public TArray<FLinearColor> ReadRenderTargetRawPixelArea(UObject WorldContextObject,UObject TextureRenderTarget,int MinX,int MinY,int MaxX,int MaxY,bool bNormalize=true,TArray<FLinearColor> ReturnValue) { return default; }
	public FLinearColor ReadRenderTargetRawUV(UObject WorldContextObject,UObject TextureRenderTarget,float U,float V,bool bNormalize=true,FLinearColor ReturnValue) { return default; }
	public bool ReadRenderTargetRaw(UObject WorldContextObject,UObject TextureRenderTarget,TArray<FLinearColor> OutLinearSamples,bool bNormalize=true,bool ReturnValue) { return default; }
	public TArray<FLinearColor> ReadRenderTargetRawUVArea(UObject WorldContextObject,UObject TextureRenderTarget,FBox2D Area,bool bNormalize=true,TArray<FLinearColor> ReturnValue) { return default; }
	public void ExportTexture2D(UObject WorldContextObject,UObject Texture,sbyte FilePath,sbyte FileName) {}
	public UObject ImportFileAsTexture2D(UObject WorldContextObject,sbyte Filename,UObject ReturnValue) { return default; }
	public UObject ImportBufferAsTexture2D(UObject WorldContextObject,TArray<byte> Buffer,UObject ReturnValue) { return default; }
	public void BeginDrawCanvasToRenderTarget(UObject WorldContextObject,UObject TextureRenderTarget,UObject Canvas,FVector2D Size,FDrawToRenderTargetContext Context) {}
	public void EndDrawCanvasToRenderTarget(UObject WorldContextObject,FDrawToRenderTargetContext Context) {}
	public FSkelMeshSkinWeightInfo MakeSkinWeightInfo(int Bone0,byte Weight0,int Bone1,byte Weight1,int Bone2,byte Weight2,int Bone3,byte Weight3,FSkelMeshSkinWeightInfo ReturnValue) { return default; }
	public void BreakSkinWeightInfo(FSkelMeshSkinWeightInfo InWeight,int Bone0,byte Weight0,int Bone1,byte Weight1,int Bone2,byte Weight2,int Bone3,byte Weight3) {}
	public void SetCastInsetShadowForAllAttachments(UObject PrimitiveComponent,bool bCastInsetShadow,bool bLightAttachmentsAsGroup) {}
	public FMatrix CalculateProjectionMatrix(FMinimalViewInfo MinimalViewInfo,FMatrix ReturnValue) { return default; }
	public void EnablePathTracing(bool bEnablePathTracer) {}
}
