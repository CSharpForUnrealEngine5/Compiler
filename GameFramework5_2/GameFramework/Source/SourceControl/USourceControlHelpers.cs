#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceControlHelpers.h")]
///<summary>Editor source control common functionality.</summary>
public partial class USourceControlHelpers : UObject {
// SourceControlHelpers
	public sbyte CurrentProvider(sbyte ReturnValue) { return default; }
	public bool IsEnabled(bool ReturnValue) { return default; }
	public bool IsAvailable(bool ReturnValue) { return default; }
	public sbyte LastErrorMsg(sbyte ReturnValue) { return default; }
	public bool SyncFile(sbyte InFile,bool bSilent=false,bool ReturnValue) { return default; }
	public bool SyncFiles(TArray<sbyte> InFiles,bool bSilent=false,bool ReturnValue) { return default; }
	public bool CheckOutFile(sbyte InFile,bool bSilent=false,bool ReturnValue) { return default; }
	public bool CheckOutFiles(TArray<sbyte> InFiles,bool bSilent=false,bool ReturnValue) { return default; }
	public bool CheckOutOrAddFile(sbyte InFile,bool bSilent=false,bool ReturnValue) { return default; }
	public bool CheckOutOrAddFiles(TArray<sbyte> InFiles,bool bSilent=false,bool ReturnValue) { return default; }
	public bool MarkFileForAdd(sbyte InFile,bool bSilent=false,bool ReturnValue) { return default; }
	public bool MarkFilesForAdd(TArray<sbyte> InFiles,bool bSilent=false,bool ReturnValue) { return default; }
	public bool MarkFileForDelete(sbyte InFile,bool bSilent=false,bool ReturnValue) { return default; }
	public bool MarkFilesForDelete(TArray<sbyte> InFiles,bool bSilent=false,bool ReturnValue) { return default; }
	public bool RevertFile(sbyte InFile,bool bSilent=false,bool ReturnValue) { return default; }
	public bool RevertAndReloadPackages(TArray<sbyte> InPackagesToRevert,bool bRevertAll=false,bool bReloadWorld=false,bool ReturnValue) { return default; }
	public bool RevertFiles(TArray<sbyte> InFiles,bool bSilent=false,bool ReturnValue) { return default; }
	public bool RevertUnchangedFile(sbyte InFile,bool bSilent=false,bool ReturnValue) { return default; }
	public bool RevertUnchangedFiles(TArray<sbyte> InFiles,bool bSilent=false,bool ReturnValue) { return default; }
	public bool CheckInFile(sbyte InFile,sbyte InDescription,bool bSilent=false,bool bKeepCheckedOut=false,bool ReturnValue) { return default; }
	public bool CheckInFiles(TArray<sbyte> InFiles,sbyte InDescription,bool bSilent=false,bool bKeepCheckedOut=false,bool ReturnValue) { return default; }
	public bool CopyFile(sbyte InSourceFile,sbyte InDestFile,bool bSilent=false,bool ReturnValue) { return default; }
	public FSourceControlState QueryFileState(sbyte InFile,bool bSilent=false,FSourceControlState ReturnValue) { return default; }
	public void FQueryFileStateDelegate(FSourceControlState FileStateOut) {}
	public void AsyncQueryFileState(FQueryFileStateDelegate FileStateCallback,sbyte InFile,bool bSilent=false) {}
}
