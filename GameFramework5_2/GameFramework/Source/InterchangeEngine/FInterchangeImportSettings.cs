#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeProjectSettings.h")]
public partial struct FInterchangeImportSettings {
// InterchangeImportSettings
	public TMap<sbyte,FInterchangePipelineStack> PipelineStacks;
	public sbyte DefaultPipelineStack;
	public TSoftObjectPtr<UClass> PipelineConfigurationDialogClass;
	public bool bShowPipelineStacksConfigurationDialog;
}
