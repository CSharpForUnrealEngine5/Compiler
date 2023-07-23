#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTypes.h")]
///<summary>An asset that points to an image to be detected in a scene and provides the size of the object in real life</summary>
public partial class UARCandidateImage : UDataAsset {
// ARCandidateImage
	public UObject GetCandidateTexture(UObject ReturnValue) { return default; }
	public sbyte GetFriendlyName(sbyte ReturnValue) { return default; }
	public float GetPhysicalWidth(float ReturnValue) { return default; }
	public float GetPhysicalHeight(float ReturnValue) { return default; }
	public EARCandidateImageOrientation GetOrientation(EARCandidateImageOrientation ReturnValue) { return default; }
	public UTexture2D CandidateTexture;
	public sbyte FriendlyName;
	public float Width;
	public float Height;
	public EARCandidateImageOrientation Orientation;
}
