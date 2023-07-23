#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimEditorTypes.h")]
///<summary>Object used to construct the New IK Target Widget</summary>
public partial class UContextualAnimNewIKTargetParams : UObject {
// ContextualAnimNewIKTargetParams
	public sbyte SourceRole;
	public FBoneReference SourceBone;
	public EContextualAnimIKTargetProvider Provider;
	public sbyte TargetRole;
	public FBoneReference TargetBone;
	public sbyte GoalName;
	public int SectionIdx;
	public TArray<sbyte> GetTargetRoleOptions(TArray<sbyte> ReturnValue) { return default; }
	public TWeakObjectPtr<UContextualAnimSceneAsset> SceneAssetPtr;
	public TArray<sbyte> CachedRoles;
}
