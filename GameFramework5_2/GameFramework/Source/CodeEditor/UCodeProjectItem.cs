#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CodeProjectItem.h")]
public partial class UCodeProjectItem : UObject {
// CodeProjectItem
	public byte Type;
	public sbyte Name;
	public sbyte Extension;
	public sbyte Path;
	public TArray<UCodeProjectItem> Children;
}
