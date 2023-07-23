#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXImportGDTF.h")]
public partial struct FDMXImportGDTFDMXMode {
// DMXImportGDTFDMXMode
	public sbyte Name;
	public sbyte Geometry;
	public TArray<FDMXImportGDTFDMXChannel> DMXChannels;
	public TArray<FDMXImportGDTFRelation> Relations;
	public TArray<FDMXImportGDTFFTMacro> FTMacros;
}
