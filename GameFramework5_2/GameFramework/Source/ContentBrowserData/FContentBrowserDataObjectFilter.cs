#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserDataFilter.h")]
///<summary>Data used to filter object instances by their name and tags.</summary>
public partial struct FContentBrowserDataObjectFilter {
// ContentBrowserDataObjectFilter
	public TArray<sbyte> ObjectNamesToInclude;
	public TArray<sbyte> ObjectNamesToExclude;
	public bool bOnDiskObjectsOnly;
}
