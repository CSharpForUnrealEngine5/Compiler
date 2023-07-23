#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/ModifierBoundWidgetStyleDefinitions.h")]
///<summary>Associates information with modifiers and their connection points.</summary>
public partial class UModifierBoundWidgetStyleDefinitions : UObject {
// ModifierBoundWidgetStyleDefinitions
	public TArray<UObject> GetStylesForModifier(UObject Modifier,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetStylesForConnectionPoint(UObject Modifier,sbyte ConnectionPoint,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetStylesForName(sbyte Category,TArray<UObject> ReturnValue) { return default; }
	public UObject GetStyleForModifierByClass(UObject Modifier,UClass Class,UObject ReturnValue) { return default; }
	public UObject GetStyleForConnectionPointByClass(UObject Modifier,sbyte ConnectionPoint,UClass Class,UObject ReturnValue) { return default; }
	public UObject GetStyleForNameByClass(sbyte Category,UClass Class,UObject ReturnValue) { return default; }
}
