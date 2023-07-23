#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertySets/CreateMeshObjectTypeProperties.h")]
///<summary>UCreateMeshObjectTypeProperties is a InteractiveTool PropertySet used to select</summary>
public partial class UCreateMeshObjectTypeProperties : UInteractiveToolPropertySet {
// CreateMeshObjectTypeProperties
	public sbyte OutputType;
	public UClass VolumeType;
	public TArray<sbyte> GetOutputTypeNamesFunc(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> OutputTypeNamesList;
	public bool bShowVolumeList;
	public bool ShouldShowPropertySet(bool ReturnValue) { return default; }
	public ECreateObjectTypeHint GetCurrentCreateMeshType(ECreateObjectTypeHint ReturnValue) { return default; }
}
