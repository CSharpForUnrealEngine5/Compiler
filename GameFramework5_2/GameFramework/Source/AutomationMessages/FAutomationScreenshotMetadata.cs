#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationWorkerMessages.h")]
public partial struct FAutomationScreenshotMetadata {
// AutomationScreenshotMetadata
	public sbyte ScreenShotName;
	public sbyte Context;
	public sbyte TestName;
	public sbyte Notes;
	public FGuid Id;
	public sbyte Commit;
	public int Width;
	public int Height;
	public sbyte Rhi;
	public sbyte Platform;
	public sbyte FeatureLevel;
	public bool bIsStereo;
	public sbyte Vendor;
	public sbyte AdapterName;
	public sbyte AdapterInternalDriverVersion;
	public sbyte AdapterUserDriverVersion;
	public sbyte UniqueDeviceId;
	public float ResolutionQuality;
	public int ViewDistanceQuality;
	public int AntiAliasingQuality;
	public int ShadowQuality;
	public int GlobalIlluminationQuality;
	public int ReflectionQuality;
	public int PostProcessQuality;
	public int TextureQuality;
	public int EffectsQuality;
	public int FoliageQuality;
	public int ShadingQuality;
	public bool bHasComparisonRules;
	public byte ToleranceRed;
	public byte ToleranceGreen;
	public byte ToleranceBlue;
	public byte ToleranceAlpha;
	public byte ToleranceMinBrightness;
	public byte ToleranceMaxBrightness;
	public float MaximumLocalError;
	public float MaximumGlobalError;
	public bool bIgnoreAntiAliasing;
	public bool bIgnoreColors;
}
