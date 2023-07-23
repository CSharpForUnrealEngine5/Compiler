#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImageComparer.h")]
///<summary>This struct holds the results of comparing an incoming image from a platform with an approved image that exists under the</summary>
public partial struct FImageComparisonResult {
// ImageComparisonResult
	public FDateTime CreationTime;
	public sbyte SourcePlatform;
	public sbyte SourceRHI;
	public sbyte IdealApprovedFolderPath;
	public sbyte ApprovedFilePath;
	public sbyte IncomingFilePath;
	public sbyte ComparisonFilePath;
	public sbyte ReportApprovedFilePath;
	public sbyte ReportIncomingFilePath;
	public sbyte ReportComparisonFilePath;
	public double MaxLocalDifference;
	public double GlobalDifference;
	public FImageTolerance Tolerance;
	public sbyte ErrorMessage;
	public int Version;
}
