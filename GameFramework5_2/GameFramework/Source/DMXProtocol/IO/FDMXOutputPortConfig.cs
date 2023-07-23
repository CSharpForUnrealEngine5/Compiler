#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IO/DMXOutputPortConfig.h")]
///<summary>Blueprint Configuration of a Port, used in DXM Settings to specify inputs and outputs.</summary>
public partial struct FDMXOutputPortConfig {
// DMXOutputPortConfig
	public sbyte PortName;
	public sbyte ProtocolName;
	public EDMXCommunicationType CommunicationType;
	public bool bAutoCompleteDeviceAddressEnabled;
	public sbyte AutoCompleteDeviceAddress;
	public sbyte DeviceAddress;
	public sbyte DestinationAddress;
	public TArray<FDMXOutputPortDestinationAddress> DestinationAddresses;
	public bool bLoopbackToEngine;
	public int LocalUniverseStart;
	public int NumUniverses;
	public int ExternUniverseStart;
	public int Priority;
	public double Delay;
	public FFrameRate DelayFrameRate;
	public FGuid PortGuid;
}
