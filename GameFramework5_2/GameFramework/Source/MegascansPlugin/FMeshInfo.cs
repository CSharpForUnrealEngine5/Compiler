#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MSAssetImportData.h")]
public partial struct FMeshInfo {
// MeshInfo
	public sbyte meshID;
	public sbyte name;
	public sbyte path;
	public short numberOfLods;
	public TArray<FMaterialUsage> materialUsage;
}
