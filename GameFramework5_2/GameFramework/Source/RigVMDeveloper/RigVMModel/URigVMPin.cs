#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMPin.h")]
///<summary>The Pin represents a single connector / pin on a node in the RigVM model.</summary>
public partial class URigVMPin : UObject {
// RigVMPin
	public sbyte GetPinPath(bool bUseNodePath=false,sbyte ReturnValue) { return default; }
	public sbyte GetSubPinPath(UObject InParentPin,bool bIncludeParentPinName=false,sbyte ReturnValue) { return default; }
	public sbyte GetSegmentPath(bool bIncludeRootPin=false,sbyte ReturnValue) { return default; }
	public sbyte GetDisplayName(sbyte ReturnValue) { return default; }
	public ERigVMPinDirection GetDirection(ERigVMPinDirection ReturnValue) { return default; }
	public bool IsExpanded(bool ReturnValue) { return default; }
	public bool IsDefinedAsConstant(bool ReturnValue) { return default; }
	public bool RequiresWatch(bool bCheckExposedPinChain=false,bool ReturnValue) { return default; }
	public bool IsEnum(bool ReturnValue) { return default; }
	public bool IsStruct(bool ReturnValue) { return default; }
	public bool IsStructMember(bool ReturnValue) { return default; }
	public bool IsUObject(bool ReturnValue) { return default; }
	public bool IsInterface(bool ReturnValue) { return default; }
	public bool IsArray(bool ReturnValue) { return default; }
	public bool IsArrayElement(bool ReturnValue) { return default; }
	public bool IsDynamicArray(bool ReturnValue) { return default; }
	public bool IsReferenceCountedContainer(bool ReturnValue) { return default; }
	public bool IsLazy(bool ReturnValue) { return default; }
	public int GetPinIndex(int ReturnValue) { return default; }
	public int GetAbsolutePinIndex(int ReturnValue) { return default; }
	public int GetArraySize(int ReturnValue) { return default; }
	public sbyte GetCPPType(sbyte ReturnValue) { return default; }
	public sbyte GetArrayElementCppType(sbyte ReturnValue) { return default; }
	public bool IsStringType(bool ReturnValue) { return default; }
	public bool IsExecuteContext(bool ReturnValue) { return default; }
	public bool IsWildCard(bool ReturnValue) { return default; }
	public bool ContainsWildCardSubPin(bool ReturnValue) { return default; }
	public bool IsFixedSizeArray(bool ReturnValue) { return default; }
	public sbyte GetDefaultValue(sbyte ReturnValue) { return default; }
	public sbyte GetCustomWidgetName(sbyte ReturnValue) { return default; }
	public sbyte GetToolTipText(sbyte ReturnValue) { return default; }
	public UObject GetCPPTypeObject(UObject ReturnValue) { return default; }
	public UObject GetScriptStruct(UObject ReturnValue) { return default; }
	public UObject GetEnum(UObject ReturnValue) { return default; }
	public UObject GetParentPin(UObject ReturnValue) { return default; }
	public UObject GetRootPin(UObject ReturnValue) { return default; }
	public bool IsRootPin(bool ReturnValue) { return default; }
	public UObject GetPinForLink(UObject ReturnValue) { return default; }
	public UObject FindLinkForPin(UObject InOtherPin,UObject ReturnValue) { return default; }
	public UObject GetOriginalPinFromInjectedNode(UObject ReturnValue) { return default; }
	public TArray<UObject> GetSubPins(TArray<UObject> ReturnValue) { return default; }
	public UObject FindSubPin(sbyte InPinPath,UObject ReturnValue) { return default; }
	public bool IsLinkedTo(UObject InPin,bool ReturnValue) { return default; }
	public TArray<UObject> GetLinks(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetLinkedSourcePins(bool bRecursive=false,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetLinkedTargetPins(bool bRecursive=false,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetSourceLinks(bool bRecursive=false,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetTargetLinks(bool bRecursive=false,TArray<UObject> ReturnValue) { return default; }
	public UObject GetNode(UObject ReturnValue) { return default; }
	public UObject GetGraph(UObject ReturnValue) { return default; }
	public sbyte DisplayName;
	public ERigVMPinDirection Direction;
	public bool bIsExpanded;
	public bool bIsConstant;
	public bool bRequiresWatch;
	public bool bIsDynamicArray;
	public sbyte CPPType;
	public UObject CPPTypeObject;
	public sbyte CPPTypeObjectPath;
	public sbyte DefaultValue;
	public sbyte CustomWidgetName;
	public TArray<URigVMPin> SubPins;
	public TArray<URigVMLink> Links;
	public TArray<URigVMInjectionInfo> InjectionInfos;
	public sbyte BoundVariablePath_DEPRECATED;
}
