#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConstraintsScripting.h")]
///<summary>This is a set of helper functions to access various parts of the Sequencer and Control Rig API via Python and Blueprints.</summary>
public partial class UConstraintsScriptingLibrary : UBlueprintFunctionLibrary {
// ConstraintsScriptingLibrary
	public UObject GetManager(UObject InWorld,UObject ReturnValue) { return default; }
	public UObject CreateTransformableComponentHandle(UObject InWorld,UObject InSceneComponent,sbyte InSocketName,UObject ReturnValue) { return default; }
	public UObject CreateTransformableHandle(UObject InWorld,UObject InObject,sbyte InAttachmentName=NAME_None,UObject ReturnValue) { return default; }
	public UObject CreateFromType(UObject InWorld,ETransformConstraintType InType,UObject ReturnValue) { return default; }
	public bool AddConstraint(UObject InWorld,UObject InParentHandle,UObject InChildHandle,UObject InConstraint,bool bMaintainOffset,bool ReturnValue) { return default; }
	public TArray<UObject> GetConstraintsArray(UObject InWorld,TArray<UObject> ReturnValue) { return default; }
	public bool RemoveThisConstraint(UObject InWorld,UObject InTickableConstraint,bool ReturnValue) { return default; }
	public bool RemoveConstraint(UObject InWorld,int InIndex,bool ReturnValue) { return default; }
}
