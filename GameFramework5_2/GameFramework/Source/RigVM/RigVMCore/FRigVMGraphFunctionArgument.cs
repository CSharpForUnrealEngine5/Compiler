#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMGraphFunctionDefinition.h")]
public partial struct FRigVMGraphFunctionArgument {
// RigVMGraphFunctionArgument
	public sbyte Name;
	public sbyte DisplayName;
	public sbyte CPPType;
	public TSoftObjectPtr<UObject> CPPTypeObject;
	public bool bIsArray;
	public ERigVMPinDirection Direction;
	public sbyte DefaultValue;
	public bool bIsConst;
	public TMap<sbyte,sbyte> PathToTooltip;
}
