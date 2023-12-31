#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LocalizationTargetTypes.h")]
public partial struct FGatherTextFromPackagesConfiguration {
// GatherTextFromPackagesConfiguration
	public bool IsEnabled;
	public TArray<FGatherTextIncludePath> IncludePathWildcards;
	public TArray<FGatherTextExcludePath> ExcludePathWildcards;
	public TArray<FGatherTextFileExtension> FileExtensions;
	public TArray<string> Collections;
	public TArray<FSoftClassPath> ExcludeClasses;
	public bool ShouldExcludeDerivedClasses;
	public bool ShouldGatherFromEditorOnlyData;
	public bool SkipGatherCache;
}
