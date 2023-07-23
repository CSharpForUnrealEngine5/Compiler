#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraBakerOutputVolumeTexture.h")]
public partial class UNiagaraBakerOutputVolumeTexture : UNiagaraBakerOutput {
// NiagaraBakerOutputVolumeTexture
	public FNiagaraBakerTextureSource SourceBinding;
	public bool bGenerateAtlas;
	public bool bGenerateFrames;
	public bool bExportFrames;
	public sbyte AtlasAssetPathFormat;
	public sbyte FramesAssetPathFormat;
	public sbyte FramesExportPathFormat;
}
