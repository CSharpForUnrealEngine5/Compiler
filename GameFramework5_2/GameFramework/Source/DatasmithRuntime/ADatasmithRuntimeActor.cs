#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithRuntime.h")]
public partial class ADatasmithRuntimeActor : AActor {
// DatasmithRuntimeActor
	public bool IsConnected(bool ReturnValue) { return default; }
	public sbyte GetDestinationName(sbyte ReturnValue) { return default; }
	public sbyte GetSourceName(sbyte ReturnValue) { return default; }
	public bool OpenConnectionWithIndex(int SourceIndex,bool ReturnValue) { return default; }
	public void CloseConnection() {}
	public int GetSourceIndex(int ReturnValue) { return default; }
	public float Progress;
	public bool bBuilding;
	public sbyte LoadedScene;
	public FDatasmithRuntimeImportOptions ImportOptions;
	public sbyte ExternalFile;
	public bool IsReceiving(bool ReturnValue) { return default; }
	public void Reset() {}
	public bool LoadFile(sbyte FilePath,bool ReturnValue) { return default; }
}
