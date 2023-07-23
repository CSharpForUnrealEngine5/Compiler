#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaTexture.h")]
///<summary>Implements a texture asset for rendering video tracks from UMediaPlayer assets.</summary>
public partial class UMediaTexture : UTexture {
// MediaTexture
	public byte AddressX;
	public byte AddressY;
	public bool AutoClear;
	public FLinearColor ClearColor;
	public bool EnableGenMips;
	public byte NumMips;
	public bool NewStyleOutput;
	public byte OutputFormat;
	public float CurrentAspectRatio;
	public byte CurrentOrientation;
	public float GetAspectRatio(float ReturnValue) { return default; }
	public int GetHeight(int ReturnValue) { return default; }
	public int GetWidth(int ReturnValue) { return default; }
	public int GetTextureNumMips(int ReturnValue) { return default; }
	public UObject GetMediaPlayer(UObject ReturnValue) { return default; }
	public void SetMediaPlayer(UObject NewMediaPlayer) {}
	public void UpdateResource() {}
	public UMediaPlayer MediaPlayer;
}
