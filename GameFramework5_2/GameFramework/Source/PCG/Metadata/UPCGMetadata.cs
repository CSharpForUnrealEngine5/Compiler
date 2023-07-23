#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Metadata/PCGMetadata.h")]
public partial class UPCGMetadata : UObject {
// PCGMetadata
	public void Initialize(UObject InParent) {}
	public void InitializeWithAttributeFilter(UObject InParent,TSet<sbyte> InFilteredAttributes,EPCGMetadataFilterMode InFilterMode=EPCGMetadataFilterMode) {}
	public void InitializeAsCopy(UObject InMetadataToCopy) {}
	public void InitializeAsCopyWithAttributeFilter(UObject InMetadataToCopy,TSet<sbyte> InFilteredAttributes,EPCGMetadataFilterMode InFilterMode=EPCGMetadataFilterMode) {}
	public void AddAttributes(UObject InOther) {}
	public void AddAttributesFiltered(UObject InOther,TSet<sbyte> InFilteredAttributes,EPCGMetadataFilterMode InFilterMode=EPCGMetadataFilterMode) {}
	public void AddAttribute(UObject InOther,sbyte AttributeName) {}
	public void CopyAttributes(UObject InOther) {}
	public void CopyAttribute(UObject InOther,sbyte AttributeToCopy,sbyte NewAttributeName) {}
	public void CreateInteger32Attribute(sbyte AttributeName,int DefaultValue,bool bAllowsInterpolation,bool bOverrideParent=true) {}
	public void CreateInteger64Attribute(sbyte AttributeName,long DefaultValue,bool bAllowsInterpolation,bool bOverrideParent=true) {}
	public void CreateFloatAttribute(sbyte AttributeName,float DefaultValue,bool bAllowsInterpolation,bool bOverrideParent=true) {}
	public void CreateDoubleAttribute(sbyte AttributeName,double DefaultValue,bool bAllowsInterpolation,bool bOverrideParent=true) {}
	public void CreateVectorAttribute(sbyte AttributeName,FVector DefaultValue,bool bAllowsInterpolation,bool bOverrideParent=true) {}
	public void CreateVector4Attribute(sbyte AttributeName,FVector4 DefaultValue,bool bAllowsInterpolation,bool bOverrideParent=true) {}
	public void CreateVector2Attribute(sbyte AttributeName,FVector2D DefaultValue,bool bAllowsInterpolation,bool bOverrideParent=true) {}
	public void CreateRotatorAttribute(sbyte AttributeName,FRotator DefaultValue,bool bAllowsInterpolation,bool bOverrideParent=true) {}
	public void CreateQuatAttribute(sbyte AttributeName,FQuat DefaultValue,bool bAllowsInterpolation,bool bOverrideParent=true) {}
	public void CreateTransformAttribute(sbyte AttributeName,FTransform DefaultValue,bool bAllowsInterpolation,bool bOverrideParent=true) {}
	public void CreateStringAttribute(sbyte AttributeName,sbyte DefaultValue,bool bAllowsInterpolation,bool bOverrideParent=true) {}
	public void CreateBoolAttribute(sbyte AttributeName,bool DefaultValue,bool bAllowsInterpolation,bool bOverrideParent=true) {}
	public bool HasAttribute(sbyte AttributeName,bool ReturnValue) { return default; }
	public bool HasCommonAttributes(UObject InMetadata,bool ReturnValue) { return default; }
	public void GetAttributes(TArray<sbyte> AttributeNames,TArray<EPCGMetadataTypes> AttributeTypes) {}
	public void DeleteAttribute(sbyte AttributeName) {}
	public bool CopyExistingAttribute(sbyte AttributeToCopy,sbyte NewAttributeName,bool bKeepParent=true,bool ReturnValue) { return default; }
	public bool RenameAttribute(sbyte AttributeToRename,sbyte NewAttributeName,bool ReturnValue) { return default; }
	public void ClearAttribute(sbyte AttributeToClear) {}
	public long AddEntry(long ParentEntryKey=-1,long ReturnValue) { return default; }
	public void MergeAttributesByKey(long KeyA,UObject MetadataA,long KeyB,UObject MetadataB,long TargetKey,EPCGMetadataOp Op,long OutKey) {}
	public void ResetWeightedAttributesByKey(long TargetKey,long OutKey) {}
	public void AccumulateWeightedAttributesByKey(long Key,UObject Metadata,float Weight,bool bSetNonInterpolableAttributes,long TargetKey,long OutKey) {}
	public void SetAttributesByKey(long Key,UObject InMetadata,long TargetKey,long OutKey) {}
	public void MergePointAttributes(FPCGPoint PointA,UObject MetadataA,FPCGPoint PointB,UObject MetadataB,FPCGPoint TargetPoint,EPCGMetadataOp Op) {}
	public void SetPointAttributes(FPCGPoint Point,UObject Metadata,FPCGPoint OutPoint) {}
	public void ResetPointWeightedAttributes(FPCGPoint OutPoint) {}
	public void AccumulatePointWeightedAttributes(FPCGPoint InPoint,UObject InMetadata,float Weight,bool bSetNonInterpolableAttributes,FPCGPoint OutPoint) {}
	public UPCGMetadata Parent;
	public TSet<TWeakObjectPtr<UPCGMetadata>> OtherParents;
}
