#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Blueprint.h")]
///<summary>Struct indicating a variable in the generated class</summary>
public partial struct FBPVariableDescription {
// BPVariableDescription
	public sbyte VarName;
	public FGuid VarGuid;
	public FEdGraphPinType VarType;
	public sbyte FriendlyName;
	public sbyte Category;
	public ulong PropertyFlags;
	public sbyte RepNotifyFunc;
	public byte ReplicationCondition;
	public TArray<FBPVariableMetaDataEntry> MetaDataArray;
	public sbyte DefaultValue;
}
