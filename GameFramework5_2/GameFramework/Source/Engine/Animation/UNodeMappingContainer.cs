#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/NodeMappingContainer.h")]
///<summary>Node Mapping Container Class</summary>
public partial class UNodeMappingContainer : UObject {
// NodeMappingContainer
	public TMap<sbyte,FNodeItem> SourceItems;
	public TMap<sbyte,FNodeItem> TargetItems;
	public TMap<sbyte,sbyte> SourceToTarget;
	public TSoftObjectPtr<UObject> SourceAsset;
	public TSoftObjectPtr<UObject> TargetAsset;
}
