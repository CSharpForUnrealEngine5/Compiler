#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/MultiUserServerColumnVisibilitySettings.h")]
public partial class UMultiUserServerColumnVisibilitySettings : UObject {
// MultiUserServerColumnVisibilitySettings
	public FColumnVisibilitySnapshot SessionBrowserColumnVisibility;
	public FColumnVisibilitySnapshot DeleteActivityDialogColumnVisibility;
	public FColumnVisibilitySnapshot ArchivedActivityBrowserColumnVisibility;
	public FColumnVisibilitySnapshot LiveActivityBrowserColumnVisibility;
	public FColumnVisibilitySnapshot LiveSessionContentColumnVisibility;
	public FColumnVisibilitySnapshot TransportLogColumnVisibility;
	public FColumnVisibilitySnapshot PackageTransmissionColumnVisibility;
}
