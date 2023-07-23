#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AsyncImageExport.h")]
public partial class UAsyncImageExport : UBlueprintAsyncActionBase {
// AsyncImageExport
	public UObject ExportImageAsync(UObject Texture,sbyte OutputFile,int Quality=100,UObject ReturnValue) { return default; }
	public FOnExportImageAsyncComplete Complete;
	public UTexture TextureToExport;
	public int Quality;
	public sbyte TargetFile;
}
