#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorGroupingUtils.h")]
///<summary>Helper class for grouping actors in the level editor</summary>
public partial class UActorGroupingUtils : UObject {
// ActorGroupingUtils
	public bool IsGroupingActive(bool ReturnValue) { return default; }
	public void SetGroupingActive(bool bInGroupingActive) {}
	public UObject Get(UObject ReturnValue) { return default; }
	public UObject GroupSelected(UObject ReturnValue) { return default; }
	public UObject GroupActors(TArray<UObject> ActorsToGroup,UObject ReturnValue) { return default; }
	public void UngroupSelected() {}
	public void UngroupActors(TArray<UObject> ActorsToUngroup) {}
	public void LockSelectedGroups() {}
	public void UnlockSelectedGroups() {}
	public void AddSelectedToGroup() {}
	public void RemoveSelectedFromGroup() {}
}
