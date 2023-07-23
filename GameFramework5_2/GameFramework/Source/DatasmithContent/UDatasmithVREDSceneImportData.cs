#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithAssetImportData.h")]
public partial class UDatasmithVREDSceneImportData : UDatasmithFBXSceneImportData {
// DatasmithVREDSceneImportData
	public bool bMergeNodes;
	public bool bOptimizeDuplicatedNodes;
	public bool bImportMats;
	public sbyte MatsPath;
	public bool bImportVar;
	public bool bCleanVar;
	public sbyte VarPath;
	public bool bImportLightInfo;
	public sbyte LightInfoPath;
	public bool bImportClipInfo;
	public sbyte ClipInfoPath;
}
