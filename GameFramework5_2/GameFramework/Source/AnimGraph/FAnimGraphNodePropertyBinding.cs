#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_Base.h")]
public partial struct FAnimGraphNodePropertyBinding {
// AnimGraphNodePropertyBinding
	public FEdGraphPinType PinType;
	public FEdGraphPinType PromotedPinType;
	public sbyte PropertyName;
	public int ArrayIndex;
	public sbyte PathAsText;
	public TArray<sbyte> PropertyPath;
	public sbyte ContextId;
	public sbyte CompiledContext;
	public sbyte CompiledContextDesc;
	public EAnimGraphNodePropertyBindingType Type;
	public bool bIsBound;
	public bool bIsPromotion;
}
