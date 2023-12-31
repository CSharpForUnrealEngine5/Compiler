#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphTypes.h")]
public partial struct FZoneGraphBuildSettings {
// ZoneGraphBuildSettings
	public float CommonTessellationTolerance;
	public TArray<FZoneGraphTessellationSettings> SpecificTessellationTolerances;
	public float LaneConnectionAngle;
	public FZoneGraphTagMask LaneConnectionMask;
	public float TurnThresholdAngle;
	public TArray<FZoneGraphLaneRoutingRule> PolygonRoutingRules;
	public float ConnectionSnapDistance;
	public float ConnectionSnapAngle;
}
