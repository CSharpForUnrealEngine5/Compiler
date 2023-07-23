#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/TargetBasedWidgetStyleDefinitions.h")]
public partial class UTargetBasedWidgetStyleDefinitions : UModifierBoundWidgetStyleDefinitions {
// TargetBasedWidgetStyleDefinitions
	public TMap<sbyte,FTargettedModifierStyleConfig> ModifierToStyle;
	public TMap<sbyte,FWidgetStyleDataArray> CategoriesWithoutModifier;
}
