#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeAnimationTrackSetFactoryNode.h")]
public partial class UInterchangeAnimationTrackSetFactoryNode : UInterchangeFactoryBaseNode {
// InterchangeAnimationTrackSetFactoryNode
	public UClass GetObjectClass(UClass ReturnValue) { return default; }
	public int GetCustomAnimationTrackUidCount(int ReturnValue) { return default; }
	public void GetCustomAnimationTrackUids(TArray<sbyte> OutAnimationTrackUids) {}
	public void GetCustomAnimationTrackUid(int Index,sbyte OutAnimationTrackUid) {}
	public bool AddCustomAnimationTrackUid(sbyte AnimationTrackUid,bool ReturnValue) { return default; }
	public bool RemoveCustomAnimationTrackUid(sbyte AnimationTrackUid,bool ReturnValue) { return default; }
	public bool SetCustomFrameRate(float AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomFrameRate(float AttributeValue,bool ReturnValue) { return default; }
}
