#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IAssetTools.h")]
public partial struct FAssetRenameData {
// AssetRenameData
	public TWeakObjectPtr<UObject> Asset;
	public string NewPackagePath;
	public string NewName;
	public FSoftObjectPath OldObjectPath;
	public FSoftObjectPath NewObjectPath;
	public bool bOnlyFixSoftReferences;
}
