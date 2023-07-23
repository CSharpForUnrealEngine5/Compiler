#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_EditablePinBase.h")]
///<summary>This structure describes metadata associated with a user declared function or macro</summary>
public partial struct FKismetUserDeclaredFunctionMetadata {
// KismetUserDeclaredFunctionMetadata
	public sbyte ToolTip;
	public sbyte Category;
	public sbyte Keywords;
	public sbyte CompactNodeTitle;
	public FLinearColor InstanceTitleColor;
	public sbyte DeprecationMessage;
	public bool bIsDeprecated;
	public bool bCallInEditor;
	public bool bThreadSafe;
	public bool bIsUnsafeDuringActorConstruction;
	public short HasLatentFunctions;
	public TMap<sbyte,sbyte> MetaDataMap;
}
