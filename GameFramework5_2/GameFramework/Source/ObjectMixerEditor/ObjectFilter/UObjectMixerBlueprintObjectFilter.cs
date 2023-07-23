#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectFilter/ObjectMixerEditorObjectFilter.h")]
///<summary>Script class for filtering object types to Object Mixer.</summary>
public partial class UObjectMixerBlueprintObjectFilter : UObjectMixerObjectFilter {
// ObjectMixerBlueprintObjectFilter
	public TSet<UClass> GetObjectClassesToFilter(TSet<UClass> ReturnValue) { return default; }
	public TSet<UClass> GetObjectClassesToPlace(TSet<UClass> ReturnValue) { return default; }
	public sbyte GetRowDisplayName(UObject InObject,bool bIsHybridRow,sbyte ReturnValue) { return default; }
	public sbyte GetRowTooltipText(UObject InObject,bool bIsHybridRow,sbyte ReturnValue) { return default; }
	public bool GetRowEditorVisibility(UObject InObject,bool ReturnValue) { return default; }
	public void OnSetRowEditorVisibility(UObject InObject,bool bNewIsVisible) {}
	public TSet<sbyte> GetColumnsToShowByDefault(TSet<sbyte> ReturnValue) { return default; }
	public TSet<sbyte> GetColumnsToExclude(TSet<sbyte> ReturnValue) { return default; }
	public TSet<sbyte> GetForceAddedColumns(TSet<sbyte> ReturnValue) { return default; }
	public EObjectMixerInheritanceInclusionOptions GetObjectMixerPropertyInheritanceInclusionOptions(EObjectMixerInheritanceInclusionOptions ReturnValue) { return default; }
	public EObjectMixerInheritanceInclusionOptions GetObjectMixerPlacementClassInclusionOptions(EObjectMixerInheritanceInclusionOptions ReturnValue) { return default; }
	public bool ShouldIncludeUnsupportedProperties(bool ReturnValue) { return default; }
	public TSet<sbyte> GetPropertiesThatRequireListRefresh(TSet<sbyte> ReturnValue) { return default; }
}
