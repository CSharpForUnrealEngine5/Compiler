#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMPin.h")]
///<summary>The Pin represents a single connector / pin on a node in the RigVM model.</summary>
public partial class URigVMPin : UObject {
// RigVMPin
	public string GetPinPath(bool bUseNodePath/*=false*/) { return default; }
	public string GetSubPinPath(UObject InParentPin,bool bIncludeParentPinName/*=false*/) { return default; }
	public string GetSegmentPath(bool bIncludeRootPin/*=false*/) { return default; }
	public string GetDisplayName() { return default; }
	public ERigVMPinDirection GetDirection() { return default; }
	public bool IsExpanded() { return default; }
	public bool IsDefinedAsConstant() { return default; }
	public bool RequiresWatch(bool bCheckExposedPinChain/*=false*/) { return default; }
	public bool IsEnum() { return default; }
	public bool IsStruct() { return default; }
	public bool IsStructMember() { return default; }
	public bool IsUObject() { return default; }
	public bool IsInterface() { return default; }
	public bool IsArray() { return default; }
	public bool IsArrayElement() { return default; }
	public bool IsDynamicArray() { return default; }
	public bool IsReferenceCountedContainer() { return default; }
	public bool IsLazy() { return default; }
	public int GetPinIndex() { return default; }
	public int GetAbsolutePinIndex() { return default; }
	public int GetArraySize() { return default; }
	public string GetCPPType() { return default; }
	public string GetArrayElementCppType() { return default; }
	public bool IsStringType() { return default; }
	public bool IsExecuteContext() { return default; }
	public bool IsWildCard() { return default; }
	public bool ContainsWildCardSubPin() { return default; }
	public bool IsFixedSizeArray() { return default; }
	public string GetDefaultValue() { return default; }
	public string GetCustomWidgetName() { return default; }
	public string GetToolTipText() { return default; }
	public UObject GetCPPTypeObject() { return default; }
	public UObject GetScriptStruct() { return default; }
	public UObject GetEnum() { return default; }
	public UObject GetParentPin() { return default; }
	public UObject GetRootPin() { return default; }
	public bool IsRootPin() { return default; }
	public UObject GetPinForLink() { return default; }
	public UObject FindLinkForPin(UObject InOtherPin) { return default; }
	public UObject GetOriginalPinFromInjectedNode() { return default; }
	public TArray<UObject> GetSubPins() { return default; }
	public UObject FindSubPin(string InPinPath) { return default; }
	public bool IsLinkedTo(UObject InPin) { return default; }
	public TArray<UObject> GetLinks() { return default; }
	public TArray<UObject> GetLinkedSourcePins(bool bRecursive/*=false*/) { return default; }
	public TArray<UObject> GetLinkedTargetPins(bool bRecursive/*=false*/) { return default; }
	public TArray<UObject> GetSourceLinks(bool bRecursive/*=false*/) { return default; }
	public TArray<UObject> GetTargetLinks(bool bRecursive/*=false*/) { return default; }
	public UObject GetNode() { return default; }
	public UObject GetGraph() { return default; }
	public string DisplayName;
	public ERigVMPinDirection Direction;
	public bool bIsExpanded;
	public bool bIsConstant;
	public bool bRequiresWatch;
	public bool bIsDynamicArray;
	public string CPPType;
	public UObject CPPTypeObject;
	public string CPPTypeObjectPath;
	public string DefaultValue;
	public string CustomWidgetName;
	public TArray<URigVMPin> SubPins;
	public TArray<URigVMLink> Links;
	public TArray<URigVMInjectionInfo> InjectionInfos;
	public string BoundVariablePath_DEPRECATED;
}
