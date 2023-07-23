#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserDataFilter.h")]
///<summary>Data used to filter object instances by their class.</summary>
public partial struct FContentBrowserDataClassFilter {
// ContentBrowserDataClassFilter
	public TArray<sbyte> ClassNamesToInclude;
	public TArray<sbyte> ClassNamesToExclude;
	public bool bRecursiveClassNamesToInclude;
	public bool bRecursiveClassNamesToExclude;
}
