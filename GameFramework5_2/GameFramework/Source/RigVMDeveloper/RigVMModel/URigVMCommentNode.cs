#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/Nodes/RigVMCommentNode.h")]
///<summary>Comment Nodes can be used to annotate a Graph by adding</summary>
public partial class URigVMCommentNode : URigVMNode {
// RigVMCommentNode
	public sbyte GetCommentText(sbyte ReturnValue) { return default; }
	public int GetCommentFontSize(int ReturnValue) { return default; }
	public bool GetCommentBubbleVisible(bool ReturnValue) { return default; }
	public bool GetCommentColorBubble(bool ReturnValue) { return default; }
	public sbyte CommentText;
	public int FontSize;
	public bool bBubbleVisible;
	public bool bColorBubble;
}
