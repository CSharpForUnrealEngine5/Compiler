#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceGrid2DCollection.h")]
public partial class UNiagaraDataInterfaceGrid2DCollection : UNiagaraDataInterfaceGrid2D {
// NiagaraDataInterfaceGrid2DCollection
	public FNiagaraUserParameterBinding RenderTargetUserParameter;
	public ENiagaraGpuBufferFormat OverrideBufferFormat;
	public bool bOverrideFormat;
	public bool bPreviewGrid;
	public sbyte PreviewAttribute;
	public bool FillTexture2D(UObject Component,UObject dest,int AttributeIndex,bool ReturnValue) { return default; }
	public bool FillRawTexture2D(UObject Component,UObject Dest,int TilesX,int TilesY,bool ReturnValue) { return default; }
	public void GetRawTextureSize(UObject Component,int SizeX,int SizeY) {}
	public void GetTextureSize(UObject Component,int SizeX,int SizeY) {}
	public TMap<ulong,UTextureRenderTarget2DArray> ManagedRenderTargets;
}
