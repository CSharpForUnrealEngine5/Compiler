#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>The Action Stack can be used to track actions happening on a</summary>
public partial class URigVMActionStack : UObject {
// RigVMActionStack
	public bool OpenUndoBracket(sbyte InTitle,bool ReturnValue) { return default; }
	public bool CloseUndoBracket(UObject InController,bool ReturnValue) { return default; }
	public bool CancelUndoBracket(UObject InController,bool ReturnValue) { return default; }
	public bool Undo(UObject InController,bool ReturnValue) { return default; }
	public bool Redo(UObject InController,bool ReturnValue) { return default; }
	public int ActionIndex;
	public TArray<FRigVMActionKey> UndoActions;
	public TArray<FRigVMActionKey> RedoActions;
}
