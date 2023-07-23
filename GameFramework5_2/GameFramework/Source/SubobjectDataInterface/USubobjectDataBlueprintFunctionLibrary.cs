#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubobjectDataBlueprintFunctionLibrary.h")]
///<summary>A function library with wrappers around the getter/setter functions for FSubobjectData</summary>
public partial class USubobjectDataBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// SubobjectDataBlueprintFunctionLibrary
	public bool IsValid(FSubobjectData Data,bool ReturnValue) { return default; }
	public bool IsHandleValid(FSubobjectDataHandle DataHandle,bool ReturnValue) { return default; }
	public void GetData(FSubobjectDataHandle DataHandle,FSubobjectData OutData) {}
	public void GetHandle(FSubobjectData Data,FSubobjectDataHandle OutHandle) {}
	public sbyte GetDisplayName(FSubobjectData Data,sbyte ReturnValue) { return default; }
	public sbyte GetVariableName(FSubobjectData Data,sbyte ReturnValue) { return default; }
	public bool IsAttachedTo(FSubobjectData Data,FSubobjectDataHandle InHandle,bool ReturnValue) { return default; }
	public bool CanEdit(FSubobjectData Data,bool ReturnValue) { return default; }
	public bool CanDelete(FSubobjectData Data,bool ReturnValue) { return default; }
	public bool CanDuplicate(FSubobjectData Data,bool ReturnValue) { return default; }
	public bool CanCopy(FSubobjectData Data,bool ReturnValue) { return default; }
	public bool CanReparent(FSubobjectData Data,bool ReturnValue) { return default; }
	public bool CanRename(FSubobjectData Data,bool ReturnValue) { return default; }
	public UObject GetObject(FSubobjectData Data,bool bEvenIfPendingKill=false,UObject ReturnValue) { return default; }
	public UObject GetObjectForBlueprint(FSubobjectData Data,UObject Blueprint,UObject ReturnValue) { return default; }
	public UObject GetBlueprint(FSubobjectData Data,UObject ReturnValue) { return default; }
	public bool IsInstancedComponent(FSubobjectData Data,bool ReturnValue) { return default; }
	public bool IsInstancedActor(FSubobjectData Data,bool ReturnValue) { return default; }
	public bool IsNativeComponent(FSubobjectData Data,bool ReturnValue) { return default; }
	public bool IsInheritedComponent(FSubobjectData Data,bool ReturnValue) { return default; }
	public bool IsSceneComponent(FSubobjectData Data,bool ReturnValue) { return default; }
	public bool IsRootComponent(FSubobjectData Data,bool ReturnValue) { return default; }
	public bool IsDefaultSceneRoot(FSubobjectData Data,bool ReturnValue) { return default; }
	public bool IsComponent(FSubobjectData Data,bool ReturnValue) { return default; }
	public bool IsChildActor(FSubobjectData Data,bool ReturnValue) { return default; }
	public bool IsRootActor(FSubobjectData Data,bool ReturnValue) { return default; }
	public bool IsActor(FSubobjectData Data,bool ReturnValue) { return default; }
}
