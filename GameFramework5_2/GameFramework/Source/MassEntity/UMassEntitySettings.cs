#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassEntitySettings.h")]
///<summary>Implements the settings for MassEntity plugin</summary>
public partial class UMassEntitySettings : UMassModuleSettings {
// MassEntitySettings
	public sbyte DumpDependencyGraphFileName;
	public FMassProcessingPhaseConfig ProcessingPhasesConfig;
	public TArray<UMassProcessor> ProcessorCDOs;
}
