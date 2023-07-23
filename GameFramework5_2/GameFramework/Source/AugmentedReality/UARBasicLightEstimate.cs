#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARLightEstimate.h")]
public partial class UARBasicLightEstimate : UARLightEstimate {
// ARBasicLightEstimate
	public float GetAmbientIntensityLumens(float ReturnValue) { return default; }
	public float GetAmbientColorTemperatureKelvin(float ReturnValue) { return default; }
	public FLinearColor GetAmbientColor(FLinearColor ReturnValue) { return default; }
	public float AmbientIntensityLumens;
	public float AmbientColorTemperatureKelvin;
	public FLinearColor AmbientColor;
}
