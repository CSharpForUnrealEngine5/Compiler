#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/ModifierBoundWidgetStylesAsset.h")]
///<summary>An asset intended to be referenced by Slate widgets.</summary>
public partial class UModifierBoundWidgetStylesAsset : UObject {
// ModifierBoundWidgetStylesAsset
	public UModifierBoundWidgetStyleDefinitions Rules;
	public TArray<UObject> GetStylesForModifier(UObject Modifier,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetStylesForConnectionPoint(UObject Modifier,sbyte ConnectionPoint,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetStylesForName(sbyte Category,TArray<UObject> ReturnValue) { return default; }
	public UObject GetStyleForModifierByClass(UObject Modifier,UClass Class,UObject ReturnValue) { return default; }
	public UObject GetStyleForConnectionPointByClass(UObject Modifier,sbyte ConnectionPoint,UClass Class,UObject ReturnValue) { return default; }
	public UObject GetStyleForNameByClass(sbyte Name,UClass Class,UObject ReturnValue) { return default; }
}
