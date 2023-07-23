#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/ManifestUObject.h")]
public partial struct FFileManifestData {
// FileManifestData
	public sbyte Filename;
	public FSHAHashData FileHash;
	public TArray<FChunkPartData> FileChunkParts;
	public TArray<sbyte> InstallTags;
	public bool bIsUnixExecutable;
	public sbyte SymlinkTarget;
	public bool bIsReadOnly;
	public bool bIsCompressed;
}
