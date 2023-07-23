#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TimelineTemplate.h")]
public partial class UTimelineTemplate : UObject {
// TimelineTemplate
	public float TimelineLength;
	public byte LengthMode;
	public bool bAutoPlay;
	public bool bLoop;
	public bool bReplicated;
	public bool bIgnoreTimeDilation;
	public TArray<FTTEventTrack> EventTracks;
	public TArray<FTTFloatTrack> FloatTracks;
	public TArray<FTTVectorTrack> VectorTracks;
	public TArray<FTTLinearColorTrack> LinearColorTracks;
	public TArray<FBPVariableMetaDataEntry> MetaDataArray;
	public FGuid TimelineGuid;
	public byte TimelineTickGroup;
	public sbyte VariableName;
	public sbyte DirectionPropertyName;
	public sbyte UpdateFunctionName;
	public sbyte FinishedFunctionName;
	public TArray<FTTTrackId> TrackDisplayOrder;
}
