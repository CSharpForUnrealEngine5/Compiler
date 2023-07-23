#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OSCManager.h")]
public partial class UOSCManager : UBlueprintFunctionLibrary {
// OSCManager
	public UObject CreateOSCServer(sbyte ReceiveIPAddress,int Port,bool bMulticastLoopback,bool bStartListening,sbyte ServerName,UObject Outer=nullptr,UObject ReturnValue) { return default; }
	public UObject CreateOSCClient(sbyte SendIPAddress,int Port,sbyte ClientName,UObject Outer=nullptr,UObject ReturnValue) { return default; }
	public FOSCBundle AddMessageToBundle(FOSCMessage Message,FOSCBundle Bundle,FOSCBundle ReturnValue) { return default; }
	public FOSCBundle AddBundleToBundle(FOSCBundle InBundle,FOSCBundle OutBundle,FOSCBundle ReturnValue) { return default; }
	public TArray<FOSCBundle> GetBundlesFromBundle(FOSCBundle Bundle,TArray<FOSCBundle> ReturnValue) { return default; }
	public FOSCMessage GetMessageFromBundle(FOSCBundle Bundle,int Index,bool bSucceeded,FOSCMessage ReturnValue) { return default; }
	public TArray<FOSCMessage> GetMessagesFromBundle(FOSCBundle Bundle,TArray<FOSCMessage> ReturnValue) { return default; }
	public FOSCMessage ClearMessage(FOSCMessage Message,FOSCMessage ReturnValue) { return default; }
	public FOSCBundle ClearBundle(FOSCBundle Bundle,FOSCBundle ReturnValue) { return default; }
	public FOSCMessage AddFloat(FOSCMessage Message,float Value,FOSCMessage ReturnValue) { return default; }
	public FOSCMessage AddInt32(FOSCMessage Message,int Value,FOSCMessage ReturnValue) { return default; }
	public FOSCMessage AddInt64(FOSCMessage Message,long Value,FOSCMessage ReturnValue) { return default; }
	public FOSCMessage AddAddress(FOSCMessage Message,FOSCAddress Value,FOSCMessage ReturnValue) { return default; }
	public FOSCMessage AddString(FOSCMessage Message,sbyte Value,FOSCMessage ReturnValue) { return default; }
	public FOSCMessage AddBlob(FOSCMessage Message,TArray<byte> Value,FOSCMessage ReturnValue) { return default; }
	public FOSCMessage AddBool(FOSCMessage Message,bool Value,FOSCMessage ReturnValue) { return default; }
	public bool GetAddress(FOSCMessage Message,int Index,FOSCAddress Value,bool ReturnValue) { return default; }
	public void GetAllAddresses(FOSCMessage Message,TArray<FOSCAddress> Values) {}
	public bool GetFloat(FOSCMessage Message,int Index,float Value,bool ReturnValue) { return default; }
	public void GetAllFloats(FOSCMessage Message,TArray<float> Values) {}
	public bool GetInt32(FOSCMessage Message,int Index,int Value,bool ReturnValue) { return default; }
	public void GetAllInt32s(FOSCMessage Message,TArray<int> Values) {}
	public bool GetInt64(FOSCMessage Message,int Index,long Value,bool ReturnValue) { return default; }
	public void GetAllInt64s(FOSCMessage Message,TArray<long> Values) {}
	public bool GetString(FOSCMessage Message,int Index,sbyte Value,bool ReturnValue) { return default; }
	public void GetAllStrings(FOSCMessage Message,TArray<sbyte> Values) {}
	public bool GetBool(FOSCMessage Message,int Index,bool Value,bool ReturnValue) { return default; }
	public void GetAllBools(FOSCMessage Message,TArray<bool> Values) {}
	public bool GetBlob(FOSCMessage Message,int Index,TArray<byte> Value,bool ReturnValue) { return default; }
	public bool OSCAddressIsValidPath(FOSCAddress Address,bool ReturnValue) { return default; }
	public bool OSCAddressIsValidPattern(FOSCAddress Address,bool ReturnValue) { return default; }
	public FOSCAddress ConvertStringToOSCAddress(sbyte String,FOSCAddress ReturnValue) { return default; }
	public bool OSCAddressPathMatchesPattern(FOSCAddress Pattern,FOSCAddress Path,bool ReturnValue) { return default; }
	public UObject FindObjectAtOSCAddress(FOSCAddress Address,UObject ReturnValue) { return default; }
	public FOSCAddress OSCAddressFromObjectPath(UObject Object,FOSCAddress ReturnValue) { return default; }
	public FOSCAddress OSCAddressFromObjectPathString(sbyte PathName,FOSCAddress ReturnValue) { return default; }
	public sbyte ObjectPathFromOSCAddress(FOSCAddress Address,sbyte ReturnValue) { return default; }
	public FOSCAddress OSCAddressPushContainer(FOSCAddress Address,sbyte Container,FOSCAddress ReturnValue) { return default; }
	public FOSCAddress OSCAddressPushContainers(FOSCAddress Address,TArray<sbyte> Containers,FOSCAddress ReturnValue) { return default; }
	public sbyte OSCAddressPopContainer(FOSCAddress Address,sbyte ReturnValue) { return default; }
	public TArray<sbyte> OSCAddressPopContainers(FOSCAddress Address,int NumContainers,TArray<sbyte> ReturnValue) { return default; }
	public FOSCAddress OSCAddressRemoveContainers(FOSCAddress Address,int Index,int Count,FOSCAddress ReturnValue) { return default; }
	public FOSCAddress GetOSCMessageAddress(FOSCMessage Message,FOSCAddress ReturnValue) { return default; }
	public FOSCMessage SetOSCMessageAddress(FOSCMessage Message,FOSCAddress Address,FOSCMessage ReturnValue) { return default; }
	public sbyte GetOSCAddressContainer(FOSCAddress Address,int Index,sbyte ReturnValue) { return default; }
	public TArray<sbyte> GetOSCAddressContainers(FOSCAddress Address,TArray<sbyte> ReturnValue) { return default; }
	public sbyte GetOSCAddressContainerPath(FOSCAddress Address,sbyte ReturnValue) { return default; }
	public sbyte GetOSCAddressFullPath(FOSCAddress Address,sbyte ReturnValue) { return default; }
	public sbyte GetOSCAddressMethod(FOSCAddress Address,sbyte ReturnValue) { return default; }
	public FOSCAddress ClearOSCAddressContainers(FOSCAddress Address,FOSCAddress ReturnValue) { return default; }
	public FOSCAddress SetOSCAddressMethod(FOSCAddress Address,sbyte Method,FOSCAddress ReturnValue) { return default; }
}
