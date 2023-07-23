#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkRemapAsset.h")]
///<summary>Remap asset for data coming from Live Link. Allows simple application of bone transforms into current pose based on name remapping only</summary>
public partial class ULiveLinkRemapAsset : ULiveLinkRetargetAsset {
// LiveLinkRemapAsset
	public sbyte GetRemappedBoneName(sbyte BoneName,sbyte ReturnValue) { return default; }
	public sbyte GetRemappedCurveName(sbyte CurveName,sbyte ReturnValue) { return default; }
	public void RemapCurveElements(TMap<sbyte,float> CurveItems) {}
}
