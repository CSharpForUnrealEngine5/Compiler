#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGSettings.h")]
///<summary>Base class for settings-as-data in the PCG framework</summary>
public partial class UPCGSettings : UPCGSettingsInterface {
// PCGSettings
	public int Seed;
	public TSet<sbyte> FilterOnTags;
	public bool bPassThroughFilteredOutInputs;
	public TSet<sbyte> TagsAppliedOnOutput;
	public EPCGSettingsExecutionMode ExecutionMode_DEPRECATED;
	public FPCGDeterminismSettings DeterminismSettings;
	public bool bExposeToLibrary;
	public sbyte Category;
	public sbyte Description;
	public bool bUseSeed;
	public TArray<FPCGSettingsOverridableParam> CachedOverridableParams;
}
