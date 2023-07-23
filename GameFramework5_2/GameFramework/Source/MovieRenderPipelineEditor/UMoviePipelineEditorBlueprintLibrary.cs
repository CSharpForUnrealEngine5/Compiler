#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineEditorBlueprintLibrary.h")]
public partial class UMoviePipelineEditorBlueprintLibrary : UBlueprintFunctionLibrary {
// MoviePipelineEditorBlueprintLibrary
	public bool ExportConfigToAsset(UObject InConfig,sbyte InPackagePath,sbyte InFileName,bool bInSaveAsset,UObject OutAsset,sbyte OutErrorReason,bool ReturnValue) { return default; }
	public bool IsMapValidForRemoteRender(TArray<UObject> InJobs,bool ReturnValue) { return default; }
	public void WarnUserOfUnsavedMap() {}
	public UObject SaveQueueToManifestFile(UObject InPipelineQueue,sbyte OutManifestFilePath,UObject ReturnValue) { return default; }
	public sbyte ConvertManifestFileToString(sbyte InManifestFilePath,sbyte ReturnValue) { return default; }
	public UObject CreateJobFromSequence(UObject InPipelineQueue,UObject InSequence,UObject ReturnValue) { return default; }
	public void EnsureJobHasDefaultSettings(UObject InJob) {}
	public sbyte ResolveOutputDirectoryFromJob(UObject InJob,sbyte ReturnValue) { return default; }
}
