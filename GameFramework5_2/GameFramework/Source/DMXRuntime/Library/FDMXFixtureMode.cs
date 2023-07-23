#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXEntityFixtureType.h")]
public partial struct FDMXFixtureMode {
// DMXFixtureMode
	public sbyte ModeName;
	public TArray<FDMXFixtureFunction> Functions;
	public bool bAutoChannelSpan;
	public int ChannelSpan;
	public bool bFixtureMatrixEnabled;
	public FDMXFixtureMatrix FixtureMatrixConfig;
}
