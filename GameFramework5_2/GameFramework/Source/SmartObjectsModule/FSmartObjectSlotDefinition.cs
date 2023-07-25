#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectDefinition.h")]
///<summary>Persistent and sharable definition of a smart object slot.</summary>
public partial struct FSmartObjectSlotDefinition {
// SmartObjectSlotDefinition
	public string Name;
	public FColor DEBUG_DrawColor;
	public FGuid ID;
	public bool bEnabled;
	public FGameplayTagContainer RuntimeTags;
	public FGameplayTagQuery UserTagFilter;
	public FGameplayTagContainer ActivityTags;
	public FWorldConditionQueryDefinition SelectionPreconditions;
	public FVector Offset;
	public FRotator Rotation;
	public TArray<FInstancedStruct> Data;
	public TArray<USmartObjectBehaviorDefinition> BehaviorDefinitions;
}
