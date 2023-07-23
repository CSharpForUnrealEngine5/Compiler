#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensFileExchangeFormat.h")]
public partial struct FLensFileMetadata {
// LensFileMetadata
	public sbyte Type;
	public sbyte Version;
	public FLensInfoExchange LensInfo;
	public sbyte Name;
	public ENodalOffsetCoordinateSystem NodalOffsetCoordinateSystem;
	public ELensFileUnit FxFyUnits;
	public ELensFileUnit CxCyUnits;
	public TArray<FLensFileUserMetadataEntry> UserMetadata;
}
