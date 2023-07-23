#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/InterchangeUserDefinedAttribute.h")]
///<summary>UInterchangeUserDefinedAttributesAPI is used to store and retrieve user defined attributes (i.e. DCC node attributes, pipelines will have access to those attributes)</summary>
public partial class UInterchangeUserDefinedAttributesAPI : UObject {
// InterchangeUserDefinedAttributesAPI
	public bool CreateUserDefinedAttribute_Boolean(UObject InterchangeNode,sbyte UserDefinedAttributeName,bool Value,sbyte PayloadKey,bool ReturnValue) { return default; }
	public bool CreateUserDefinedAttribute_Float(UObject InterchangeNode,sbyte UserDefinedAttributeName,float Value,sbyte PayloadKey,bool ReturnValue) { return default; }
	public bool CreateUserDefinedAttribute_Double(UObject InterchangeNode,sbyte UserDefinedAttributeName,double Value,sbyte PayloadKey,bool ReturnValue) { return default; }
	public bool CreateUserDefinedAttribute_Int32(UObject InterchangeNode,sbyte UserDefinedAttributeName,int Value,sbyte PayloadKey,bool ReturnValue) { return default; }
	public bool CreateUserDefinedAttribute_FString(UObject InterchangeNode,sbyte UserDefinedAttributeName,sbyte Value,sbyte PayloadKey,bool ReturnValue) { return default; }
	public bool RemoveUserDefinedAttribute(UObject InterchangeNode,sbyte UserDefinedAttributeName,bool ReturnValue) { return default; }
	public bool GetUserDefinedAttribute_Boolean(UObject InterchangeNode,sbyte UserDefinedAttributeName,bool OutValue,sbyte OutPayloadKey,bool ReturnValue) { return default; }
	public bool GetUserDefinedAttribute_Float(UObject InterchangeNode,sbyte UserDefinedAttributeName,float OutValue,sbyte OutPayloadKey,bool ReturnValue) { return default; }
	public bool GetUserDefinedAttribute_Double(UObject InterchangeNode,sbyte UserDefinedAttributeName,double OutValue,sbyte OutPayloadKey,bool ReturnValue) { return default; }
	public bool GetUserDefinedAttribute_Int32(UObject InterchangeNode,sbyte UserDefinedAttributeName,int OutValue,sbyte OutPayloadKey,bool ReturnValue) { return default; }
	public bool GetUserDefinedAttribute_FString(UObject InterchangeNode,sbyte UserDefinedAttributeName,sbyte OutValue,sbyte OutPayloadKey,bool ReturnValue) { return default; }
	public void GetUserDefinedAttributeInfos(UObject InterchangeNode,TArray<FInterchangeUserDefinedAttributeInfo> UserDefinedAttributeInfos) {}
	public void DuplicateAllUserDefinedAttribute(UObject InterchangeSourceNode,UObject InterchangeDestinationNode,bool bAddSourceNodeName) {}
}
