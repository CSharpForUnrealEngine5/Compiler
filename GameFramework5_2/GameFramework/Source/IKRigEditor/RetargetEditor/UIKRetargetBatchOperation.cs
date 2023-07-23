#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RetargetEditor/IKRetargetBatchOperation.h")]
///<summary>/ Encapsulate ability to batch duplicate and retarget a set of animation assets</summary>
public partial class UIKRetargetBatchOperation : UObject {
// IKRetargetBatchOperation
	public TArray<FAssetData> DuplicateAndRetarget(TArray<FAssetData> AssetsToRetarget,UObject SourceMesh,UObject TargetMesh,UObject IKRetargetAsset,sbyte Search="",sbyte Replace="",sbyte Prefix="",sbyte Suffix="",bool bRemapReferencedAssets=true,TArray<FAssetData> ReturnValue) { return default; }
}
