#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeAnimationTrackSetNode.h")]
///<summary>Class to represent a set of animation track nodes sharing the same frame rate</summary>
public partial class UInterchangeAnimationTrackSetNode : UInterchangeBaseNode {
// InterchangeAnimationTrackSetNode
	public int GetCustomAnimationTrackUidCount(int ReturnValue) { return default; }
	public void GetCustomAnimationTrackUids(TArray<sbyte> OutAnimationTrackUids) {}
	public void GetCustomAnimationTrackUid(int Index,sbyte OutAnimationTrackUid) {}
	public bool AddCustomAnimationTrackUid(sbyte AnimationTrackUid,bool ReturnValue) { return default; }
	public bool RemoveCustomAnimationTrackUid(sbyte AnimationTrackUid,bool ReturnValue) { return default; }
	public bool SetCustomFrameRate(float AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomFrameRate(float AttributeValue,bool ReturnValue) { return default; }
}
