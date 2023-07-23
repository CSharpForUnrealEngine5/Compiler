#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/ManifestUObject.h")]
public partial class UBuildPatchManifest : UObject {
// BuildPatchManifest
	public byte ManifestFileVersion;
	public bool bIsFileData;
	public uint AppID;
	public sbyte AppName;
	public sbyte BuildVersion;
	public sbyte LaunchExe;
	public sbyte LaunchCommand;
	public TSet<sbyte> PrereqIds;
	public sbyte PrereqName;
	public sbyte PrereqPath;
	public sbyte PrereqArgs;
	public TArray<FFileManifestData> FileManifestList;
	public TArray<FChunkInfoData> ChunkList;
	public TArray<FCustomFieldData> CustomFields;
}
