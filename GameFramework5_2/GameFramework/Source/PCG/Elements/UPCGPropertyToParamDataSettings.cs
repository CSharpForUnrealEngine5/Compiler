#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGPropertyToParamData.h")]
///<summary>Extract a property value from an actor/component into a ParamData.</summary>
public partial class UPCGPropertyToParamDataSettings : UPCGSettings {
// PCGPropertyToParamDataSettings
	public FPCGActorSelectorSettings ActorSelector;
	public bool bSelectComponent;
	public UClass ComponentClass;
	public sbyte PropertyName;
	public bool bExtractObjectAndStruct;
	public sbyte OutputAttributeName;
	public bool bAlwaysRequeryActors;
	public bool bTrackActorsOnlyWithinBounds;
	public EPCGActorSelection ActorSelection_DEPRECATED;
	public sbyte ActorSelectionTag_DEPRECATED;
	public sbyte ActorSelectionName_DEPRECATED;
	public UClass ActorSelectionClass_DEPRECATED;
	public EPCGActorFilter ActorFilter_DEPRECATED;
	public bool bIncludeChildren_DEPRECATED;
}
