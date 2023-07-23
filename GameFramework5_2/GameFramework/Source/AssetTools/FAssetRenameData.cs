#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IAssetTools.h")]
public partial struct FAssetRenameData {
// AssetRenameData
	public TWeakObjectPtr<UObject> Asset;
	public sbyte NewPackagePath;
	public sbyte NewName;
	public FSoftObjectPath OldObjectPath;
	public FSoftObjectPath NewObjectPath;
	public bool bOnlyFixSoftReferences;
}
