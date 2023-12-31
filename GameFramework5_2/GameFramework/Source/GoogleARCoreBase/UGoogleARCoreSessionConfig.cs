#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreSessionConfig.h")]
///<summary>A UDataAsset that can be used to configure ARCore specific settings on top of</summary>
public partial class UGoogleARCoreSessionConfig : UARSessionConfig {
// GoogleARCoreSessionConfig
	public UObject GetAugmentedImageDatabase() { return default; }
	public void SetAugmentedImageDatabase(UObject NewImageDatabase) {}
	public UGoogleARCoreAugmentedImageDatabase AugmentedImageDatabase;
	public EGoogleARCoreCameraFacing CameraFacing;
	public EGoogleARCoreAugmentedFaceMode AugmentedFaceMode;
}
