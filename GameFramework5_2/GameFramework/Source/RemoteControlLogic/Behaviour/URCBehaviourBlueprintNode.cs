#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Behaviour/RCBehaviourBlueprintNode.h")]
///<summary>Base blueprint class for behaviour node which holds the logic to execute behaviour</summary>
public partial class URCBehaviourBlueprintNode : URCBehaviourNode {
// RCBehaviourBlueprintNode
	public bool IsSupported(UObject InBehaviour,bool ReturnValue) { return default; }
	public bool Execute(UObject InBehaviour,bool ReturnValue) { return default; }
	public void PreExecute(UObject InBehaviour) {}
	public void OnPassed(UObject InBehaviour) {}
}
