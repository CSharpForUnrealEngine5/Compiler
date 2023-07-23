#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Framework/MultiBox/ToolMenuBase.h")]
public partial struct FCustomizedToolMenu {
// CustomizedToolMenu
	public sbyte Name;
	public TMap<sbyte,FCustomizedToolMenuEntry> Entries;
	public TMap<sbyte,FCustomizedToolMenuSection> Sections;
	public TMap<sbyte,FCustomizedToolMenuNameArray> EntryOrder;
	public TArray<sbyte> SectionOrder;
}
