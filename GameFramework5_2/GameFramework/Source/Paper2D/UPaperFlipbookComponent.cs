#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PaperFlipbookComponent.h")]
public partial class UPaperFlipbookComponent : UMeshComponent {
// PaperFlipbookComponent
	public UPaperFlipbook SourceFlipbook;
	public UMaterialInterface Material_DEPRECATED;
	public float PlayRate;
	public bool bLooping;
	public bool bReversePlayback;
	public bool bPlaying;
	public float AccumulatedTime;
	public int CachedFrameIndex;
	public FLinearColor SpriteColor;
	public UBodySetup CachedBodySetup;
	public FFlipbookFinishedPlaySignature OnFinishedPlaying;
	public bool SetFlipbook(UObject NewFlipbook,bool ReturnValue) { return default; }
	public UObject GetFlipbook(UObject ReturnValue) { return default; }
	public FLinearColor GetSpriteColor(FLinearColor ReturnValue) { return default; }
	public void SetSpriteColor(FLinearColor NewColor) {}
	public void Play() {}
	public void PlayFromStart() {}
	public void Reverse() {}
	public void ReverseFromEnd() {}
	public void Stop() {}
	public bool IsPlaying(bool ReturnValue) { return default; }
	public bool IsReversing(bool ReturnValue) { return default; }
	public void SetPlaybackPositionInFrames(int NewFramePosition,bool bFireEvents) {}
	public int GetPlaybackPositionInFrames(int ReturnValue) { return default; }
	public void SetPlaybackPosition(float NewPosition,bool bFireEvents) {}
	public float GetPlaybackPosition(float ReturnValue) { return default; }
	public void SetLooping(bool bNewLooping) {}
	public bool IsLooping(bool ReturnValue) { return default; }
	public void SetPlayRate(float NewRate) {}
	public float GetPlayRate(float ReturnValue) { return default; }
	public void SetNewTime(float NewTime) {}
	public float GetFlipbookLength(float ReturnValue) { return default; }
	public int GetFlipbookLengthInFrames(int ReturnValue) { return default; }
	public float GetFlipbookFramerate(float ReturnValue) { return default; }
	public void OnRep_SourceFlipbook(UObject OldFlipbook) {}
}
