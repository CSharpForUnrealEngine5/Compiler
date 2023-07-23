#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserItemPath.h")]
public partial class UContentBrowserItemPathExtensions : UBlueprintFunctionLibrary {
// ContentBrowserItemPathExtensions
	public void SetPath(FContentBrowserItemPath ItemPath,sbyte InPath,EContentBrowserPathType InPathType) {}
	public sbyte GetVirtualPath(FContentBrowserItemPath ItemPath,sbyte ReturnValue) { return default; }
	public sbyte GetInternalPath(FContentBrowserItemPath ItemPath,sbyte ReturnValue) { return default; }
	public FContentBrowserItemPath MakeContentBrowserItemPath(sbyte InPath,EContentBrowserPathType InPathType,FContentBrowserItemPath ReturnValue) { return default; }
	public void BreakContentBrowserItemPath(FContentBrowserItemPath ItemPath,sbyte VirtualPath,sbyte InternalPath) {}
}
