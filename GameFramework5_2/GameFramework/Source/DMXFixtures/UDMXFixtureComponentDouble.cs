#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXFixtureComponentDouble.h")]
///<summary>Component that uses 2 DMX channels</summary>
public partial class UDMXFixtureComponentDouble : UDMXFixtureComponent {
// DMXFixtureComponentDouble
	public FDMXChannelData DMXChannel1;
	public FDMXChannelData DMXChannel2;
	public float GetDMXInterpolatedStep(int ChannelIndex,float ReturnValue) { return default; }
	public float GetDMXInterpolatedValue(int ChannelIndex,float ReturnValue) { return default; }
	public float GetDMXTargetValue(int ChannelIndex,float ReturnValue) { return default; }
	public bool IsDMXInterpolationDone(int ChannelIndex,bool ReturnValue) { return default; }
	public void SetChannel1ValueNoInterp(float Channel1Value) {}
	public void SetChannel2ValueNoInterp(float Channel2Value) {}
}
