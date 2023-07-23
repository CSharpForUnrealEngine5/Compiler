#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithImportOptions.h")]
public partial class UDatasmithImportOptions : UDatasmithOptionsBase {
// DatasmithImportOptions
	public EDatasmithImportSearchPackagePolicy SearchPackagePolicy;
	public EDatasmithImportAssetConflictPolicy MaterialConflictPolicy;
	public EDatasmithImportAssetConflictPolicy TextureConflictPolicy;
	public EDatasmithImportActorPolicy StaticMeshActorImportPolicy;
	public EDatasmithImportActorPolicy LightImportPolicy;
	public EDatasmithImportActorPolicy CameraImportPolicy;
	public EDatasmithImportActorPolicy OtherActorImportPolicy;
	public EDatasmithImportMaterialQuality MaterialQuality;
	public FDatasmithImportBaseOptions BaseOptions;
	public FDatasmithReimportOptions ReimportOptions;
	public sbyte FileName;
	public sbyte FilePath;
	public sbyte SourceUri;
}
