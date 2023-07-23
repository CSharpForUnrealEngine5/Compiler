#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubobjectDataSubsystem.h")]
///<summary>The Subobject Data Subsystem will produce the reflected subobject data</summary>
public partial class USubobjectDataSubsystem : UEngineSubsystem {
// SubobjectDataSubsystem
	public void K2_GatherSubobjectDataForBlueprint(UObject Context,TArray<FSubobjectDataHandle> OutArray) {}
	public void K2_GatherSubobjectDataForInstance(UObject Context,TArray<FSubobjectDataHandle> OutArray) {}
	public bool K2_FindSubobjectDataFromHandle(FSubobjectDataHandle Handle,FSubobjectData OutData,bool ReturnValue) { return default; }
	public FSubobjectDataHandle FindHandleForObject(FSubobjectDataHandle Context,UObject ObjectToFind,UObject BPContext=nullptr,FSubobjectDataHandle ReturnValue) { return default; }
	public UClass CreateNewCPPComponent(UClass ComponentClass,sbyte NewClassPath,sbyte NewClassName,UClass ReturnValue) { return default; }
	public UClass CreateNewBPComponent(UClass ComponentClass,sbyte NewClassPath,sbyte NewClassName,UClass ReturnValue) { return default; }
	public FSubobjectDataHandle AddNewSubobject(FAddNewSubobjectParams Params,sbyte FailReason,FSubobjectDataHandle ReturnValue) { return default; }
	public int DeleteSubobjects(FSubobjectDataHandle ContextHandle,TArray<FSubobjectDataHandle> SubobjectsToDelete,UObject BPContext=nullptr,int ReturnValue) { return default; }
	public int K2_DeleteSubobjectsFromInstance(FSubobjectDataHandle ContextHandle,TArray<FSubobjectDataHandle> SubobjectsToDelete,int ReturnValue) { return default; }
	public int DeleteSubobject(FSubobjectDataHandle ContextHandle,FSubobjectDataHandle SubobjectToDelete,UObject BPContext=nullptr,int ReturnValue) { return default; }
	public int K2_DeleteSubobjectFromInstance(FSubobjectDataHandle ContextHandle,FSubobjectDataHandle SubobjectToDelete,int ReturnValue) { return default; }
	public bool RenameSubobject(FSubobjectDataHandle Handle,sbyte InNewName,bool ReturnValue) { return default; }
	public bool ChangeSubobjectClass(FSubobjectDataHandle Handle,UClass NewClass,bool ReturnValue) { return default; }
	public bool ReparentSubobject(FReparentSubobjectParams Params,FSubobjectDataHandle ToReparentHandle,bool ReturnValue) { return default; }
	public bool MakeNewSceneRoot(FSubobjectDataHandle Context,FSubobjectDataHandle NewSceneRoot,UObject BPContext,bool ReturnValue) { return default; }
	public bool ReparentSubobjects(FReparentSubobjectParams Params,TArray<FSubobjectDataHandle> HandlesToMove,bool ReturnValue) { return default; }
	public bool DetachSubobject(FSubobjectDataHandle OwnerHandle,FSubobjectDataHandle ChildToRemove,bool ReturnValue) { return default; }
	public bool AttachSubobject(FSubobjectDataHandle OwnerHandle,FSubobjectDataHandle ChildToAddHandle,bool ReturnValue) { return default; }
	public bool IsValidRename(FSubobjectDataHandle Handle,sbyte InNewText,sbyte OutErrorMessage,bool ReturnValue) { return default; }
	public bool CanCopySubobjects(TArray<FSubobjectDataHandle> Handles,bool ReturnValue) { return default; }
	public void CopySubobjects(TArray<FSubobjectDataHandle> Handles,UObject BpContext) {}
	public bool CanPasteSubobjects(FSubobjectDataHandle RootHandle,UObject BPContext=nullptr,bool ReturnValue) { return default; }
	public void RenameSubobjectMemberVariable(UObject BPContext,FSubobjectDataHandle InHandle,sbyte NewName) {}
}
