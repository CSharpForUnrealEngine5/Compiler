#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureEditorMode.h")]
public partial class UFractureModeCustomizationSettings : UDeveloperSettings {
// FractureModeCustomizationSettings
	public TArray<sbyte> ToolSectionOrder;
	public TArray<sbyte> ToolFavorites;
	public TArray<FFractureModeCustomSectionColor> SectionColors;
	public TArray<FFractureModeCustomToolColor> ToolColors;
}
