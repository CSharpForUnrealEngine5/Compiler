#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearchDatabaseEditorReflection.h")]
public partial class UPoseSearchDatabaseStatistics : UObject {
// PoseSearchDatabaseStatistics
	public uint AnimationSequences;
	public uint TotalAnimationPosesInFrames;
	public sbyte TotalAnimationPosesInTime;
	public uint SearchableFrames;
	public sbyte SearchableTime;
	public double AverageVelocity;
	public double MaxVelocity;
	public double AverageAcceleration;
	public double MaxAcceleration;
	public float ExplainedVariance;
	public sbyte EstimatedDatabaseSize;
	public sbyte ValuesSize;
	public sbyte PCAValuesSize;
	public sbyte KDTreeSize;
	public sbyte PoseMetadataSize;
	public sbyte AssetsSize;
}
