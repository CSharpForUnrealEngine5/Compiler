#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraStackEditorData.h")]
///<summary>Editor only UI data for emitters.</summary>
public partial class UNiagaraStackEditorData : UNiagaraEditorDataBase {
// NiagaraStackEditorData
	public bool bHideDisabledModules;
	public TMap<sbyte,bool> StackEntryKeyToExpandedMap;
	public TMap<sbyte,bool> StackEntryKeyToExpandedOverviewMap;
	public TMap<sbyte,sbyte> StackEntryKeyToDisplayName;
	public TArray<sbyte> DismissedStackIssueIds;
}
