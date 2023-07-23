#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMController.h")]
///<summary>The Controller is the sole authority to perform changes</summary>
public partial class URigVMController : UObject {
// RigVMController
	public UObject GetGraph(UObject ReturnValue) { return default; }
	public void SetGraph(UObject InGraph) {}
	public void PushGraph(UObject InGraph,bool bSetupUndoRedo=true) {}
	public UObject PopGraph(bool bSetupUndoRedo=true,UObject ReturnValue) { return default; }
	public UObject GetTopLevelGraph(UObject ReturnValue) { return default; }
	public void EnableReporting(bool bEnabled=true) {}
	public bool IsReportingEnabled(bool ReturnValue) { return default; }
	public TArray<sbyte> GeneratePythonCommands(TArray<sbyte> ReturnValue) { return default; }
	public UObject AddUnitNode(UObject InScriptStruct,sbyte InMethodName=TEXT,FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public UObject AddUnitNodeFromStructPath(sbyte InScriptStructPath,sbyte InMethodName=TEXT,FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public UObject AddUnitNodeWithDefaults(UObject InScriptStruct,sbyte InDefaults,sbyte InMethodName=TEXT,FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public bool SetUnitNodeDefaults(UObject InNode,sbyte InDefaults,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public UObject AddVariableNode(sbyte InVariableName,sbyte InCPPType,UObject InCPPTypeObject,bool bIsGetter,sbyte InDefaultValue,FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public UObject AddVariableNodeFromObjectPath(sbyte InVariableName,sbyte InCPPType,sbyte InCPPTypeObjectPath,bool bIsGetter,sbyte InDefaultValue,FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public void RefreshVariableNode(sbyte InNodeName,sbyte InVariableName,sbyte InCPPType,UObject InCPPTypeObject,bool bSetupUndoRedo,bool bSetupOrphanPins=true) {}
	public UObject ReplaceParameterNodeWithVariable(sbyte InNodeName,sbyte InVariableName,sbyte InCPPType,UObject InCPPTypeObject,bool bSetupUndoRedo,UObject ReturnValue) { return default; }
	public bool UnresolveTemplateNodes(TArray<sbyte> InNodeNames,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public TArray<UObject> UpgradeNodes(TArray<sbyte> InNodeNames,bool bRecursive=true,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,TArray<UObject> ReturnValue) { return default; }
	public UObject AddParameterNode(sbyte InParameterName,sbyte InCPPType,UObject InCPPTypeObject,bool bIsInput,sbyte InDefaultValue,FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public UObject AddParameterNodeFromObjectPath(sbyte InParameterName,sbyte InCPPType,sbyte InCPPTypeObjectPath,bool bIsInput,sbyte InDefaultValue,FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public UObject AddCommentNode(sbyte InCommentText,FVector2D InPosition=FVector2D,FVector2D InSize=FVector2D,FLinearColor InColor=FLinearColor,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public UObject AddRerouteNodeOnLink(UObject InLink,bool bShowAsFullNode,FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public UObject AddRerouteNodeOnLinkPath(sbyte InLinkPinPathRepresentation,bool bShowAsFullNode,FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public UObject AddRerouteNodeOnPin(sbyte InPinPath,bool bAsInput,bool bShowAsFullNode,FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public UObject AddFreeRerouteNode(bool bShowAsFullNode,sbyte InCPPType,sbyte InCPPTypeObjectPath,bool bIsConstant,sbyte InCustomWidgetName,sbyte InDefaultValue,FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,UObject ReturnValue) { return default; }
	public UObject AddBranchNode(FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public UObject AddIfNode(sbyte InCPPType,sbyte InCPPTypeObjectPath,FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public UObject AddIfNodeFromStruct(UObject InScriptStruct,FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,UObject ReturnValue) { return default; }
	public UObject AddSelectNode(sbyte InCPPType,sbyte InCPPTypeObjectPath,FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public UObject AddSelectNodeFromStruct(UObject InScriptStruct,FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,UObject ReturnValue) { return default; }
	public UObject AddTemplateNode(sbyte InNotation,FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public TArray<UObject> GetRegisteredUnitStructs(TArray<UObject> ReturnValue) { return default; }
	public TArray<sbyte> GetRegisteredTemplates(TArray<sbyte> ReturnValue) { return default; }
	public TArray<UObject> GetUnitStructsForTemplate(sbyte InNotation,TArray<UObject> ReturnValue) { return default; }
	public sbyte GetTemplateForUnitStruct(UObject InFunction,sbyte InMethodName=TEXT,sbyte ReturnValue) { return default; }
	public bool ResolveWildCardPin(sbyte InPinPath,sbyte InCPPType,sbyte InCPPTypeObjectPath,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public UObject AddInjectedNode(sbyte InPinPath,bool bAsInput,UObject InScriptStruct,sbyte InMethodName,sbyte InInputPinName,sbyte InOutputPinName,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public UObject AddInjectedNodeFromStructPath(sbyte InPinPath,bool bAsInput,sbyte InScriptStructPath,sbyte InMethodName,sbyte InInputPinName,sbyte InOutputPinName,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,UObject ReturnValue) { return default; }
	public bool RemoveInjectedNode(sbyte InPinPath,bool bAsInput,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public UObject EjectNodeFromPin(sbyte InPinPath,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public UObject AddEnumNode(sbyte InCPPTypeObjectPath,FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public UObject AddArrayNode(ERigVMOpCode InOpCode,sbyte InCPPType,UObject InCPPTypeObject,FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool bIsPatching=false,UObject ReturnValue) { return default; }
	public UObject AddArrayNodeFromObjectPath(ERigVMOpCode InOpCode,sbyte InCPPType,sbyte InCPPTypeObjectPath,FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool bIsPatching=false,UObject ReturnValue) { return default; }
	public UObject AddInvokeEntryNode(sbyte InEntryName,FVector2D InPosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public bool Undo(bool ReturnValue) { return default; }
	public bool Redo(bool ReturnValue) { return default; }
	public bool OpenUndoBracket(sbyte InTitle,bool ReturnValue) { return default; }
	public bool CloseUndoBracket(bool ReturnValue) { return default; }
	public bool CancelUndoBracket(bool ReturnValue) { return default; }
	public sbyte ExportNodesToText(TArray<sbyte> InNodeNames,sbyte ReturnValue) { return default; }
	public sbyte ExportSelectedNodesToText(sbyte ReturnValue) { return default; }
	public bool CanImportNodesFromText(sbyte InText,bool ReturnValue) { return default; }
	public TArray<sbyte> ImportNodesFromText(sbyte InText,bool bSetupUndoRedo=true,bool bPrintPythonCommands=false,TArray<sbyte> ReturnValue) { return default; }
	public UObject LocalizeFunctionFromPath(sbyte InHostPath,sbyte InFunctionName,bool bLocalizeDependentPrivateFunctions=true,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public UObject LocalizeFunction(FRigVMGraphFunctionIdentifier InFunctionDefinition,bool bLocalizeDependentPrivateFunctions=true,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public TMap<FRigVMGraphFunctionIdentifier,UObject> LocalizeFunctions(TArray<FRigVMGraphFunctionIdentifier> InFunctionDefinitions,bool bLocalizeDependentPrivateFunctions=true,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,TMap<FRigVMGraphFunctionIdentifier,UObject> ReturnValue) { return default; }
	public UObject CollapseNodes(TArray<sbyte> InNodeNames,sbyte InCollapseNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool bIsAggregate=false,UObject ReturnValue) { return default; }
	public TArray<UObject> ExpandLibraryNode(sbyte InNodeName,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,TArray<UObject> ReturnValue) { return default; }
	public sbyte PromoteCollapseNodeToFunctionReferenceNode(sbyte InNodeName,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,sbyte InExistingFunctionDefinitionPath=TEXT,sbyte ReturnValue) { return default; }
	public sbyte PromoteFunctionReferenceNodeToCollapseNode(sbyte InNodeName,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool bRemoveFunctionDefinition=false,sbyte ReturnValue) { return default; }
	public bool RemoveNode(UObject InNode,bool bSetupUndoRedo=true,bool bRecursive=false,bool bPrintPythonCommand=false,bool bRelinkPins=false,bool ReturnValue) { return default; }
	public bool RemoveNodeByName(sbyte InNodeName,bool bSetupUndoRedo=true,bool bRecursive=false,bool bPrintPythonCommand=false,bool bRelinkPins=false,bool ReturnValue) { return default; }
	public bool RenameNode(UObject InNode,sbyte InNewName,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SelectNode(UObject InNode,bool bSelect=true,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SelectNodeByName(sbyte InNodeName,bool bSelect=true,bool bSetupUndoRedo=true,bool ReturnValue) { return default; }
	public bool ClearNodeSelection(bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SetNodeSelection(TArray<sbyte> InNodeNames,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SetNodePosition(UObject InNode,FVector2D InPosition,bool bSetupUndoRedo=true,bool bMergeUndoAction=false,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SetNodePositionByName(sbyte InNodeName,FVector2D InPosition,bool bSetupUndoRedo=true,bool bMergeUndoAction=false,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SetNodeSize(UObject InNode,FVector2D InSize,bool bSetupUndoRedo=true,bool bMergeUndoAction=false,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SetNodeSizeByName(sbyte InNodeName,FVector2D InSize,bool bSetupUndoRedo=true,bool bMergeUndoAction=false,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SetNodeColor(UObject InNode,FLinearColor InColor,bool bSetupUndoRedo=true,bool bMergeUndoAction=false,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SetNodeColorByName(sbyte InNodeName,FLinearColor InColor,bool bSetupUndoRedo=true,bool bMergeUndoAction=false,bool ReturnValue) { return default; }
	public bool SetNodeCategory(UObject InNode,sbyte InCategory,bool bSetupUndoRedo=true,bool bMergeUndoAction=false,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SetNodeCategoryByName(sbyte InNodeName,sbyte InCategory,bool bSetupUndoRedo=true,bool bMergeUndoAction=false,bool ReturnValue) { return default; }
	public bool SetNodeKeywords(UObject InNode,sbyte InKeywords,bool bSetupUndoRedo=true,bool bMergeUndoAction=false,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SetNodeKeywordsByName(sbyte InNodeName,sbyte InKeywords,bool bSetupUndoRedo=true,bool bMergeUndoAction=false,bool ReturnValue) { return default; }
	public bool SetNodeDescription(UObject InNode,sbyte InDescription,bool bSetupUndoRedo=true,bool bMergeUndoAction=false,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SetNodeDescriptionByName(sbyte InNodeName,sbyte InDescription,bool bSetupUndoRedo=true,bool bMergeUndoAction=false,bool ReturnValue) { return default; }
	public bool SetCommentText(UObject InNode,sbyte InCommentText,int InCommentFontSize,bool bInCommentBubbleVisible,bool bInCommentColorBubble,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SetCommentTextByName(sbyte InNodeName,sbyte InCommentText,int InCommentFontSize,bool bInCommentBubbleVisible,bool bInCommentColorBubble,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SetRerouteCompactness(UObject InNode,bool bShowAsFullNode,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SetRerouteCompactnessByName(sbyte InNodeName,bool bShowAsFullNode,bool bSetupUndoRedo=true,bool ReturnValue) { return default; }
	public bool RenameVariable(sbyte InOldName,sbyte InNewName,bool bSetupUndoRedo=true,bool ReturnValue) { return default; }
	public bool RenameParameter(sbyte InOldName,sbyte InNewName,bool bSetupUndoRedo=true,bool ReturnValue) { return default; }
	public bool SetPinExpansion(sbyte InPinPath,bool bIsExpanded,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SetPinIsWatched(sbyte InPinPath,bool bIsWatched,bool bSetupUndoRedo=true,bool ReturnValue) { return default; }
	public sbyte GetPinDefaultValue(sbyte InPinPath,sbyte ReturnValue) { return default; }
	public bool SetPinDefaultValue(sbyte InPinPath,sbyte InDefaultValue,bool bResizeArrays=true,bool bSetupUndoRedo=true,bool bMergeUndoAction=false,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool ResetPinDefaultValue(sbyte InPinPath,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public sbyte AddAggregatePin(sbyte InNodeName,sbyte InPinName,sbyte InDefaultValue=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,sbyte ReturnValue) { return default; }
	public bool RemoveAggregatePin(sbyte InPinPath,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public sbyte AddArrayPin(sbyte InArrayPinPath,sbyte InDefaultValue=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,sbyte ReturnValue) { return default; }
	public sbyte DuplicateArrayPin(sbyte InArrayElementPinPath,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,sbyte ReturnValue) { return default; }
	public sbyte InsertArrayPin(sbyte InArrayPinPath,int InIndex=-1,sbyte InDefaultValue=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,sbyte ReturnValue) { return default; }
	public bool RemoveArrayPin(sbyte InArrayElementPinPath,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool ClearArrayPin(sbyte InArrayPinPath,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SetArrayPinSize(sbyte InArrayPinPath,int InSize,sbyte InDefaultValue=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool BindPinToVariable(sbyte InPinPath,sbyte InNewBoundVariablePath,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool UnbindPinFromVariable(sbyte InPinPath,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool MakeBindingsFromVariableNode(sbyte InNodeName,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool MakeVariableNodeFromBinding(sbyte InPinPath,FVector2D InNodePosition=FVector2D,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool PromotePinToVariable(sbyte InPinPath,bool bCreateVariableNode,FVector2D InNodePosition=FVector2D,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool AddLink(sbyte InOutputPinPath,sbyte InInputPinPath,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,ERigVMPinDirection InUserDirection=ERigVMPinDirection,bool bCreateCastNode=false,bool ReturnValue) { return default; }
	public bool BreakLink(sbyte InOutputPinPath,sbyte InInputPinPath,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool BreakAllLinks(sbyte InPinPath,bool bAsInput=true,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public sbyte AddExposedPin(sbyte InPinName,ERigVMPinDirection InDirection,sbyte InCPPType,sbyte InCPPTypeObjectPath,sbyte InDefaultValue,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,sbyte ReturnValue) { return default; }
	public bool RemoveExposedPin(sbyte InPinName,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool RenameExposedPin(sbyte InOldPinName,sbyte InNewPinName,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool ChangeExposedPinType(sbyte InPinName,sbyte InCPPType,sbyte InCPPTypeObjectPath,bool bSetupUndoRedo,bool bSetupOrphanPins=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SetExposedPinIndex(sbyte InPinName,int InNewIndex,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public UObject AddFunctionReferenceNodeFromDescription(FRigVMGraphFunctionHeader InFunctionDefinition,FVector2D InNodePosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool bAllowPrivateFunctions=false,UObject ReturnValue) { return default; }
	public UObject AddExternalFunctionReferenceNode(sbyte InHostPath,sbyte InFunctionName,FVector2D InNodePosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public UObject AddFunctionReferenceNode(UObject InFunctionDefinition,FVector2D InNodePosition=FVector2D,sbyte InNodeName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public bool SetRemappedVariable(UObject InFunctionRefNode,sbyte InInnerVariableName,sbyte InOuterVariableName,bool bSetupUndoRedo=true,bool ReturnValue) { return default; }
	public UObject AddFunctionToLibrary(sbyte InFunctionName,bool bMutable,FVector2D InNodePosition=FVector2D,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,UObject ReturnValue) { return default; }
	public bool RemoveFunctionFromLibrary(sbyte InFunctionName,bool bSetupUndoRedo=true,bool ReturnValue) { return default; }
	public bool RenameFunction(sbyte InOldFunctionName,sbyte InNewFunctionName,bool bSetupUndoRedo=true,bool ReturnValue) { return default; }
	public bool MarkFunctionAsPublic(sbyte InFunctionName,bool bInIsPublic,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool IsFunctionPublic(sbyte InFunctionName,bool ReturnValue) { return default; }
	public FRigVMGraphVariableDescription AddLocalVariable(sbyte InVariableName,sbyte InCPPType,UObject InCPPTypeObject,sbyte InDefaultValue,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,FRigVMGraphVariableDescription ReturnValue) { return default; }
	public FRigVMGraphVariableDescription AddLocalVariableFromObjectPath(sbyte InVariableName,sbyte InCPPType,sbyte InCPPTypeObjectPath,sbyte InDefaultValue,bool bSetupUndoRedo=true,FRigVMGraphVariableDescription ReturnValue) { return default; }
	public bool RemoveLocalVariable(sbyte InVariableName,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool RenameLocalVariable(sbyte InVariableName,sbyte InNewVariableName,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SetLocalVariableType(sbyte InVariableName,sbyte InCPPType,UObject InCPPTypeObject,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SetLocalVariableTypeFromObjectPath(sbyte InVariableName,sbyte InCPPType,sbyte InCPPTypeObjectPath,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SetLocalVariableDefaultValue(sbyte InVariableName,sbyte InDefaultValue,bool bSetupUndoRedo=true,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public UObject MakeOptionsForWorkflow(UObject InSubject,FRigVMUserWorkflow InWorkflow,UObject ReturnValue) { return default; }
	public bool PerformUserWorkflow(FRigVMUserWorkflow InWorkflow,UObject InOptions,bool bSetupUndoRedo=true,bool ReturnValue) { return default; }
	public void SetIsRunningUnitTest(bool bIsRunning) {}
	public FRigVMGraphModifiedDynamicEvent ModifiedEventDynamic;
	public TArray<URigVMGraph> Graphs;
	public URigVMActionStack ActionStack;
}
