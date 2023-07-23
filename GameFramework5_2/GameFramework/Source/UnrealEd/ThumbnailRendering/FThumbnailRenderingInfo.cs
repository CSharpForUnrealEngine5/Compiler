#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ThumbnailRendering/ThumbnailManager.h")]
///<summary>Holds the settings for a class that needs a thumbnail renderer. Each entry</summary>
public partial struct FThumbnailRenderingInfo {
// ThumbnailRenderingInfo
	public sbyte ClassNeedingThumbnailName;
	public UClass ClassNeedingThumbnail;
	public sbyte RendererClassName;
	public UThumbnailRenderer Renderer;
}
