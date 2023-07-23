#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimationAsset.h")]
///<summary>Represent a current play position in an animation</summary>
public partial struct FMarkerSyncAnimPosition {
// MarkerSyncAnimPosition
	public sbyte PreviousMarkerName;
	public sbyte NextMarkerName;
	public float PositionBetweenMarkers;
}
