#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IO/DMXInputPortConfig.h")]
///<summary>Blueprint Configuration of a Port, used in DXM Settings to specify inputs and outputs.</summary>
public partial struct FDMXInputPortConfig {
// DMXInputPortConfig
	public sbyte PortName;
	public sbyte ProtocolName;
	public EDMXCommunicationType CommunicationType;
	public bool bAutoCompleteDeviceAddressEnabled;
	public sbyte AutoCompleteDeviceAddress;
	public sbyte DeviceAddress;
	public int LocalUniverseStart;
	public int NumUniverses;
	public int ExternUniverseStart;
	public EDMXPortPriorityStrategy PriorityStrategy;
	public int Priority;
	public FGuid PortGuid;
}
