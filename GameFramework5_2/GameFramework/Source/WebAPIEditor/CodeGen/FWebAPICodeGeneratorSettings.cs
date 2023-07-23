#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CodeGen/WebAPICodeGeneratorSettings.h")]
///<summary>Encapsulates settings for WebAPI code generation.</summary>
public partial struct FWebAPICodeGeneratorSettings {
// WebAPICodeGeneratorSettings
	public bool bOverrideGeneratorClass;
	public TSoftObjectPtr<UClass> CodeGeneratorClass;
	public sbyte CopyrightNotice;
	public FWebAPIDefinitionTargetModule TargetModule;
	public sbyte ModelOutputPath;
	public sbyte OperationOutputPath;
	public TSoftObjectPtr<UClass> GeneratedSettingsBaseClass;
	public bool bWriteResult;
	public sbyte Namespace;
}
