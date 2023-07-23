#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXImportGDTF.h")]
public partial struct FDMXImportGDTFChannelFunction {
// DMXImportGDTFChannelFunction
	public sbyte Name;
	public FDMXImportGDTFAttribute Attribute;
	public sbyte OriginalAttribute;
	public FDMXImportGDTFDMXValue DMXFrom;
	public FDMXImportGDTFDMXValue DMXValue;
	public float PhysicalFrom;
	public float PhysicalTo;
	public float RealFade;
	public FDMXImportGDTFWheel Wheel;
	public FDMXImportGDTFEmitter Emitter;
	public FDMXImportGDTFFilter Filter;
	public EDMXImportGDTFDMXInvert DMXInvert;
	public sbyte ModeMaster;
	public FDMXImportGDTFDMXValue ModeFrom;
	public FDMXImportGDTFDMXValue ModeTo;
	public TArray<FDMXImportGDTFChannelSet> ChannelSets;
}
