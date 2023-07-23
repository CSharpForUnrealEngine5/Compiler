#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequencePlayer.h")]
///<summary>Frame snapshot information for a level sequence</summary>
public partial struct FLevelSequencePlayerSnapshot {
// LevelSequencePlayerSnapshot
	public sbyte RootName;
	public FQualifiedFrameTime RootTime;
	public FQualifiedFrameTime SourceTime;
	public sbyte CurrentShotName;
	public FQualifiedFrameTime CurrentShotLocalTime;
	public FQualifiedFrameTime CurrentShotSourceTime;
	public sbyte SourceTimecode;
	public TSoftObjectPtr<UCameraComponent> CameraComponent;
	public ULevelSequence ActiveShot;
	public FMovieSceneSequenceID ShotID;
	public sbyte MasterName_DEPRECATED;
	public FQualifiedFrameTime MasterTime_DEPRECATED;
}
