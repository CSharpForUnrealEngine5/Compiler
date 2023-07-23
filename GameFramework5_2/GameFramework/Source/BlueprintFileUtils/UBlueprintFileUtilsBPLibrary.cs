#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintFileUtilsBPLibrary.h")]
public partial class UBlueprintFileUtilsBPLibrary : UBlueprintFunctionLibrary {
// BlueprintFileUtilsBPLibrary
	public bool FindFiles(sbyte Directory,TArray<sbyte> FoundFiles,sbyte FileExtension=TEXT,bool ReturnValue) { return default; }
	public bool FindRecursive(sbyte StartDirectory,TArray<sbyte> FoundPaths,sbyte Wildcard=TEXT,bool bFindFiles=true,bool bFindDirectories=false,bool ReturnValue) { return default; }
	public bool FileExists(sbyte Filename,bool ReturnValue) { return default; }
	public bool DirectoryExists(sbyte Directory,bool ReturnValue) { return default; }
	public bool MakeDirectory(sbyte Path,bool bCreateTree=false,bool ReturnValue) { return default; }
	public bool DeleteDirectory(sbyte Directory,bool bMustExist=false,bool bDeleteRecursively=false,bool ReturnValue) { return default; }
	public bool DeleteFile(sbyte Filename,bool bMustExist=false,bool bEvenIfReadOnly=false,bool ReturnValue) { return default; }
	public bool CopyFile(sbyte DestFilename,sbyte SrcFilename,bool bReplace=true,bool bEvenIfReadOnly=false,bool ReturnValue) { return default; }
	public bool MoveFile(sbyte DestFilename,sbyte SrcFilename,bool bReplace=true,bool bEvenIfReadOnly=false,bool ReturnValue) { return default; }
	public sbyte GetUserDirectory(sbyte ReturnValue) { return default; }
}
