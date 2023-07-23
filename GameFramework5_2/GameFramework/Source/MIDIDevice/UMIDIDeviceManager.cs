#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MIDIDeviceManager.h")]
public partial class UMIDIDeviceManager : UBlueprintFunctionLibrary {
// MIDIDeviceManager
	public void FindMIDIDevices(TArray<FFoundMIDIDevice> OutMIDIDevices) {}
	public void FindAllMIDIDeviceInfo(TArray<FMIDIDeviceInfo> OutMIDIInputDevices,TArray<FMIDIDeviceInfo> OutMIDIOutputDevices) {}
	public void GetMIDIInputDeviceIDByName(sbyte DeviceName,int DeviceID) {}
	public void GetDefaultMIDIInputDeviceID(int DeviceID) {}
	public void GetMIDIOutputDeviceIDByName(sbyte DeviceName,int DeviceID) {}
	public void GetDefaultMIDIOutputDeviceID(int DeviceID) {}
	public UObject CreateMIDIDeviceController(int DeviceID,int MIDIBufferSize=1024,UObject ReturnValue) { return default; }
	public UObject CreateMIDIDeviceInputController(int DeviceID,int MIDIBufferSize=1024,UObject ReturnValue) { return default; }
	public UObject CreateMIDIDeviceOutputController(int DeviceID,UObject ReturnValue) { return default; }
}
