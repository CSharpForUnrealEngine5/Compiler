#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXEntityFixturePatch.h")]
///<summary>A DMX fixture patch that can be patch to channels in a DMX Universe via the DMX Library Editor.</summary>
public partial class UDMXEntityFixturePatch : UDMXEntity {
// DMXEntityFixturePatch
	public void FDMXOnFixturePatchReceivedDMXDelegate(UObject FixturePatch,FDMXNormalizedAttributeValueMap ValuePerAttribute) {}
	public UObject CreateFixturePatchInLibrary(FDMXEntityFixturePatchConstructionParams ConstructionParams,sbyte DesiredName=TEXT,bool bMarkDMXLibraryDirty=true,UObject ReturnValue) { return default; }
	public void RemoveFixturePatchFromLibrary(FDMXEntityFixturePatchRef FixturePatchRef) {}
	public void SendDMX(TMap<FDMXAttributeName,int> AttributeMap) {}
	public FDMXOnFixturePatchReceivedDMXDelegate OnFixturePatchReceivedDMX;
	public void SetFixtureType(UObject NewFixtureType) {}
	public void SetStartingChannel(int NewStartingChannel) {}
	public int GetStartingChannel(int ReturnValue) { return default; }
	public int GetChannelSpan(int ReturnValue) { return default; }
	public int GetEndingChannel(int ReturnValue) { return default; }
	public int UniverseID;
	public bool bAutoAssignAddress_DEPRECATED;
	public int ManualStartingAddress_DEPRECATED;
	public int AutoStartingAddress_DEPRECATED;
	public int StartingChannel;
	public UDMXEntityFixtureType ParentFixtureTypeTemplate;
	public int ActiveMode;
	public FGuid MVRFixtureUUID;
	public TArray<sbyte> CustomTags;
	public FLinearColor EditorColor;
	public bool bReceiveDMXInEditor;
	public int GetRemoteUniverse(int ReturnValue) { return default; }
	public TArray<FDMXAttributeName> GetAllAttributesInActiveMode(TArray<FDMXAttributeName> ReturnValue) { return default; }
	public TMap<FDMXAttributeName,FDMXFixtureFunction> GetAttributeFunctionsMap(TMap<FDMXAttributeName,FDMXFixtureFunction> ReturnValue) { return default; }
	public TMap<FDMXAttributeName,int> GetAttributeDefaultMap(TMap<FDMXAttributeName,int> ReturnValue) { return default; }
	public TMap<FDMXAttributeName,int> GetAttributeChannelAssignments(TMap<FDMXAttributeName,int> ReturnValue) { return default; }
	public TMap<FDMXAttributeName,EDMXFixtureSignalFormat> GetAttributeSignalFormats(TMap<FDMXAttributeName,EDMXFixtureSignalFormat> ReturnValue) { return default; }
	public TMap<FDMXAttributeName,int> ConvertRawMapToAttributeMap(TMap<int,byte> RawMap,TMap<FDMXAttributeName,int> ReturnValue) { return default; }
	public TMap<int,byte> ConvertAttributeMapToRawMap(TMap<FDMXAttributeName,int> FunctionMap,TMap<int,byte> ReturnValue) { return default; }
	public bool IsMapValid(TMap<FDMXAttributeName,int> FunctionMap,bool ReturnValue) { return default; }
	public bool ContainsAttribute(FDMXAttributeName FunctionAttribute,bool ReturnValue) { return default; }
	public TMap<FDMXAttributeName,int> ConvertToValidMap(TMap<FDMXAttributeName,int> FunctionMap,TMap<FDMXAttributeName,int> ReturnValue) { return default; }
	public TArray<UObject> GetRelevantControllers(TArray<UObject> ReturnValue) { return default; }
	public bool IsInControllerRange(UObject InController,bool ReturnValue) { return default; }
	public bool IsInControllersRange(TArray<UObject> InControllers,bool ReturnValue) { return default; }
	public int GetAttributeValue(FDMXAttributeName Attribute,bool bSuccess,int ReturnValue) { return default; }
	public float GetNormalizedAttributeValue(FDMXAttributeName Attribute,bool bSuccess,float ReturnValue) { return default; }
	public void GetAttributesValues(TMap<FDMXAttributeName,int> AttributesValues) {}
	public void GetNormalizedAttributesValues(FDMXNormalizedAttributeValueMap NormalizedAttributesValues) {}
	public bool SendMatrixCellValue(FIntPoint CellCoordinate,FDMXAttributeName Attribute,int Value,bool ReturnValue) { return default; }
	public bool SendMatrixCellValueWithAttributeMap(FIntPoint CellCoordinate,FDMXAttributeName Attribute,int Value,TMap<FDMXAttributeName,int> InAttributeNameChannelMap,bool ReturnValue) { return default; }
	public bool SendNormalizedMatrixCellValue(FIntPoint CellCoordinate,FDMXAttributeName Attribute,float RelativeValue,bool ReturnValue) { return default; }
	public bool GetMatrixCellValues(FIntPoint CellCoordinate,TMap<FDMXAttributeName,int> ValuePerAttribute,bool ReturnValue) { return default; }
	public bool GetNormalizedMatrixCellValues(FIntPoint CellCoordinate,TMap<FDMXAttributeName,float> NormalizedValuePerAttribute,bool ReturnValue) { return default; }
	public bool GetMatrixCellChannelsRelative(FIntPoint CellCoordinate,TMap<FDMXAttributeName,int> AttributeChannelMap,bool ReturnValue) { return default; }
	public bool GetMatrixCellChannelsAbsolute(FIntPoint CellCoordinate,TMap<FDMXAttributeName,int> AttributeChannelMap,bool ReturnValue) { return default; }
	public bool GetMatrixCellChannelsAbsoluteWithValidation(FIntPoint InCellCoordinate,TMap<FDMXAttributeName,int> OutAttributeChannelMap,bool ReturnValue) { return default; }
	public bool GetMatrixProperties(FDMXFixtureMatrix MatrixProperties,bool ReturnValue) { return default; }
	public bool GetCellAttributes(TArray<FDMXAttributeName> CellAttributes,bool ReturnValue) { return default; }
	public bool GetMatrixCell(FIntPoint CellCoordinate,FDMXCell Cell,bool ReturnValue) { return default; }
	public bool GetAllMatrixCells(TArray<FDMXCell> Cells,bool ReturnValue) { return default; }
}
