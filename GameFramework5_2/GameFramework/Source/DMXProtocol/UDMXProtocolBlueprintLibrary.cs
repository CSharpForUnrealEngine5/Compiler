#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXProtocolBlueprintLibrary.h")]
public partial class UDMXProtocolBlueprintLibrary : UBlueprintFunctionLibrary {
// DMXProtocolBlueprintLibrary
	public void SetSendDMXEnabled(bool bSendDMXEnabled=true,bool bAffectEditor=false) {}
	public bool IsSendDMXEnabled(bool ReturnValue) { return default; }
	public void SetReceiveDMXEnabled(bool bReceiveDMXEnabled=true,bool bAffectEditor=false) {}
	public bool IsReceiveDMXEnabled(bool ReturnValue) { return default; }
	public TArray<sbyte> GetLocalDMXNetworkInterfaceCardIPs(TArray<sbyte> ReturnValue) { return default; }
	public void SetDMXInputPortDeviceAddress(FDMXInputPortReference InputPort,sbyte DeviceAddress) {}
	public void SetDMXOutputPortDeviceAddress(FDMXOutputPortReference OutputPort,sbyte DeviceAddress) {}
	public void SetDMXOutputPortDestinationAddresses(FDMXOutputPortReference OutputPort,TArray<sbyte> DestinationAddresses) {}
	public void SetDMXOutputPortDestinationAddress(FDMXOutputPortReference OutputPort,sbyte DestinationAddress) {}
}
