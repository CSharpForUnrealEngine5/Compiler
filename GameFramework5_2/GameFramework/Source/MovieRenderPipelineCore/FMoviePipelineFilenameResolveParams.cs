#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieRenderPipelineDataTypes.h")]
public partial struct FMoviePipelineFilenameResolveParams {
// MoviePipelineFilenameResolveParams
	public int FrameNumber;
	public int FrameNumberShot;
	public int FrameNumberRel;
	public int FrameNumberShotRel;
	public sbyte CameraNameOverride;
	public sbyte ShotNameOverride;
	public int ZeroPadFrameNumberCount;
	public bool bForceRelativeFrameNumbers;
	public sbyte FileNameOverride;
	public TMap<sbyte,sbyte> FileNameFormatOverrides;
	public TMap<sbyte,sbyte> FileMetadata;
	public FDateTime InitializationTime;
	public int InitializationVersion;
	public UMoviePipelineExecutorJob Job;
	public UMoviePipelineExecutorShot ShotOverride;
	public int AdditionalFrameNumberOffset;
}
