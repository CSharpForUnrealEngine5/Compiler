#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeObject.h")]
public partial struct FCustomizableObjectState {
// CustomizableObjectState
	public sbyte Name;
	public TArray<sbyte> RuntimeParameters;
	public bool bDontCompressRuntimeTextures;
	public bool bLiveUpdateMode;
	public bool bReuseInstanceTextures;
	public bool bBuildOnlyFirstLOD;
	public TMap<sbyte,sbyte> ForcedParameterValues;
	public FMutableParamUIMetadata StateUIMetadata;
}
