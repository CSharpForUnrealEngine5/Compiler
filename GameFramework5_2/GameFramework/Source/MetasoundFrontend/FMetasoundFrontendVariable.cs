#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundFrontendDocument.h")]
///<summary>Contains graph data associated with a variable.</summary>
public partial struct FMetasoundFrontendVariable {
// MetasoundFrontendVariable
	public sbyte Name;
	public sbyte DisplayName;
	public sbyte Description;
	public sbyte TypeName;
	public FMetasoundFrontendLiteral Literal;
	public FGuid ID;
	public FGuid VariableNodeID;
	public FGuid MutatorNodeID;
	public TArray<FGuid> AccessorNodeIDs;
	public TArray<FGuid> DeferredAccessorNodeIDs;
}
