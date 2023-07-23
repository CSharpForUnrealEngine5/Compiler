#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PaperFlipbook.h")]
///<summary>Contains an animation sequence of sprite frames</summary>
public partial class UPaperFlipbook : UObject {
// PaperFlipbook
	public float FramesPerSecond;
	public TArray<FPaperFlipbookKeyFrame> KeyFrames;
	public UMaterialInterface DefaultMaterial;
	public byte CollisionSource;
	public int GetNumFrames(int ReturnValue) { return default; }
	public float GetTotalDuration(float ReturnValue) { return default; }
	public int GetKeyFrameIndexAtTime(float Time,bool bClampToEnds=false,int ReturnValue) { return default; }
	public UObject GetSpriteAtTime(float Time,bool bClampToEnds=false,UObject ReturnValue) { return default; }
	public UObject GetSpriteAtFrame(int FrameIndex,UObject ReturnValue) { return default; }
	public int GetNumKeyFrames(int ReturnValue) { return default; }
	public bool IsValidKeyFrameIndex(int Index,bool ReturnValue) { return default; }
}
