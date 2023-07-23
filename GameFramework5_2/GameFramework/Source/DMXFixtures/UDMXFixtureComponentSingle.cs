#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXFixtureComponentSingle.h")]
///<summary>Component that uses 1 DMX channel</summary>
public partial class UDMXFixtureComponentSingle : UDMXFixtureComponent {
// DMXFixtureComponentSingle
	public FDMXChannelData DMXChannel;
	public float GetDMXInterpolatedStep(float ReturnValue) { return default; }
	public float GetDMXInterpolatedValue(float ReturnValue) { return default; }
	public float GetDMXTargetValue(float ReturnValue) { return default; }
	public bool IsDMXInterpolationDone(bool ReturnValue) { return default; }
	public void SetValueNoInterp(float NewValue) {}
}
