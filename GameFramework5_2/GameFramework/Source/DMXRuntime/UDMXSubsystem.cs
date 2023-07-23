#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXSubsystem.h")]
///<summary>UDMXSubsystem</summary>
public partial class UDMXSubsystem : UEngineSubsystem {
// DMXSubsystem
	public void SendDMX(UObject FixturePatch,TMap<FDMXAttributeName,int> AttributeMap,EDMXSendResult OutResult) {}
	public void SendDMXRaw(FDMXProtocolName SelectedProtocol,int RemoteUniverse,TMap<int,byte> AddressValueMap,EDMXSendResult OutResult) {}
	public void SendDMXToOutputPort(FDMXOutputPortReference OutputPortReference,TMap<int,byte> ChannelToValueMap,int LocalUniverse=1) {}
	public void GetRawBuffer(FDMXProtocolName SelectedProtocol,int RemoteUniverse,TArray<byte> DMXBuffer) {}
	public void GetDMXDataFromInputPort(FDMXInputPortReference InputPortReference,TArray<byte> DMXData,int LocalUniverse=1) {}
	public void GetDMXDataFromOutputPort(FDMXOutputPortReference OutputPortReference,TArray<byte> DMXData,int LocalUniverse=1) {}
	public void GetAllFixturesOfType(FDMXEntityFixtureTypeRef FixtureType,TArray<UObject> OutResult) {}
	public void GetAllFixturesOfCategory(UObject DMXLibrary,FDMXFixtureCategory Category,TArray<UObject> OutResult) {}
	public void GetAllFixturesInUniverse(UObject DMXLibrary,int UniverseId,TArray<UObject> OutResult) {}
	public void GetFixtureAttributes(UObject InFixturePatch,TArray<byte> DMXBuffer,TMap<FDMXAttributeName,int> OutResult) {}
	public TArray<UObject> GetAllFixturesWithTag(UObject DMXLibrary,sbyte CustomTag,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetAllFixturesInLibrary(UObject DMXLibrary,TArray<UObject> ReturnValue) { return default; }
	public UObject GetFixtureByName(UObject DMXLibrary,sbyte Name,UObject ReturnValue) { return default; }
	public TArray<UObject> GetAllFixtureTypesInLibrary(UObject DMXLibrary,TArray<UObject> ReturnValue) { return default; }
	public UObject GetFixtureTypeByName(UObject DMXLibrary,sbyte Name,UObject ReturnValue) { return default; }
	public void GetAllUniversesInController(UObject DMXLibrary,sbyte ControllerName,TArray<int> OutResult) {}
	public TArray<UObject> GetAllControllersInLibrary(UObject DMXLibrary,TArray<UObject> ReturnValue) { return default; }
	public UObject GetControllerByName(UObject DMXLibrary,sbyte Name,UObject ReturnValue) { return default; }
	public TArray<UObject> GetAllDMXLibraries(TArray<UObject> ReturnValue) { return default; }
	public int BytesToInt(TArray<byte> Bytes,bool bUseLSB=false,int ReturnValue) { return default; }
	public float BytesToNormalizedValue(TArray<byte> Bytes,bool bUseLSB=false,float ReturnValue) { return default; }
	public void NormalizedValueToBytes(float InValue,EDMXFixtureSignalFormat InSignalFormat,TArray<byte> Bytes,bool bUseLSB=false) {}
	public void IntValueToBytes(int InValue,EDMXFixtureSignalFormat InSignalFormat,TArray<byte> Bytes,bool bUseLSB=false) {}
	public float IntToNormalizedValue(int InValue,EDMXFixtureSignalFormat InSignalFormat,float ReturnValue) { return default; }
	public float GetNormalizedAttributeValue(UObject InFixturePatch,FDMXAttributeName InFunctionAttribute,int InValue,float ReturnValue) { return default; }
	public UObject GetFixtureType(FDMXEntityFixtureTypeRef InFixtureType,UObject ReturnValue) { return default; }
	public UObject GetFixturePatch(FDMXEntityFixturePatchRef InFixturePatch,UObject ReturnValue) { return default; }
	public bool GetFunctionsMap(UObject InFixturePatch,TMap<FDMXAttributeName,int> OutAttributesMap,bool ReturnValue) { return default; }
	public bool GetFunctionsMapForPatch(UObject InFixturePatch,TMap<FDMXAttributeName,int> OutAttributesMap,bool ReturnValue) { return default; }
	public int GetFunctionsValue(sbyte FunctionAttributeName,TMap<FDMXAttributeName,int> InAttributesMap,int ReturnValue) { return default; }
	public bool PatchIsOfSelectedType(UObject InFixturePatch,sbyte RefTypeValue,bool ReturnValue) { return default; }
	public UObject GetDMXSubsystem_Pure(UObject ReturnValue) { return default; }
	public UObject GetDMXSubsystem_Callable(UObject ReturnValue) { return default; }
	public sbyte GetAttributeLabel(FDMXAttributeName AttributeName,sbyte ReturnValue) { return default; }
	public FProtocolReceivedDelegate OnProtocolReceived_DEPRECATED;
	public bool SetMatrixCellValue(UObject FixturePatch,FIntPoint Coordinate,FDMXAttributeName Attribute,int Value,bool ReturnValue) { return default; }
	public bool GetMatrixCellValue(UObject FixturePatch,FIntPoint Coordinate,TMap<FDMXAttributeName,int> AttributeValueMap,bool ReturnValue) { return default; }
	public bool GetMatrixCellChannelsRelative(UObject FixturePatch,FIntPoint Coordinate,TMap<FDMXAttributeName,int> AttributeChannelMap,bool ReturnValue) { return default; }
	public bool GetMatrixCellChannelsAbsolute(UObject FixturePatch,FIntPoint Coordinate,TMap<FDMXAttributeName,int> AttributeChannelMap,bool ReturnValue) { return default; }
	public bool GetMatrixProperties(UObject FixturePatch,FDMXFixtureMatrix MatrixProperties,bool ReturnValue) { return default; }
	public bool GetCellAttributes(UObject FixturePatch,TArray<FDMXAttributeName> CellAttributes,bool ReturnValue) { return default; }
	public bool GetMatrixCell(UObject FixturePatch,FIntPoint Coordinate,FDMXCell Cell,bool ReturnValue) { return default; }
	public bool GetAllMatrixCells(UObject FixturePatch,TArray<FDMXCell> Cells,bool ReturnValue) { return default; }
	public void PixelMappingDistributionSort(EDMXPixelMappingDistribution InDistribution,int InNumXPanels,int InNumYPanels,TArray<int> InUnorderedList,TArray<int> OutSortedList) {}
	public void OnAssetRegistryAddedAsset(FAssetData Asset) {}
	public void OnAssetRegistryRemovedAsset(FAssetData Asset) {}
	public TArray<UDMXLibrary> LoadedDMXLibraries;
}
