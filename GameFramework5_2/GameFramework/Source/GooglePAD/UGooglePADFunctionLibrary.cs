#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GooglePADFunctionLibrary.h")]
public partial class UGooglePADFunctionLibrary : UBlueprintFunctionLibrary {
// GooglePADFunctionLibrary
	public EGooglePADErrorCode RequestInfo(TArray<sbyte> AssetPacks,EGooglePADErrorCode ReturnValue) { return default; }
	public EGooglePADErrorCode RequestDownload(TArray<sbyte> AssetPacks,EGooglePADErrorCode ReturnValue) { return default; }
	public EGooglePADErrorCode CancelDownload(TArray<sbyte> AssetPacks,EGooglePADErrorCode ReturnValue) { return default; }
	public EGooglePADErrorCode GetDownloadState(sbyte Name,int State,EGooglePADErrorCode ReturnValue) { return default; }
	public void ReleaseDownloadState(int State) {}
	public EGooglePADDownloadStatus GetDownloadStatus(int State,EGooglePADDownloadStatus ReturnValue) { return default; }
	public int GetBytesDownloaded(int State,int ReturnValue) { return default; }
	public int GetTotalBytesToDownload(int State,int ReturnValue) { return default; }
	public EGooglePADErrorCode RequestRemoval(sbyte Name,EGooglePADErrorCode ReturnValue) { return default; }
	public EGooglePADErrorCode ShowCellularDataConfirmation(EGooglePADErrorCode ReturnValue) { return default; }
	public EGooglePADErrorCode GetShowCellularDataConfirmationStatus(EGooglePADCellularDataConfirmStatus Status,EGooglePADErrorCode ReturnValue) { return default; }
	public EGooglePADErrorCode GetAssetPackLocation(sbyte Name,int Location,EGooglePADErrorCode ReturnValue) { return default; }
	public void ReleaseAssetPackLocation(int Location) {}
	public EGooglePADStorageMethod GetStorageMethod(int Location,EGooglePADStorageMethod ReturnValue) { return default; }
	public sbyte GetAssetsPath(int Location,sbyte ReturnValue) { return default; }
}
