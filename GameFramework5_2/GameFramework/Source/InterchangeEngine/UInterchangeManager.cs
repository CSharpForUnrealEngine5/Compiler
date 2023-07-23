#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeManager.h")]
public partial class UInterchangeManager : UObject {
// InterchangeManager
	public UObject GetInterchangeManagerScripted(UObject ReturnValue) { return default; }
	public bool ImportAsset(sbyte ContentPath,UObject SourceData,FImportAssetParameters ImportAssetParameters,bool ReturnValue) { return default; }
	public bool ImportScene(sbyte ContentPath,UObject SourceData,FImportAssetParameters ImportAssetParameters,bool ReturnValue) { return default; }
	public bool ExportAsset(UObject Asset,bool bIsAutomated=false,bool ReturnValue) { return default; }
	public bool ExportScene(UObject World,bool bIsAutomated=false,bool ReturnValue) { return default; }
	public UObject CreateSourceData(sbyte InFileName,UObject ReturnValue) { return default; }
	public UClass GetRegisteredFactoryClass(UClass ClassToMake,UClass ReturnValue) { return default; }
	public TSet<UClass> RegisteredTranslatorsClass;
	public TMap<UClass,UClass> RegisteredFactoryClasses;
	public TMap<UClass,UInterchangeWriterBase> RegisteredWriters;
}
