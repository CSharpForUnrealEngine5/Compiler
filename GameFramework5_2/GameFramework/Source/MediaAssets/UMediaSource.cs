#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaSource.h")]
///<summary>Abstract base class for media sources.</summary>
public partial class UMediaSource : UObject {
// MediaSource
	public sbyte GetUrl(sbyte ReturnValue) { return default; }
	public bool Validate(bool ReturnValue) { return default; }
	public void SetMediaOptionBool(sbyte Key,bool Value) {}
	public void SetMediaOptionFloat(sbyte Key,float Value) {}
	public void SetMediaOptionInt64(sbyte Key,long Value) {}
	public void SetMediaOptionString(sbyte Key,sbyte Value) {}
	public UTexture ThumbnailImage;
	public UObject MediaSourceRenderer;
}
