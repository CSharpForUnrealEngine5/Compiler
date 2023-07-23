#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserDataSubsystem.h")]
///<summary>Subsystem that provides access to Content Browser data.</summary>
public partial class UContentBrowserDataSubsystem : UEditorSubsystem {
// ContentBrowserDataSubsystem
	public bool ActivateDataSource(sbyte Name,bool ReturnValue) { return default; }
	public bool DeactivateDataSource(sbyte Name,bool ReturnValue) { return default; }
	public void ActivateAllDataSources() {}
	public void DeactivateAllDataSources() {}
	public TArray<sbyte> GetAvailableDataSources(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetActiveDataSources(TArray<sbyte> ReturnValue) { return default; }
	public TArray<FContentBrowserItem> GetItemsUnderPath(sbyte InPath,FContentBrowserDataFilter InFilter,TArray<FContentBrowserItem> ReturnValue) { return default; }
	public TArray<FContentBrowserItem> GetItemsAtPath(sbyte InPath,EContentBrowserItemTypeFilter InItemTypeFilter,TArray<FContentBrowserItem> ReturnValue) { return default; }
	public FContentBrowserItem GetItemAtPath(sbyte InPath,EContentBrowserItemTypeFilter InItemTypeFilter,FContentBrowserItem ReturnValue) { return default; }
	public TArray<sbyte> EnabledDataSources;
}
