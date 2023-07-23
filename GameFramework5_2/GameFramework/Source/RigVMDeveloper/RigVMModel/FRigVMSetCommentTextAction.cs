#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action setting a comment node's text in the graph.</summary>
public partial struct FRigVMSetCommentTextAction {
// RigVMSetCommentTextAction
	public sbyte NodePath;
	public sbyte OldText;
	public sbyte NewText;
	public int OldFontSize;
	public int NewFontSize;
	public bool bOldBubbleVisible;
	public bool bNewBubbleVisible;
	public bool bOldColorBubble;
	public bool bNewColorBubble;
}
