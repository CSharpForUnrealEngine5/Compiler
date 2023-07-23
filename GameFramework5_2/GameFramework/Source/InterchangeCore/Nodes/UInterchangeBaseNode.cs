#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/InterchangeBaseNode.h")]
///<summary>This struct is used to store and retrieve key value attributes. The attributes are store in a generic FAttributeStorage which serialize the value in a TArray64<uint8></summary>
public partial class UInterchangeBaseNode : UObject {
// InterchangeBaseNode
	public void InitializeNode(sbyte UniqueID,sbyte DisplayLabel,EInterchangeNodeContainerType NodeContainerType) {}
	public bool RemoveAttribute(sbyte NodeAttributeKey,bool ReturnValue) { return default; }
	public bool AddBooleanAttribute(sbyte NodeAttributeKey,bool Value,bool ReturnValue) { return default; }
	public bool GetBooleanAttribute(sbyte NodeAttributeKey,bool OutValue,bool ReturnValue) { return default; }
	public bool AddInt32Attribute(sbyte NodeAttributeKey,int Value,bool ReturnValue) { return default; }
	public bool GetInt32Attribute(sbyte NodeAttributeKey,int OutValue,bool ReturnValue) { return default; }
	public bool AddFloatAttribute(sbyte NodeAttributeKey,float Value,bool ReturnValue) { return default; }
	public bool GetFloatAttribute(sbyte NodeAttributeKey,float OutValue,bool ReturnValue) { return default; }
	public bool AddDoubleAttribute(sbyte NodeAttributeKey,double Value,bool ReturnValue) { return default; }
	public bool GetDoubleAttribute(sbyte NodeAttributeKey,double OutValue,bool ReturnValue) { return default; }
	public bool AddStringAttribute(sbyte NodeAttributeKey,sbyte Value,bool ReturnValue) { return default; }
	public bool GetStringAttribute(sbyte NodeAttributeKey,sbyte OutValue,bool ReturnValue) { return default; }
	public bool AddGuidAttribute(sbyte NodeAttributeKey,FGuid Value,bool ReturnValue) { return default; }
	public bool GetGuidAttribute(sbyte NodeAttributeKey,FGuid OutValue,bool ReturnValue) { return default; }
	public bool AddLinearColorAttribute(sbyte NodeAttributeKey,FLinearColor Value,bool ReturnValue) { return default; }
	public bool GetLinearColorAttribute(sbyte NodeAttributeKey,FLinearColor OutValue,bool ReturnValue) { return default; }
	public bool AddVector2Attribute(sbyte NodeAttributeKey,FVector2f Value,bool ReturnValue) { return default; }
	public bool GetVector2Attribute(sbyte NodeAttributeKey,FVector2f OutValue,bool ReturnValue) { return default; }
	public sbyte GetUniqueID(sbyte ReturnValue) { return default; }
	public sbyte GetDisplayLabel(sbyte ReturnValue) { return default; }
	public bool SetDisplayLabel(sbyte DisplayName,bool ReturnValue) { return default; }
	public sbyte GetParentUid(sbyte ReturnValue) { return default; }
	public bool SetParentUid(sbyte ParentUid,bool ReturnValue) { return default; }
	public int GetTargetNodeCount(int ReturnValue) { return default; }
	public void GetTargetNodeUids(TArray<sbyte> OutTargetAssets) {}
	public bool AddTargetNodeUid(sbyte AssetUid,bool ReturnValue) { return default; }
	public bool RemoveTargetNodeUid(sbyte AssetUid,bool ReturnValue) { return default; }
	public bool IsEnabled(bool ReturnValue) { return default; }
	public bool SetEnabled(bool bIsEnabled,bool ReturnValue) { return default; }
	public EInterchangeNodeContainerType GetNodeContainerType(EInterchangeNodeContainerType ReturnValue) { return default; }
	public sbyte GetAssetName(sbyte ReturnValue) { return default; }
	public bool SetAssetName(sbyte AssetName,bool ReturnValue) { return default; }
}
