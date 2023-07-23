#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangePipelineBase.h")]
public partial class UInterchangePipelineBase : UObject {
// InterchangePipelineBase
	public void ScriptedExecutePreImportPipeline(UObject BaseNodeContainer,TArray<UObject> SourceDatas) {}
	public void ScriptedExecutePipeline(UObject BaseNodeContainer,TArray<UObject> SourceDatas) {}
	public void ScriptedExecutePostFactoryPipeline(UObject BaseNodeContainer,sbyte FactoryNodeKey,UObject CreatedAsset,bool bIsAReimport) {}
	public void ScriptedExecutePostImportPipeline(UObject BaseNodeContainer,sbyte FactoryNodeKey,UObject CreatedAsset,bool bIsAReimport) {}
	public void ScriptedExecuteExportPipeline(UObject BaseNodeContainer) {}
	public bool ScriptedCanExecuteOnAnyThread(EInterchangePipelineTask PipelineTask,bool ReturnValue) { return default; }
	public void ScriptedSetReimportSourceIndex(UClass ReimportObjectClass,int SourceFileIndex) {}
	public bool DoesPropertyStatesExist(sbyte PropertyPath,bool ReturnValue) { return default; }
	public FInterchangePipelinePropertyStates FindOrAddPropertyStates(sbyte PropertyPath,FInterchangePipelinePropertyStates ReturnValue) { return default; }
	public UInterchangeResultsContainer Results;
	public TMap<sbyte,FInterchangePipelinePropertyStates> PropertiesStates;
}
